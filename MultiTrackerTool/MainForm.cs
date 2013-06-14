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
            var result = _fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _splitInputTextBox.Text = _fileDialog.FileName;
            }
        }

        /// <summary>
        /// Allows user to select an output folder.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplitOutputBrowseButtonClick(object sender, EventArgs e)
        {
            var result = _folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _splitOutputTextBox.Text = _folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Starts the logic for splitting files
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

                var inputFileName = Path.GetFileNameWithoutExtension(_splitInputTextBox.Text);
                var extension = Path.GetExtension(_splitInputTextBox.Text);
                var outputFile = Path.Combine(_splitOutputTextBox.Text, string.Format("{0}_{1}{2}", inputFileName, division, extension));
                divisionWorkbook.SaveAs(outputFile);
            }

            MessageBox.Show("Files have been saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Private Methods

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
