namespace SapCleaner
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
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader1 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Name, "Filename", 120, 0, true);
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader2 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.FilePath, "Path", 160, 1, true);
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader3 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.DateModified, "Modified date", 100, 2, true);
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            this.NextButton = new System.Windows.Forms.Button();
            this.Separator = new System.Windows.Forms.Label();
            this.WizardPage1 = new System.Windows.Forms.Panel();
            this.SearchFolder = new Manina.Windows.Forms.FileSystemButton();
            this.SearchLarsaFiles = new System.Windows.Forms.CheckBox();
            this.SearchSafeFiles = new System.Windows.Forms.CheckBox();
            this.SearchEtabsFiles = new System.Windows.Forms.CheckBox();
            this.SearchSapFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WizardPage2 = new System.Windows.Forms.Panel();
            this.SearchFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WizardPage3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SelectAllFilesButton = new System.Windows.Forms.ToolStripButton();
            this.ClearSelectedFilesButton = new System.Windows.Forms.ToolStripButton();
            this.SelectFilesByDateButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SelectOlderThanOneWeekButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectOlderThanTwoWeeksButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectOlderThanOneMonthButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectOlderThanThreeMonthsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectOlderThanSixMonthsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectOlderThanOneYearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.UseRecycleBin = new System.Windows.Forms.CheckBox();
            this.SearchResultLabel = new System.Windows.Forms.Label();
            this.SearchResultList = new Manina.Windows.Forms.ImageListView();
            this.WizardPage4 = new System.Windows.Forms.Panel();
            this.DeleteFileLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteProgress = new System.Windows.Forms.ProgressBar();
            this.WizardPage5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteResultLabel = new System.Windows.Forms.Label();
            this.SearchFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.WizardPage1.SuspendLayout();
            this.WizardPage2.SuspendLayout();
            this.WizardPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.WizardPage4.SuspendLayout();
            this.WizardPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchProgress
            // 
            resources.ApplyResources(this.SearchProgress, "SearchProgress");
            this.SearchProgress.Name = "SearchProgress";
            // 
            // NextButton
            // 
            resources.ApplyResources(this.NextButton, "NextButton");
            this.NextButton.Name = "NextButton";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Separator
            // 
            resources.ApplyResources(this.Separator, "Separator");
            this.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator.Name = "Separator";
            // 
            // WizardPage1
            // 
            resources.ApplyResources(this.WizardPage1, "WizardPage1");
            this.WizardPage1.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage1.Controls.Add(this.SearchFolder);
            this.WizardPage1.Controls.Add(this.SearchLarsaFiles);
            this.WizardPage1.Controls.Add(this.SearchSafeFiles);
            this.WizardPage1.Controls.Add(this.SearchEtabsFiles);
            this.WizardPage1.Controls.Add(this.SearchSapFiles);
            this.WizardPage1.Controls.Add(this.label1);
            this.WizardPage1.Name = "WizardPage1";
            // 
            // SearchFolder
            // 
            resources.ApplyResources(this.SearchFolder, "SearchFolder");
            this.SearchFolder.Name = "SearchFolder";
            this.SearchFolder.Path = "C:\\";
            this.SearchFolder.Click += new System.EventHandler(this.SearchFolder_Click);
            // 
            // SearchLarsaFiles
            // 
            resources.ApplyResources(this.SearchLarsaFiles, "SearchLarsaFiles");
            this.SearchLarsaFiles.Checked = true;
            this.SearchLarsaFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchLarsaFiles.Name = "SearchLarsaFiles";
            this.SearchLarsaFiles.UseVisualStyleBackColor = true;
            this.SearchLarsaFiles.CheckedChanged += new System.EventHandler(this.SearchFiles_CheckedChanged);
            // 
            // SearchSafeFiles
            // 
            resources.ApplyResources(this.SearchSafeFiles, "SearchSafeFiles");
            this.SearchSafeFiles.Checked = true;
            this.SearchSafeFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchSafeFiles.Name = "SearchSafeFiles";
            this.SearchSafeFiles.UseVisualStyleBackColor = true;
            this.SearchSafeFiles.CheckedChanged += new System.EventHandler(this.SearchFiles_CheckedChanged);
            // 
            // SearchEtabsFiles
            // 
            resources.ApplyResources(this.SearchEtabsFiles, "SearchEtabsFiles");
            this.SearchEtabsFiles.Checked = true;
            this.SearchEtabsFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchEtabsFiles.Name = "SearchEtabsFiles";
            this.SearchEtabsFiles.UseVisualStyleBackColor = true;
            this.SearchEtabsFiles.CheckedChanged += new System.EventHandler(this.SearchFiles_CheckedChanged);
            // 
            // SearchSapFiles
            // 
            resources.ApplyResources(this.SearchSapFiles, "SearchSapFiles");
            this.SearchSapFiles.Checked = true;
            this.SearchSapFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchSapFiles.Name = "SearchSapFiles";
            this.SearchSapFiles.UseVisualStyleBackColor = true;
            this.SearchSapFiles.CheckedChanged += new System.EventHandler(this.SearchFiles_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // WizardPage2
            // 
            resources.ApplyResources(this.WizardPage2, "WizardPage2");
            this.WizardPage2.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage2.Controls.Add(this.SearchFileLabel);
            this.WizardPage2.Controls.Add(this.label2);
            this.WizardPage2.Controls.Add(this.SearchProgress);
            this.WizardPage2.Name = "WizardPage2";
            // 
            // SearchFileLabel
            // 
            resources.ApplyResources(this.SearchFileLabel, "SearchFileLabel");
            this.SearchFileLabel.AutoEllipsis = true;
            this.SearchFileLabel.Name = "SearchFileLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // WizardPage3
            // 
            resources.ApplyResources(this.WizardPage3, "WizardPage3");
            this.WizardPage3.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage3.Controls.Add(this.toolStrip1);
            this.WizardPage3.Controls.Add(this.UseRecycleBin);
            this.WizardPage3.Controls.Add(this.SearchResultLabel);
            this.WizardPage3.Controls.Add(this.SearchResultList);
            this.WizardPage3.Name = "WizardPage3";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllFilesButton,
            this.ClearSelectedFilesButton,
            this.SelectFilesByDateButton});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // SelectAllFilesButton
            // 
            resources.ApplyResources(this.SelectAllFilesButton, "SelectAllFilesButton");
            this.SelectAllFilesButton.Image = global::SapCleaner.Properties.Resources.lightbulb;
            this.SelectAllFilesButton.Name = "SelectAllFilesButton";
            this.SelectAllFilesButton.Click += new System.EventHandler(this.SelectAllFilesButton_Click);
            // 
            // ClearSelectedFilesButton
            // 
            resources.ApplyResources(this.ClearSelectedFilesButton, "ClearSelectedFilesButton");
            this.ClearSelectedFilesButton.Image = global::SapCleaner.Properties.Resources.lightbulb_off;
            this.ClearSelectedFilesButton.Name = "ClearSelectedFilesButton";
            this.ClearSelectedFilesButton.Click += new System.EventHandler(this.ClearSelectedFilesButton_Click);
            // 
            // SelectFilesByDateButton
            // 
            resources.ApplyResources(this.SelectFilesByDateButton, "SelectFilesByDateButton");
            this.SelectFilesByDateButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectOlderThanOneWeekButton,
            this.SelectOlderThanTwoWeeksButton,
            this.SelectOlderThanOneMonthButton,
            this.SelectOlderThanThreeMonthsButton,
            this.SelectOlderThanSixMonthsButton,
            this.SelectOlderThanOneYearButton});
            this.SelectFilesByDateButton.Image = global::SapCleaner.Properties.Resources.calendar;
            this.SelectFilesByDateButton.Name = "SelectFilesByDateButton";
            // 
            // SelectOlderThanOneWeekButton
            // 
            resources.ApplyResources(this.SelectOlderThanOneWeekButton, "SelectOlderThanOneWeekButton");
            this.SelectOlderThanOneWeekButton.Name = "SelectOlderThanOneWeekButton";
            this.SelectOlderThanOneWeekButton.Click += new System.EventHandler(this.SelectOlderThanOneWeekButton_Click);
            // 
            // SelectOlderThanTwoWeeksButton
            // 
            resources.ApplyResources(this.SelectOlderThanTwoWeeksButton, "SelectOlderThanTwoWeeksButton");
            this.SelectOlderThanTwoWeeksButton.Name = "SelectOlderThanTwoWeeksButton";
            this.SelectOlderThanTwoWeeksButton.Click += new System.EventHandler(this.SelectOlderThanTwoWeeksButton_Click);
            // 
            // SelectOlderThanOneMonthButton
            // 
            resources.ApplyResources(this.SelectOlderThanOneMonthButton, "SelectOlderThanOneMonthButton");
            this.SelectOlderThanOneMonthButton.Name = "SelectOlderThanOneMonthButton";
            this.SelectOlderThanOneMonthButton.Click += new System.EventHandler(this.SelectOlderThanOneMonthButton_Click);
            // 
            // SelectOlderThanThreeMonthsButton
            // 
            resources.ApplyResources(this.SelectOlderThanThreeMonthsButton, "SelectOlderThanThreeMonthsButton");
            this.SelectOlderThanThreeMonthsButton.Name = "SelectOlderThanThreeMonthsButton";
            this.SelectOlderThanThreeMonthsButton.Click += new System.EventHandler(this.SelectOlderThanThreeMonthsButton_Click);
            // 
            // SelectOlderThanSixMonthsButton
            // 
            resources.ApplyResources(this.SelectOlderThanSixMonthsButton, "SelectOlderThanSixMonthsButton");
            this.SelectOlderThanSixMonthsButton.Name = "SelectOlderThanSixMonthsButton";
            this.SelectOlderThanSixMonthsButton.Click += new System.EventHandler(this.SelectOlderThanSixMonthsButton_Click);
            // 
            // SelectOlderThanOneYearButton
            // 
            resources.ApplyResources(this.SelectOlderThanOneYearButton, "SelectOlderThanOneYearButton");
            this.SelectOlderThanOneYearButton.Name = "SelectOlderThanOneYearButton";
            this.SelectOlderThanOneYearButton.Click += new System.EventHandler(this.SelectOlderThanOneYearButton_Click);
            // 
            // UseRecycleBin
            // 
            resources.ApplyResources(this.UseRecycleBin, "UseRecycleBin");
            this.UseRecycleBin.Checked = true;
            this.UseRecycleBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseRecycleBin.Name = "UseRecycleBin";
            this.UseRecycleBin.UseVisualStyleBackColor = true;
            // 
            // SearchResultLabel
            // 
            resources.ApplyResources(this.SearchResultLabel, "SearchResultLabel");
            this.SearchResultLabel.Name = "SearchResultLabel";
            // 
            // SearchResultList
            // 
            resources.ApplyResources(this.SearchResultList, "SearchResultList");
            this.SearchResultList.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            ımageListViewColumnHeader1.Comparer = null;
            ımageListViewColumnHeader1.DisplayIndex = 0;
            ımageListViewColumnHeader1.Key = "";
            ımageListViewColumnHeader1.Text = "Filename";
            ımageListViewColumnHeader1.Type = Manina.Windows.Forms.ColumnType.Name;
            ımageListViewColumnHeader1.Width = 120;
            ımageListViewColumnHeader2.Comparer = null;
            ımageListViewColumnHeader2.DisplayIndex = 1;
            ımageListViewColumnHeader2.Key = "";
            ımageListViewColumnHeader2.Type = Manina.Windows.Forms.ColumnType.FilePath;
            ımageListViewColumnHeader2.Width = 160;
            ımageListViewColumnHeader3.Comparer = null;
            ımageListViewColumnHeader3.DisplayIndex = 2;
            ımageListViewColumnHeader3.Key = "";
            ımageListViewColumnHeader3.Text = "Modified date";
            ımageListViewColumnHeader3.Type = Manina.Windows.Forms.ColumnType.DateModified;
            this.SearchResultList.Columns.AddRange(new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader[] {
            ımageListViewColumnHeader1,
            ımageListViewColumnHeader2,
            ımageListViewColumnHeader3});
            this.SearchResultList.GroupHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SearchResultList.Name = "SearchResultList";
            this.SearchResultList.PersistentCacheDirectory = "";
            this.SearchResultList.PersistentCacheSize = ((long)(100));
            this.SearchResultList.ShowCheckBoxes = true;
            this.SearchResultList.ShowFileIcons = true;
            this.SearchResultList.UseWIC = true;
            this.SearchResultList.View = Manina.Windows.Forms.View.Details;
            this.SearchResultList.ItemCheckBoxClick += new Manina.Windows.Forms.ItemCheckBoxClickEventHandler(this.SearchResultList_ItemCheckBoxClick);
            this.SearchResultList.ItemDoubleClick += new Manina.Windows.Forms.ItemDoubleClickEventHandler(this.SearchResultList_ItemDoubleClick);
            // 
            // WizardPage4
            // 
            resources.ApplyResources(this.WizardPage4, "WizardPage4");
            this.WizardPage4.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage4.Controls.Add(this.DeleteFileLabel);
            this.WizardPage4.Controls.Add(this.label4);
            this.WizardPage4.Controls.Add(this.DeleteProgress);
            this.WizardPage4.Name = "WizardPage4";
            // 
            // DeleteFileLabel
            // 
            resources.ApplyResources(this.DeleteFileLabel, "DeleteFileLabel");
            this.DeleteFileLabel.AutoEllipsis = true;
            this.DeleteFileLabel.Name = "DeleteFileLabel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // DeleteProgress
            // 
            resources.ApplyResources(this.DeleteProgress, "DeleteProgress");
            this.DeleteProgress.Name = "DeleteProgress";
            // 
            // WizardPage5
            // 
            resources.ApplyResources(this.WizardPage5, "WizardPage5");
            this.WizardPage5.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage5.Controls.Add(this.label5);
            this.WizardPage5.Controls.Add(this.DeleteResultLabel);
            this.WizardPage5.Name = "WizardPage5";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // DeleteResultLabel
            // 
            resources.ApplyResources(this.DeleteResultLabel, "DeleteResultLabel");
            this.DeleteResultLabel.Name = "DeleteResultLabel";
            // 
            // SearchFolderBrowserDialog
            // 
            resources.ApplyResources(this.SearchFolderBrowserDialog, "SearchFolderBrowserDialog");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WizardPage3);
            this.Controls.Add(this.WizardPage5);
            this.Controls.Add(this.WizardPage4);
            this.Controls.Add(this.WizardPage2);
            this.Controls.Add(this.WizardPage1);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.NextButton);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WizardPage1.ResumeLayout(false);
            this.WizardPage1.PerformLayout();
            this.WizardPage2.ResumeLayout(false);
            this.WizardPage2.PerformLayout();
            this.WizardPage3.ResumeLayout(false);
            this.WizardPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.WizardPage4.ResumeLayout(false);
            this.WizardPage4.PerformLayout();
            this.WizardPage5.ResumeLayout(false);
            this.WizardPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar SearchProgress;
        private Manina.Windows.Forms.ImageListView SearchResultList;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.Panel WizardPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel WizardPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel WizardPage3;
        private System.Windows.Forms.Label SearchResultLabel;
        private System.Windows.Forms.Panel WizardPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar DeleteProgress;
        private System.Windows.Forms.Panel WizardPage5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DeleteResultLabel;
        private System.Windows.Forms.CheckBox SearchLarsaFiles;
        private System.Windows.Forms.CheckBox SearchSafeFiles;
        private System.Windows.Forms.CheckBox SearchEtabsFiles;
        private System.Windows.Forms.CheckBox SearchSapFiles;
        private System.Windows.Forms.FolderBrowserDialog SearchFolderBrowserDialog;
        private System.Windows.Forms.Label SearchFileLabel;
        private System.Windows.Forms.Label DeleteFileLabel;
        private System.Windows.Forms.CheckBox UseRecycleBin;
        private Manina.Windows.Forms.FileSystemButton SearchFolder;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SelectAllFilesButton;
        private System.Windows.Forms.ToolStripButton ClearSelectedFilesButton;
        private System.Windows.Forms.ToolStripDropDownButton SelectFilesByDateButton;
        private System.Windows.Forms.ToolStripMenuItem SelectOlderThanOneWeekButton;
        private System.Windows.Forms.ToolStripMenuItem SelectOlderThanTwoWeeksButton;
        private System.Windows.Forms.ToolStripMenuItem SelectOlderThanOneMonthButton;
        private System.Windows.Forms.ToolStripMenuItem SelectOlderThanThreeMonthsButton;
        private System.Windows.Forms.ToolStripMenuItem SelectOlderThanSixMonthsButton;
        private System.Windows.Forms.ToolStripMenuItem SelectOlderThanOneYearButton;
    }
}

