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
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            this.SearchFolder = new Manina.Windows.Forms.FileSystemButton();
            this.SearchLarsaFiles = new System.Windows.Forms.CheckBox();
            this.SearchSafeFiles = new System.Windows.Forms.CheckBox();
            this.SearchEtabsFiles = new System.Windows.Forms.CheckBox();
            this.SearchSapFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.DeleteFileLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteProgress = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteResultLabel = new System.Windows.Forms.Label();
            this.SearchFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.wizardControl1 = new Manina.Windows.Forms.WizardControl();
            this.WizardPage1 = new Manina.Windows.Forms.Page();
            this.WizardPage2 = new Manina.Windows.Forms.Page();
            this.WizardPage3 = new Manina.Windows.Forms.Page();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.WizardPage4 = new Manina.Windows.Forms.Page();
            this.WizardPage5 = new Manina.Windows.Forms.Page();
            this.toolStrip1.SuspendLayout();
            this.wizardControl1.SuspendLayout();
            this.WizardPage1.SuspendLayout();
            this.WizardPage2.SuspendLayout();
            this.WizardPage3.SuspendLayout();
            this.WizardPage4.SuspendLayout();
            this.WizardPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchProgress
            // 
            resources.ApplyResources(this.SearchProgress, "SearchProgress");
            this.SearchProgress.Name = "SearchProgress";
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
            // 
            // SearchSafeFiles
            // 
            resources.ApplyResources(this.SearchSafeFiles, "SearchSafeFiles");
            this.SearchSafeFiles.Checked = true;
            this.SearchSafeFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchSafeFiles.Name = "SearchSafeFiles";
            this.SearchSafeFiles.UseVisualStyleBackColor = true;
            // 
            // SearchEtabsFiles
            // 
            resources.ApplyResources(this.SearchEtabsFiles, "SearchEtabsFiles");
            this.SearchEtabsFiles.Checked = true;
            this.SearchEtabsFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchEtabsFiles.Name = "SearchEtabsFiles";
            this.SearchEtabsFiles.UseVisualStyleBackColor = true;
            // 
            // SearchSapFiles
            // 
            resources.ApplyResources(this.SearchSapFiles, "SearchSapFiles");
            this.SearchSapFiles.Checked = true;
            this.SearchSapFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchSapFiles.Name = "SearchSapFiles";
            this.SearchSapFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // wizardControl1
            // 
            resources.ApplyResources(this.wizardControl1, "wizardControl1");
            this.wizardControl1.Controls.Add(this.WizardPage1);
            this.wizardControl1.Controls.Add(this.WizardPage2);
            this.wizardControl1.Controls.Add(this.WizardPage3);
            this.wizardControl1.Controls.Add(this.WizardPage4);
            this.wizardControl1.Controls.Add(this.WizardPage5);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.PageChanging += new Manina.Windows.Forms.PagedControl.PageChangingEventHandler(this.wizardControl1_PageChanging);
            this.wizardControl1.PageShown += new Manina.Windows.Forms.PagedControl.PageEventHandler(this.wizardControl1_PageShown);
            // 
            // WizardPage1
            // 
            resources.ApplyResources(this.WizardPage1, "WizardPage1");
            this.WizardPage1.Controls.Add(this.SearchFolder);
            this.WizardPage1.Controls.Add(this.label1);
            this.WizardPage1.Controls.Add(this.SearchLarsaFiles);
            this.WizardPage1.Controls.Add(this.SearchSapFiles);
            this.WizardPage1.Controls.Add(this.SearchSafeFiles);
            this.WizardPage1.Controls.Add(this.SearchEtabsFiles);
            this.WizardPage1.Name = "WizardPage1";
            // 
            // WizardPage2
            // 
            resources.ApplyResources(this.WizardPage2, "WizardPage2");
            this.WizardPage2.Controls.Add(this.SearchFileLabel);
            this.WizardPage2.Controls.Add(this.label2);
            this.WizardPage2.Controls.Add(this.SearchProgress);
            this.WizardPage2.Name = "WizardPage2";
            // 
            // WizardPage3
            // 
            resources.ApplyResources(this.WizardPage3, "WizardPage3");
            this.WizardPage3.Controls.Add(this.SelectionLabel);
            this.WizardPage3.Controls.Add(this.toolStrip1);
            this.WizardPage3.Controls.Add(this.SearchResultLabel);
            this.WizardPage3.Controls.Add(this.UseRecycleBin);
            this.WizardPage3.Controls.Add(this.SearchResultList);
            this.WizardPage3.Name = "WizardPage3";
            // 
            // SelectionLabel
            // 
            resources.ApplyResources(this.SelectionLabel, "SelectionLabel");
            this.SelectionLabel.Name = "SelectionLabel";
            // 
            // WizardPage4
            // 
            resources.ApplyResources(this.WizardPage4, "WizardPage4");
            this.WizardPage4.Controls.Add(this.DeleteFileLabel);
            this.WizardPage4.Controls.Add(this.label4);
            this.WizardPage4.Controls.Add(this.DeleteProgress);
            this.WizardPage4.Name = "WizardPage4";
            // 
            // WizardPage5
            // 
            resources.ApplyResources(this.WizardPage5, "WizardPage5");
            this.WizardPage5.Controls.Add(this.label5);
            this.WizardPage5.Controls.Add(this.DeleteResultLabel);
            this.WizardPage5.Name = "WizardPage5";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wizardControl1);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.wizardControl1.ResumeLayout(false);
            this.WizardPage1.ResumeLayout(false);
            this.WizardPage1.PerformLayout();
            this.WizardPage2.ResumeLayout(false);
            this.WizardPage2.PerformLayout();
            this.WizardPage3.ResumeLayout(false);
            this.WizardPage3.PerformLayout();
            this.WizardPage4.ResumeLayout(false);
            this.WizardPage4.PerformLayout();
            this.WizardPage5.ResumeLayout(false);
            this.WizardPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Manina.Windows.Forms.ImageListView SearchResultList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SearchResultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar DeleteProgress;
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
        private Manina.Windows.Forms.WizardControl wizardControl1;
        private Manina.Windows.Forms.Page WizardPage1;
        private Manina.Windows.Forms.Page WizardPage2;
        private Manina.Windows.Forms.Page WizardPage3;
        private Manina.Windows.Forms.Page WizardPage4;
        private Manina.Windows.Forms.Page WizardPage5;
        private System.Windows.Forms.ProgressBar SearchProgress;
        private System.Windows.Forms.Label SelectionLabel;
    }
}

