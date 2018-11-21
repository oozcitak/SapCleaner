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
            this.WizardPage1 = new Manina.Windows.Forms.WizardPage();
            this.WizardPage2 = new Manina.Windows.Forms.WizardPage();
            this.WizardPage3 = new Manina.Windows.Forms.WizardPage();
            this.WizardPage4 = new Manina.Windows.Forms.WizardPage();
            this.WizardPage5 = new Manina.Windows.Forms.WizardPage();
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
            this.SearchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgress.Location = new System.Drawing.Point(12, 46);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(418, 24);
            this.SearchProgress.TabIndex = 1;
            // 
            // SearchFolder
            // 
            this.SearchFolder.Location = new System.Drawing.Point(12, 93);
            this.SearchFolder.Name = "SearchFolder";
            this.SearchFolder.Path = "C:\\";
            this.SearchFolder.Size = new System.Drawing.Size(315, 80);
            this.SearchFolder.TabIndex = 1;
            this.SearchFolder.Click += new System.EventHandler(this.SearchFolder_Click);
            // 
            // SearchLarsaFiles
            // 
            this.SearchLarsaFiles.AutoSize = true;
            this.SearchLarsaFiles.Checked = true;
            this.SearchLarsaFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchLarsaFiles.Location = new System.Drawing.Point(12, 268);
            this.SearchLarsaFiles.Name = "SearchLarsaFiles";
            this.SearchLarsaFiles.Size = new System.Drawing.Size(143, 17);
            this.SearchLarsaFiles.TabIndex = 5;
            this.SearchLarsaFiles.Text = "Larsa4D Analiz Dosyaları";
            this.SearchLarsaFiles.UseVisualStyleBackColor = true;
            // 
            // SearchSafeFiles
            // 
            this.SearchSafeFiles.AutoSize = true;
            this.SearchSafeFiles.Checked = true;
            this.SearchSafeFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchSafeFiles.Location = new System.Drawing.Point(12, 245);
            this.SearchSafeFiles.Name = "SearchSafeFiles";
            this.SearchSafeFiles.Size = new System.Drawing.Size(130, 17);
            this.SearchSafeFiles.TabIndex = 4;
            this.SearchSafeFiles.Text = "SAFE Analiz Dosyaları";
            this.SearchSafeFiles.UseVisualStyleBackColor = true;
            // 
            // SearchEtabsFiles
            // 
            this.SearchEtabsFiles.AutoSize = true;
            this.SearchEtabsFiles.Checked = true;
            this.SearchEtabsFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchEtabsFiles.Location = new System.Drawing.Point(12, 222);
            this.SearchEtabsFiles.Name = "SearchEtabsFiles";
            this.SearchEtabsFiles.Size = new System.Drawing.Size(138, 17);
            this.SearchEtabsFiles.TabIndex = 3;
            this.SearchEtabsFiles.Text = "ETABS Analiz Dosyaları";
            this.SearchEtabsFiles.UseVisualStyleBackColor = true;
            // 
            // SearchSapFiles
            // 
            this.SearchSapFiles.AutoSize = true;
            this.SearchSapFiles.Checked = true;
            this.SearchSapFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchSapFiles.Location = new System.Drawing.Point(12, 199);
            this.SearchSapFiles.Name = "SearchSapFiles";
            this.SearchSapFiles.Size = new System.Drawing.Size(146, 17);
            this.SearchSapFiles.TabIndex = 2;
            this.SearchSapFiles.Text = "Sap2000 Analiz Dosyaları";
            this.SearchSapFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // SearchFileLabel
            // 
            this.SearchFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFileLabel.AutoEllipsis = true;
            this.SearchFileLabel.Location = new System.Drawing.Point(12, 93);
            this.SearchFileLabel.Name = "SearchFileLabel";
            this.SearchFileLabel.Size = new System.Drawing.Size(418, 46);
            this.SearchFileLabel.TabIndex = 2;
            this.SearchFileLabel.Text = "#SEARCHFILE#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Analiz dosyaları aranıyor...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllFilesButton,
            this.ClearSelectedFilesButton,
            this.SelectFilesByDateButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 74);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(319, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SelectAllFilesButton
            // 
            this.SelectAllFilesButton.Image = global::SapCleaner.Properties.Resources.lightbulb;
            this.SelectAllFilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAllFilesButton.Name = "SelectAllFilesButton";
            this.SelectAllFilesButton.Size = new System.Drawing.Size(94, 22);
            this.SelectAllFilesButton.Text = "Tümünü Seç";
            this.SelectAllFilesButton.Click += new System.EventHandler(this.SelectAllFilesButton_Click);
            // 
            // ClearSelectedFilesButton
            // 
            this.ClearSelectedFilesButton.Image = global::SapCleaner.Properties.Resources.lightbulb_off;
            this.ClearSelectedFilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearSelectedFilesButton.Name = "ClearSelectedFilesButton";
            this.ClearSelectedFilesButton.Size = new System.Drawing.Size(105, 22);
            this.ClearSelectedFilesButton.Text = "Seçimi Temizle";
            this.ClearSelectedFilesButton.Click += new System.EventHandler(this.ClearSelectedFilesButton_Click);
            // 
            // SelectFilesByDateButton
            // 
            this.SelectFilesByDateButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectOlderThanOneWeekButton,
            this.SelectOlderThanTwoWeeksButton,
            this.SelectOlderThanOneMonthButton,
            this.SelectOlderThanThreeMonthsButton,
            this.SelectOlderThanSixMonthsButton,
            this.SelectOlderThanOneYearButton});
            this.SelectFilesByDateButton.Image = global::SapCleaner.Properties.Resources.calendar;
            this.SelectFilesByDateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectFilesByDateButton.Name = "SelectFilesByDateButton";
            this.SelectFilesByDateButton.Size = new System.Drawing.Size(117, 22);
            this.SelectFilesByDateButton.Text = "Tarihe Göre Seç";
            // 
            // SelectOlderThanOneWeekButton
            // 
            this.SelectOlderThanOneWeekButton.Name = "SelectOlderThanOneWeekButton";
            this.SelectOlderThanOneWeekButton.Size = new System.Drawing.Size(180, 22);
            this.SelectOlderThanOneWeekButton.Text = "Bir Haftadan Eski";
            this.SelectOlderThanOneWeekButton.Click += new System.EventHandler(this.SelectOlderThanOneWeekButton_Click);
            // 
            // SelectOlderThanTwoWeeksButton
            // 
            this.SelectOlderThanTwoWeeksButton.Name = "SelectOlderThanTwoWeeksButton";
            this.SelectOlderThanTwoWeeksButton.Size = new System.Drawing.Size(180, 22);
            this.SelectOlderThanTwoWeeksButton.Text = "İki Haftadan Eski";
            this.SelectOlderThanTwoWeeksButton.Click += new System.EventHandler(this.SelectOlderThanTwoWeeksButton_Click);
            // 
            // SelectOlderThanOneMonthButton
            // 
            this.SelectOlderThanOneMonthButton.Name = "SelectOlderThanOneMonthButton";
            this.SelectOlderThanOneMonthButton.Size = new System.Drawing.Size(180, 22);
            this.SelectOlderThanOneMonthButton.Text = "Bir Aydan Eski";
            this.SelectOlderThanOneMonthButton.Click += new System.EventHandler(this.SelectOlderThanOneMonthButton_Click);
            // 
            // SelectOlderThanThreeMonthsButton
            // 
            this.SelectOlderThanThreeMonthsButton.Name = "SelectOlderThanThreeMonthsButton";
            this.SelectOlderThanThreeMonthsButton.Size = new System.Drawing.Size(180, 22);
            this.SelectOlderThanThreeMonthsButton.Text = "Üç Aydan Eski";
            this.SelectOlderThanThreeMonthsButton.Click += new System.EventHandler(this.SelectOlderThanThreeMonthsButton_Click);
            // 
            // SelectOlderThanSixMonthsButton
            // 
            this.SelectOlderThanSixMonthsButton.Name = "SelectOlderThanSixMonthsButton";
            this.SelectOlderThanSixMonthsButton.Size = new System.Drawing.Size(180, 22);
            this.SelectOlderThanSixMonthsButton.Text = "Altı Aydan Eski";
            this.SelectOlderThanSixMonthsButton.Click += new System.EventHandler(this.SelectOlderThanSixMonthsButton_Click);
            // 
            // SelectOlderThanOneYearButton
            // 
            this.SelectOlderThanOneYearButton.Name = "SelectOlderThanOneYearButton";
            this.SelectOlderThanOneYearButton.Size = new System.Drawing.Size(180, 22);
            this.SelectOlderThanOneYearButton.Text = "Bir Yıldan Eski";
            this.SelectOlderThanOneYearButton.Click += new System.EventHandler(this.SelectOlderThanOneYearButton_Click);
            // 
            // UseRecycleBin
            // 
            this.UseRecycleBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UseRecycleBin.AutoSize = true;
            this.UseRecycleBin.Checked = true;
            this.UseRecycleBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseRecycleBin.Location = new System.Drawing.Point(12, 338);
            this.UseRecycleBin.Name = "UseRecycleBin";
            this.UseRecycleBin.Size = new System.Drawing.Size(166, 17);
            this.UseRecycleBin.TabIndex = 3;
            this.UseRecycleBin.Text = "Geri dönüşüm kutusuna kaldır";
            this.UseRecycleBin.UseVisualStyleBackColor = true;
            // 
            // SearchResultLabel
            // 
            this.SearchResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultLabel.Location = new System.Drawing.Point(12, 15);
            this.SearchResultLabel.Name = "SearchResultLabel";
            this.SearchResultLabel.Size = new System.Drawing.Size(418, 52);
            this.SearchResultLabel.TabIndex = 0;
            this.SearchResultLabel.Text = "#SEARCHRESULT#";
            // 
            // SearchResultList
            // 
            this.SearchResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultList.Location = new System.Drawing.Point(12, 109);
            this.SearchResultList.Name = "SearchResultList";
            this.SearchResultList.PersistentCacheDirectory = "";
            this.SearchResultList.PersistentCacheSize = ((long)(100));
            this.SearchResultList.ShowCheckBoxes = true;
            this.SearchResultList.ShowFileIcons = true;
            this.SearchResultList.Size = new System.Drawing.Size(418, 212);
            this.SearchResultList.TabIndex = 2;
            this.SearchResultList.UseWIC = true;
            this.SearchResultList.View = Manina.Windows.Forms.View.Details;
            this.SearchResultList.ItemDoubleClick += new Manina.Windows.Forms.ItemDoubleClickEventHandler(this.SearchResultList_ItemDoubleClick);
            // 
            // DeleteFileLabel
            // 
            this.DeleteFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFileLabel.AutoEllipsis = true;
            this.DeleteFileLabel.Location = new System.Drawing.Point(12, 93);
            this.DeleteFileLabel.Name = "DeleteFileLabel";
            this.DeleteFileLabel.Size = new System.Drawing.Size(418, 80);
            this.DeleteFileLabel.TabIndex = 2;
            this.DeleteFileLabel.Text = "#DELETEFILE#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Analiz dosyaları siliniyor...";
            // 
            // DeleteProgress
            // 
            this.DeleteProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProgress.Location = new System.Drawing.Point(12, 46);
            this.DeleteProgress.Name = "DeleteProgress";
            this.DeleteProgress.Size = new System.Drawing.Size(418, 24);
            this.DeleteProgress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Analiz dosyaları silindi.";
            // 
            // DeleteResultLabel
            // 
            this.DeleteResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteResultLabel.Location = new System.Drawing.Point(12, 46);
            this.DeleteResultLabel.Name = "DeleteResultLabel";
            this.DeleteResultLabel.Size = new System.Drawing.Size(418, 108);
            this.DeleteResultLabel.TabIndex = 1;
            this.DeleteResultLabel.Text = "#DELETERESULT#";
            // 
            // wizardControl1
            // 
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.WizardPage1);
            this.wizardControl1.Pages.Add(this.WizardPage2);
            this.wizardControl1.Pages.Add(this.WizardPage3);
            this.wizardControl1.Pages.Add(this.WizardPage4);
            this.wizardControl1.Pages.Add(this.WizardPage5);
            this.wizardControl1.Size = new System.Drawing.Size(442, 419);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.PageChanging += new Manina.Windows.Forms.WizardControl.PageChangingEventHandler(this.wizardControl1_PageChanging);
            this.wizardControl1.PageShown += new Manina.Windows.Forms.WizardControl.PageEventHandler(this.wizardControl1_PageShown);
            // 
            // WizardPage1
            // 
            this.WizardPage1.Controls.Add(this.SearchFolder);
            this.WizardPage1.Controls.Add(this.label1);
            this.WizardPage1.Controls.Add(this.SearchLarsaFiles);
            this.WizardPage1.Controls.Add(this.SearchSapFiles);
            this.WizardPage1.Controls.Add(this.SearchSafeFiles);
            this.WizardPage1.Controls.Add(this.SearchEtabsFiles);
            this.WizardPage1.Name = "WizardPage1";
            this.WizardPage1.Size = new System.Drawing.Size(442, 370);
            // 
            // WizardPage2
            // 
            this.WizardPage2.Controls.Add(this.SearchFileLabel);
            this.WizardPage2.Controls.Add(this.label2);
            this.WizardPage2.Controls.Add(this.SearchProgress);
            this.WizardPage2.Name = "WizardPage2";
            this.WizardPage2.Size = new System.Drawing.Size(442, 370);
            // 
            // WizardPage3
            // 
            this.WizardPage3.Controls.Add(this.toolStrip1);
            this.WizardPage3.Controls.Add(this.SearchResultLabel);
            this.WizardPage3.Controls.Add(this.UseRecycleBin);
            this.WizardPage3.Controls.Add(this.SearchResultList);
            this.WizardPage3.Name = "WizardPage3";
            this.WizardPage3.Size = new System.Drawing.Size(442, 370);
            // 
            // WizardPage4
            // 
            this.WizardPage4.Controls.Add(this.DeleteFileLabel);
            this.WizardPage4.Controls.Add(this.label4);
            this.WizardPage4.Controls.Add(this.DeleteProgress);
            this.WizardPage4.Name = "WizardPage4";
            this.WizardPage4.Size = new System.Drawing.Size(442, 370);
            // 
            // WizardPage5
            // 
            this.WizardPage5.Controls.Add(this.label5);
            this.WizardPage5.Controls.Add(this.DeleteResultLabel);
            this.WizardPage5.Name = "WizardPage5";
            this.WizardPage5.Size = new System.Drawing.Size(442, 370);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 419);
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
        private System.Windows.Forms.ProgressBar SearchProgress;
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
        private Manina.Windows.Forms.WizardPage WizardPage1;
        private Manina.Windows.Forms.WizardPage WizardPage2;
        private Manina.Windows.Forms.WizardPage WizardPage3;
        private Manina.Windows.Forms.WizardPage WizardPage4;
        private Manina.Windows.Forms.WizardPage WizardPage5;
    }
}

