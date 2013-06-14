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
            this._fileDialog = new System.Windows.Forms.OpenFileDialog();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.splitTabPage.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(446, 212);
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
            this.splitTabPage.Size = new System.Drawing.Size(438, 186);
            this.splitTabPage.TabIndex = 0;
            this.splitTabPage.Text = "Split";
            this.splitTabPage.UseVisualStyleBackColor = true;
            // 
            // _splitOutputBrowseButton
            // 
            this._splitOutputBrowseButton.Location = new System.Drawing.Point(312, 57);
            this._splitOutputBrowseButton.Name = "_splitOutputBrowseButton";
            this._splitOutputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this._splitOutputBrowseButton.TabIndex = 8;
            this._splitOutputBrowseButton.Text = "Browse...";
            this._splitOutputBrowseButton.UseVisualStyleBackColor = true;
            this._splitOutputBrowseButton.Click += new System.EventHandler(this.SplitOutputBrowseButtonClick);
            // 
            // _splitOutputTextBox
            // 
            this._splitOutputTextBox.Location = new System.Drawing.Point(96, 58);
            this._splitOutputTextBox.Name = "_splitOutputTextBox";
            this._splitOutputTextBox.Size = new System.Drawing.Size(210, 20);
            this._splitOutputTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Split Column";
            // 
            // _splitColumnTextBox
            // 
            this._splitColumnTextBox.Location = new System.Drawing.Point(96, 93);
            this._splitColumnTextBox.Name = "_splitColumnTextBox";
            this._splitColumnTextBox.Size = new System.Drawing.Size(154, 20);
            this._splitColumnTextBox.TabIndex = 4;
            this._splitColumnTextBox.Text = "Division";
            // 
            // _splitButton
            // 
            this._splitButton.Location = new System.Drawing.Point(96, 142);
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
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File";
            // 
            // _splitInputBrowseButton
            // 
            this._splitInputBrowseButton.Location = new System.Drawing.Point(312, 28);
            this._splitInputBrowseButton.Name = "_splitInputBrowseButton";
            this._splitInputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this._splitInputBrowseButton.TabIndex = 1;
            this._splitInputBrowseButton.Text = "Browse...";
            this._splitInputBrowseButton.UseVisualStyleBackColor = true;
            this._splitInputBrowseButton.Click += new System.EventHandler(this.SplitInputBrowseButtonClick);
            // 
            // _splitInputTextBox
            // 
            this._splitInputTextBox.Location = new System.Drawing.Point(96, 31);
            this._splitInputTextBox.Name = "_splitInputTextBox";
            this._splitInputTextBox.Size = new System.Drawing.Size(210, 20);
            this._splitInputTextBox.TabIndex = 0;
            // 
            // combineTabPage
            // 
            this.combineTabPage.Location = new System.Drawing.Point(4, 22);
            this.combineTabPage.Name = "combineTabPage";
            this.combineTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.combineTabPage.Size = new System.Drawing.Size(672, 374);
            this.combineTabPage.TabIndex = 1;
            this.combineTabPage.Text = "Combine";
            this.combineTabPage.UseVisualStyleBackColor = true;
            // 
            // _fileDialog
            // 
            this._fileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 212);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Accuvant MultiTrackerTool";
            this.tabControl1.ResumeLayout(false);
            this.splitTabPage.ResumeLayout(false);
            this.splitTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage splitTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _splitInputBrowseButton;
        private System.Windows.Forms.TextBox _splitInputTextBox;
        private System.Windows.Forms.TabPage combineTabPage;
        private System.Windows.Forms.OpenFileDialog _fileDialog;
        private System.Windows.Forms.Button _splitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _splitColumnTextBox;
        private System.Windows.Forms.Button _splitOutputBrowseButton;
        private System.Windows.Forms.TextBox _splitOutputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
    }
}

