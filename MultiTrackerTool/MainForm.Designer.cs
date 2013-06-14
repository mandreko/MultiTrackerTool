namespace MultiTrackerTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitTabPage = new System.Windows.Forms.TabPage();
            this._splitOutputBrowseButton = new System.Windows.Forms.Button();
            this._splitOutputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._splitColumnTextBox = new System.Windows.Forms.TextBox();
            this._splitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._splitInputBrowseButton = new System.Windows.Forms.Button();
            this._splitInputTextBox = new System.Windows.Forms.TextBox();
            this.combineTabPage = new System.Windows.Forms.TabPage();
            this._combineSplitColumnTextBox = new System.Windows.Forms.TextBox();
            this._combineAddSplitColumnCheckbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._combineNewIgnoreItemButton = new System.Windows.Forms.Button();
            this._combineNewIgnoreItemTextBox = new System.Windows.Forms.TextBox();
            this._combineIgnoreItemsListBox = new System.Windows.Forms.ListBox();
            this._combineButton = new System.Windows.Forms.Button();
            this._combineOutputButton = new System.Windows.Forms.Button();
            this._combineInputButton = new System.Windows.Forms.Button();
            this._combineOutputTextBox = new System.Windows.Forms.TextBox();
            this._combineInputTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._splitInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._splitOutputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._combineInputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._combineOutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.splitTabPage.SuspendLayout();
            this.combineTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.splitTabPage);
            this.tabControl1.Controls.Add(this.combineTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // splitTabPage
            // 
            this.splitTabPage.Controls.Add(this._splitOutputBrowseButton);
            this.splitTabPage.Controls.Add(this._splitOutputTextBox);
            this.splitTabPage.Controls.Add(this.label3);
            this.splitTabPage.Controls.Add(this.label2);
            this.splitTabPage.Controls.Add(this._splitColumnTextBox);
            this.splitTabPage.Controls.Add(this._splitButton);
            this.splitTabPage.Controls.Add(this.label1);
            this.splitTabPage.Controls.Add(this._splitInputBrowseButton);
            this.splitTabPage.Controls.Add(this._splitInputTextBox);
            this.splitTabPage.Location = new System.Drawing.Point(4, 22);
            this.splitTabPage.Name = "splitTabPage";
            this.splitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.splitTabPage.Size = new System.Drawing.Size(438, 337);
            this.splitTabPage.TabIndex = 0;
            this.splitTabPage.Text = "Split";
            this.splitTabPage.UseVisualStyleBackColor = true;
            // 
            // _splitOutputBrowseButton
            // 
            this._splitOutputBrowseButton.Location = new System.Drawing.Point(310, 44);
            this._splitOutputBrowseButton.Name = "_splitOutputBrowseButton";
            this._splitOutputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this._splitOutputBrowseButton.TabIndex = 8;
            this._splitOutputBrowseButton.Text = "Browse...";
            this._splitOutputBrowseButton.UseVisualStyleBackColor = true;
            this._splitOutputBrowseButton.Click += new System.EventHandler(this.SplitOutputBrowseButtonClick);
            // 
            // _splitOutputTextBox
            // 
            this._splitOutputTextBox.Location = new System.Drawing.Point(94, 45);
            this._splitOutputTextBox.Name = "_splitOutputTextBox";
            this._splitOutputTextBox.Size = new System.Drawing.Size(210, 20);
            this._splitOutputTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Split Column";
            // 
            // _splitColumnTextBox
            // 
            this._splitColumnTextBox.Location = new System.Drawing.Point(94, 80);
            this._splitColumnTextBox.Name = "_splitColumnTextBox";
            this._splitColumnTextBox.Size = new System.Drawing.Size(154, 20);
            this._splitColumnTextBox.TabIndex = 4;
            this._splitColumnTextBox.Text = "Division";
            // 
            // _splitButton
            // 
            this._splitButton.Location = new System.Drawing.Point(94, 129);
            this._splitButton.Name = "_splitButton";
            this._splitButton.Size = new System.Drawing.Size(75, 23);
            this._splitButton.TabIndex = 3;
            this._splitButton.Text = "Split";
            this._splitButton.UseVisualStyleBackColor = true;
            this._splitButton.Click += new System.EventHandler(this.SplitButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File";
            // 
            // _splitInputBrowseButton
            // 
            this._splitInputBrowseButton.Location = new System.Drawing.Point(310, 15);
            this._splitInputBrowseButton.Name = "_splitInputBrowseButton";
            this._splitInputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this._splitInputBrowseButton.TabIndex = 1;
            this._splitInputBrowseButton.Text = "Browse...";
            this._splitInputBrowseButton.UseVisualStyleBackColor = true;
            this._splitInputBrowseButton.Click += new System.EventHandler(this.SplitInputBrowseButtonClick);
            // 
            // _splitInputTextBox
            // 
            this._splitInputTextBox.Location = new System.Drawing.Point(94, 18);
            this._splitInputTextBox.Name = "_splitInputTextBox";
            this._splitInputTextBox.Size = new System.Drawing.Size(210, 20);
            this._splitInputTextBox.TabIndex = 0;
            // 
            // combineTabPage
            // 
            this.combineTabPage.Controls.Add(this._combineSplitColumnTextBox);
            this.combineTabPage.Controls.Add(this._combineAddSplitColumnCheckbox);
            this.combineTabPage.Controls.Add(this.label7);
            this.combineTabPage.Controls.Add(this.label6);
            this.combineTabPage.Controls.Add(this._combineNewIgnoreItemButton);
            this.combineTabPage.Controls.Add(this._combineNewIgnoreItemTextBox);
            this.combineTabPage.Controls.Add(this._combineIgnoreItemsListBox);
            this.combineTabPage.Controls.Add(this._combineButton);
            this.combineTabPage.Controls.Add(this._combineOutputButton);
            this.combineTabPage.Controls.Add(this._combineInputButton);
            this.combineTabPage.Controls.Add(this._combineOutputTextBox);
            this.combineTabPage.Controls.Add(this._combineInputTextBox);
            this.combineTabPage.Controls.Add(this.label5);
            this.combineTabPage.Controls.Add(this.label4);
            this.combineTabPage.Location = new System.Drawing.Point(4, 22);
            this.combineTabPage.Name = "combineTabPage";
            this.combineTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.combineTabPage.Size = new System.Drawing.Size(438, 337);
            this.combineTabPage.TabIndex = 1;
            this.combineTabPage.Text = "Combine";
            this.combineTabPage.UseVisualStyleBackColor = true;
            // 
            // _combineSplitColumnTextBox
            // 
            this._combineSplitColumnTextBox.Location = new System.Drawing.Point(121, 109);
            this._combineSplitColumnTextBox.Name = "_combineSplitColumnTextBox";
            this._combineSplitColumnTextBox.Size = new System.Drawing.Size(154, 20);
            this._combineSplitColumnTextBox.TabIndex = 13;
            this._combineSplitColumnTextBox.Text = "Division";
            // 
            // _combineAddSplitColumnCheckbox
            // 
            this._combineAddSplitColumnCheckbox.AutoSize = true;
            this._combineAddSplitColumnCheckbox.Checked = true;
            this._combineAddSplitColumnCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._combineAddSplitColumnCheckbox.Location = new System.Drawing.Point(121, 86);
            this._combineAddSplitColumnCheckbox.Name = "_combineAddSplitColumnCheckbox";
            this._combineAddSplitColumnCheckbox.Size = new System.Drawing.Size(106, 17);
            this._combineAddSplitColumnCheckbox.TabIndex = 12;
            this._combineAddSplitColumnCheckbox.Text = "Add Split Column";
            this._combineAddSplitColumnCheckbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Split Column";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sheets to ignore split";
            // 
            // _combineNewIgnoreItemButton
            // 
            this._combineNewIgnoreItemButton.Location = new System.Drawing.Point(281, 133);
            this._combineNewIgnoreItemButton.Name = "_combineNewIgnoreItemButton";
            this._combineNewIgnoreItemButton.Size = new System.Drawing.Size(75, 23);
            this._combineNewIgnoreItemButton.TabIndex = 9;
            this._combineNewIgnoreItemButton.Text = "Add";
            this._combineNewIgnoreItemButton.UseVisualStyleBackColor = true;
            this._combineNewIgnoreItemButton.Click += new System.EventHandler(this.AddItemToIgnoreList);
            // 
            // _combineNewIgnoreItemTextBox
            // 
            this._combineNewIgnoreItemTextBox.Location = new System.Drawing.Point(121, 135);
            this._combineNewIgnoreItemTextBox.Name = "_combineNewIgnoreItemTextBox";
            this._combineNewIgnoreItemTextBox.Size = new System.Drawing.Size(154, 20);
            this._combineNewIgnoreItemTextBox.TabIndex = 8;
            // 
            // _combineIgnoreItemsListBox
            // 
            this._combineIgnoreItemsListBox.FormattingEnabled = true;
            this._combineIgnoreItemsListBox.Items.AddRange(new object[] {
            "Criticality_Overview"});
            this._combineIgnoreItemsListBox.Location = new System.Drawing.Point(121, 164);
            this._combineIgnoreItemsListBox.Name = "_combineIgnoreItemsListBox";
            this._combineIgnoreItemsListBox.Size = new System.Drawing.Size(154, 95);
            this._combineIgnoreItemsListBox.TabIndex = 7;
            // 
            // _combineButton
            // 
            this._combineButton.Location = new System.Drawing.Point(121, 283);
            this._combineButton.Name = "_combineButton";
            this._combineButton.Size = new System.Drawing.Size(75, 23);
            this._combineButton.TabIndex = 6;
            this._combineButton.Text = "Combine";
            this._combineButton.UseVisualStyleBackColor = true;
            this._combineButton.Click += new System.EventHandler(this.CombineButtonClick);
            // 
            // _combineOutputButton
            // 
            this._combineOutputButton.Location = new System.Drawing.Point(337, 45);
            this._combineOutputButton.Name = "_combineOutputButton";
            this._combineOutputButton.Size = new System.Drawing.Size(75, 23);
            this._combineOutputButton.TabIndex = 5;
            this._combineOutputButton.Text = "Browse...";
            this._combineOutputButton.UseVisualStyleBackColor = true;
            this._combineOutputButton.Click += new System.EventHandler(this.CombineOutputButtonClick);
            // 
            // _combineInputButton
            // 
            this._combineInputButton.Location = new System.Drawing.Point(337, 16);
            this._combineInputButton.Name = "_combineInputButton";
            this._combineInputButton.Size = new System.Drawing.Size(75, 23);
            this._combineInputButton.TabIndex = 4;
            this._combineInputButton.Text = "Browse...";
            this._combineInputButton.UseVisualStyleBackColor = true;
            this._combineInputButton.Click += new System.EventHandler(this.CombineInputButtonClick);
            // 
            // _combineOutputTextBox
            // 
            this._combineOutputTextBox.Location = new System.Drawing.Point(121, 47);
            this._combineOutputTextBox.Name = "_combineOutputTextBox";
            this._combineOutputTextBox.Size = new System.Drawing.Size(210, 20);
            this._combineOutputTextBox.TabIndex = 3;
            // 
            // _combineInputTextBox
            // 
            this._combineInputTextBox.Location = new System.Drawing.Point(121, 18);
            this._combineInputTextBox.Name = "_combineInputTextBox";
            this._combineInputTextBox.Size = new System.Drawing.Size(210, 20);
            this._combineInputTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Output File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input Folder";
            // 
            // _splitInputFileDialog
            // 
            this._splitInputFileDialog.Filter = "Microsoft Excel Files|*.xlsx";
            // 
            // _combineOutputFileDialog
            // 
            this._combineOutputFileDialog.Filter = "Microsoft Excel Files|*.xlsx";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 363);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Accuvant MultiTrackerTool";
            this.tabControl1.ResumeLayout(false);
            this.splitTabPage.ResumeLayout(false);
            this.splitTabPage.PerformLayout();
            this.combineTabPage.ResumeLayout(false);
            this.combineTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage splitTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _splitInputBrowseButton;
        private System.Windows.Forms.TextBox _splitInputTextBox;
        private System.Windows.Forms.TabPage combineTabPage;
        private System.Windows.Forms.OpenFileDialog _splitInputFileDialog;
        private System.Windows.Forms.Button _splitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _splitColumnTextBox;
        private System.Windows.Forms.Button _splitOutputBrowseButton;
        private System.Windows.Forms.TextBox _splitOutputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog _splitOutputFolderBrowserDialog;
        private System.Windows.Forms.Button _combineButton;
        private System.Windows.Forms.Button _combineOutputButton;
        private System.Windows.Forms.Button _combineInputButton;
        private System.Windows.Forms.TextBox _combineOutputTextBox;
        private System.Windows.Forms.TextBox _combineInputTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog _combineInputFolderBrowserDialog;
        private System.Windows.Forms.ListBox _combineIgnoreItemsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _combineNewIgnoreItemButton;
        private System.Windows.Forms.TextBox _combineNewIgnoreItemTextBox;
        private System.Windows.Forms.TextBox _combineSplitColumnTextBox;
        private System.Windows.Forms.CheckBox _combineAddSplitColumnCheckbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog _combineOutputFileDialog;
    }
}

