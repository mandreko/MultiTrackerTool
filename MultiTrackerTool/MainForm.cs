using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.XlsIO;

namespace MultiTrackerTool
{
    public partial class MainForm : Form
    {
        #region Class Members

        private readonly ExcelEngine _excelEngine;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _excelEngine = new ExcelEngine();
        }

        #endregion

        #region Events

        /// <summary>
        /// Allows user to select an input file.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplitInputBrowseButtonClick(object sender, EventArgs e)
        {
            var result = _splitInputFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _splitInputTextBox.Text = _splitInputFileDialog.FileName;
            }
        }

        /// <summary>
        /// Allows user to select an output folder.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplitOutputBrowseButtonClick(object sender, EventArgs e)
        {
            var result = _splitOutputFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _splitOutputTextBox.Text = _splitOutputFolderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Allows user to select an input folder.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CombineInputButtonClick(object sender, EventArgs e)
        {
            var result = _combineInputFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _combineInputTextBox.Text = _combineInputFolderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Allows user to select an output file.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CombineOutputButtonClick(object sender, EventArgs e)
        {
            var result = _combineOutputFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _combineOutputTextBox.Text = _combineOutputFileDialog.FileName;
            }
        }

        /// <summary>
        /// Adds a new item to the ignore list.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddItemToIgnoreList(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_combineNewIgnoreItemTextBox.Text) && !_combineIgnoreItemsListBox.Items.Contains(_combineNewIgnoreItemTextBox.Text))
            {
                _combineIgnoreItemsListBox.Items.Add(_combineNewIgnoreItemTextBox.Text);
                _combineInputTextBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Starts the logic for splitting files.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplitButtonClick(object sender, EventArgs e)
        {
            if (!File.Exists(_splitInputTextBox.Text))
            {
                MessageBox.Show("The file could not be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var workbook = _excelEngine.Excel.Workbooks.Open(_splitInputTextBox.Text, ExcelOpenType.Automatic);

            var distinctDivisions = GetDivisions(workbook);

            foreach(var division in distinctDivisions)
            {
                IWorkbook divisionWorkbook = _excelEngine.Excel.Workbooks.Create();
                divisionWorkbook.Version = workbook.Version;

                foreach(IWorksheet sheet in workbook.Worksheets)
                {
                    IWorksheet divisionWorksheet = divisionWorkbook.Worksheets.AddCopy(sheet, ExcelWorksheetCopyFlags.CopyAll);

                    FilterNonDivisionWorksheet(divisionWorksheet, division);
                }

                divisionWorkbook.Worksheets.Remove("Sheet1");
                divisionWorkbook.Worksheets.Remove("Sheet2");
                divisionWorkbook.Worksheets.Remove("Sheet3");

                divisionWorkbook.Worksheets[0].Activate();

                var inputFileName = Path.GetFileNameWithoutExtension(_splitInputTextBox.Text);
                var extension = Path.GetExtension(_splitInputTextBox.Text);
                var outputFile = Path.Combine(_splitOutputTextBox.Text, string.Format("{0}_{1}{2}", inputFileName, division, extension));
                divisionWorkbook.SaveAs(outputFile);
            }

            MessageBox.Show("Files have been saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Starts the logic for combining files.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CombineButtonClick(object sender, EventArgs e)
        {
            IWorkbook combinedWorkbook = _excelEngine.Excel.Workbooks.Create();
            //divisionWorkbook.Version = workbook.Version;

            foreach(var excelFile in Directory.GetFiles(_combineInputTextBox.Text, "*.xlsx"))
            {
                var workbook = _excelEngine.Excel.Workbooks.Open(excelFile, ExcelOpenType.Automatic);
                var division = Path.GetFileNameWithoutExtension(excelFile);

                // iterate through each worksheet
                foreach(IWorksheet worksheet in workbook.Worksheets)
                {
                    var combinedWorksheet = combinedWorkbook.Worksheets[worksheet.Name];

                    // if worksheet doesn't exist create it - via copy
                    if (combinedWorksheet == null)
                    {
                        combinedWorkbook.Version = workbook.Version;
                        combinedWorkbook.Worksheets.AddCopy(worksheet);
                        // since it was null, re-establish this variable
                        combinedWorksheet = combinedWorkbook.Worksheets[worksheet.Name];

                        if (_combineAddSplitColumnCheckbox.Checked && !_combineIgnoreItemsListBox.Items.Contains(worksheet.Name))
                        {
                            AddDivisionColumn(combinedWorksheet.UsedRange, division, true);
                        }
                    }
                    // else merge data in
                    else
                    {
                        // Don't merge if it's an ignored sheet or the data is empty
                        if (_combineIgnoreItemsListBox.Items.Contains(worksheet.Name) || worksheet.UsedRange.LastRow == 1) continue;

                        var endRange = combinedWorksheet.UsedRange.End;
                        var firstEmpty = combinedWorksheet.Range[endRange.Row + 1, 1];
                        
                        // Grab the existing data, minus the headers, and copy them into the first empty range in the new sheet
                        var existingRangeWithoutHeaders = worksheet.Range[2, 1, worksheet.UsedRange.LastRow, worksheet.UsedRange.LastColumn];
                        var newRange = existingRangeWithoutHeaders.CopyTo(firstEmpty, ExcelCopyRangeOptions.All);
                        if (_combineAddSplitColumnCheckbox.Checked)
                        {
                            AddDivisionColumn(newRange, division, false);
                        }
                    }
                }
            }

            combinedWorkbook.Worksheets.Remove("Sheet1");
            combinedWorkbook.Worksheets.Remove("Sheet2");
            combinedWorkbook.Worksheets.Remove("Sheet3");

            combinedWorkbook.Worksheets[0].Activate();

            combinedWorkbook.SaveAs(_combineOutputTextBox.Text);

            MessageBox.Show("File has been saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        #endregion

        #region Private Methods

        /// <summary>
        /// Adds the division column.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <param name="division">The division.</param>
        /// <param name="addHeader">if set to <c>true</c> add the division header.</param>
        private void AddDivisionColumn(IRange range, string division, bool addHeader)
        {
            // move over all records 1 place to the right
            var worksheet = range.Worksheet;
            var newrange = worksheet.Range[range.Row, range.Column + 1, range.LastRow, range.LastColumn + 1];
            range.MoveTo(newrange);

            // add the division name in column 0, all the way down
            //var divisionRange = worksheet.Range[1, 1, range.LastRow, 1];
            var divisionRange = worksheet.Range[range.Row, 1, range.LastRow, 1];
            foreach (var cell in divisionRange.Cells)
            {
                // copy from the cell to the right, to get formatting, then set value
                worksheet.Range[cell.Row, cell.Column + 1].CopyTo(worksheet.Range[cell.Row, cell.Column]);
                worksheet.Range[cell.Row, cell.Column].Text = division;
            }
            
            // if addHeader is set to 'true', add the "Division" header item, by copying the header from column B (to keep style)
            if (addHeader)
            {
                worksheet.Range[1, 2].CopyTo(worksheet.Range[1, 1]);
                worksheet.Range[1, 1].Text = _combineSplitColumnTextBox.Text;
            }
        }

        /// <summary>
        /// Filters the worksheet, removing all items not matching the specific division.
        /// </summary>
        /// <param name="divisionWorksheet">The division worksheet.</param>
        /// <param name="division">The division.</param>
        private void FilterNonDivisionWorksheet(IWorksheet divisionWorksheet, string division)
        {
            int splitColumn;
            var sheetContainsSplitHeader = FindDivisionColumn(divisionWorksheet, out splitColumn);

            // Just return the entire sheet if it's not split by divisions
            if (!sheetContainsSplitHeader)
            {
                return;
            }

            // Note: worksheet.Rows is 0-based. worksheet.DeleteRow is 1-based. WTF
            for(int i=divisionWorksheet.Rows.Length;i>0;i--)
            {
                var divisionText = divisionWorksheet.Rows[i-1].Cells[splitColumn].Text;
                if (divisionText != division && divisionText != _splitColumnTextBox.Text)
                {
                    divisionWorksheet.DeleteRow(i);
                }
            }

            // Delete the existing Division Column
            divisionWorksheet.DeleteColumn(splitColumn+1);
        }

        /// <summary>
        /// Gets a unique list of divisions.
        /// </summary>
        /// <param name="workbook">The workbook.</param>
        /// <returns></returns>
        private IEnumerable<string> GetDivisions(IWorkbook workbook)
        {
            var distinctDivisions = new HashSet<string>();

            foreach (IWorksheet worksheet in workbook.Worksheets)
            {
                int splitColumn;
                var sheetContainsSplitHeader = FindDivisionColumn(worksheet, out splitColumn);

                // Get list of divisions
                if (sheetContainsSplitHeader)
                {
                    var divisionsPerSheet = worksheet.Columns[splitColumn].Cells.Select(cell => cell.Text).Distinct();
                    foreach (var division in divisionsPerSheet)
                    {
                        if (division != _splitColumnTextBox.Text)
                        {
                            distinctDivisions.Add(division);
                        }
                    }
                }
            }
            return distinctDivisions;
        }

        /// <summary>
        /// Finds the division column.
        /// </summary>
        /// <param name="worksheet">The worksheet.</param>
        /// <param name="splitColumn">The split column.</param>
        /// <returns></returns>
        private bool FindDivisionColumn(IWorksheet worksheet, out int splitColumn)
        {
            bool sheetContainsSplitHeader = false;
            splitColumn = 0;
            foreach (var cell in worksheet.Rows[0].Cells.Where(cell => cell.Text == _splitColumnTextBox.Text))
            {
                sheetContainsSplitHeader = true;
                splitColumn = cell.Column - 1;
                break;
            }
            return sheetContainsSplitHeader;
        }

        #endregion
    }
}
