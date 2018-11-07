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
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader1 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Name, "Ad", 70, 0, true);
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader2 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.FilePath, "Klasör", 160, 1, true);
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader3 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Custom, "assoc_files", "Boyut", 60, 2, true);
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            this.NextButton = new System.Windows.Forms.Button();
            this.Separator = new System.Windows.Forms.Label();
            this.WizardPage1 = new System.Windows.Forms.Panel();
            this.SearchLarsaFiles = new System.Windows.Forms.CheckBox();
            this.SearchSafeFiles = new System.Windows.Forms.CheckBox();
            this.SearchEtabsFiles = new System.Windows.Forms.CheckBox();
            this.SearchSapFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WizardPage2 = new System.Windows.Forms.Panel();
            this.SearchFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WizardPage3 = new System.Windows.Forms.Panel();
            this.UseRecycleBin = new System.Windows.Forms.CheckBox();
            this.DeleteAnalysisFiles = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.SearchFolder = new SapCleaner.FileSystemLabel();
            this.WizardPage1.SuspendLayout();
            this.WizardPage2.SuspendLayout();
            this.WizardPage3.SuspendLayout();
            this.WizardPage4.SuspendLayout();
            this.WizardPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchProgress
            // 
            this.SearchProgress.Location = new System.Drawing.Point(18, 46);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(316, 24);
            this.SearchProgress.TabIndex = 1;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(1806, 401);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "İleri >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Separator
            // 
            this.Separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator.Location = new System.Drawing.Point(2, 385);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(1890, 2);
            this.Separator.TabIndex = 5;
            // 
            // WizardPage1
            // 
            this.WizardPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WizardPage1.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage1.Controls.Add(this.SearchLarsaFiles);
            this.WizardPage1.Controls.Add(this.SearchSafeFiles);
            this.WizardPage1.Controls.Add(this.SearchEtabsFiles);
            this.WizardPage1.Controls.Add(this.SearchSapFiles);
            this.WizardPage1.Controls.Add(this.SearchFolder);
            this.WizardPage1.Controls.Add(this.label1);
            this.WizardPage1.Location = new System.Drawing.Point(12, 13);
            this.WizardPage1.Name = "WizardPage1";
            this.WizardPage1.Size = new System.Drawing.Size(353, 352);
            this.WizardPage1.TabIndex = 0;
            // 
            // SearchLarsaFiles
            // 
            this.SearchLarsaFiles.AutoSize = true;
            this.SearchLarsaFiles.Checked = true;
            this.SearchLarsaFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchLarsaFiles.Location = new System.Drawing.Point(18, 269);
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
            this.SearchSafeFiles.Location = new System.Drawing.Point(18, 246);
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
            this.SearchEtabsFiles.Location = new System.Drawing.Point(18, 223);
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
            this.SearchSapFiles.Location = new System.Drawing.Point(18, 200);
            this.SearchSapFiles.Name = "SearchSapFiles";
            this.SearchSapFiles.Size = new System.Drawing.Size(146, 17);
            this.SearchSapFiles.TabIndex = 2;
            this.SearchSapFiles.Text = "Sap2000 Analiz Dosyaları";
            this.SearchSapFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // WizardPage2
            // 
            this.WizardPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WizardPage2.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage2.Controls.Add(this.SearchFileLabel);
            this.WizardPage2.Controls.Add(this.label2);
            this.WizardPage2.Controls.Add(this.SearchProgress);
            this.WizardPage2.Location = new System.Drawing.Point(393, 13);
            this.WizardPage2.Name = "WizardPage2";
            this.WizardPage2.Size = new System.Drawing.Size(353, 352);
            this.WizardPage2.TabIndex = 1;
            // 
            // SearchFileLabel
            // 
            this.SearchFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFileLabel.AutoEllipsis = true;
            this.SearchFileLabel.Location = new System.Drawing.Point(15, 93);
            this.SearchFileLabel.Name = "SearchFileLabel";
            this.SearchFileLabel.Size = new System.Drawing.Size(319, 46);
            this.SearchFileLabel.TabIndex = 2;
            this.SearchFileLabel.Text = "#SEARCHFILE#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Analiz dosyaları aranıyor...";
            // 
            // WizardPage3
            // 
            this.WizardPage3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WizardPage3.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage3.Controls.Add(this.UseRecycleBin);
            this.WizardPage3.Controls.Add(this.DeleteAnalysisFiles);
            this.WizardPage3.Controls.Add(this.label3);
            this.WizardPage3.Controls.Add(this.SearchResultLabel);
            this.WizardPage3.Controls.Add(this.SearchResultList);
            this.WizardPage3.Location = new System.Drawing.Point(779, 13);
            this.WizardPage3.Name = "WizardPage3";
            this.WizardPage3.Size = new System.Drawing.Size(353, 352);
            this.WizardPage3.TabIndex = 2;
            // 
            // UseRecycleBin
            // 
            this.UseRecycleBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UseRecycleBin.AutoSize = true;
            this.UseRecycleBin.Checked = true;
            this.UseRecycleBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseRecycleBin.Location = new System.Drawing.Point(18, 313);
            this.UseRecycleBin.Name = "UseRecycleBin";
            this.UseRecycleBin.Size = new System.Drawing.Size(166, 17);
            this.UseRecycleBin.TabIndex = 4;
            this.UseRecycleBin.Text = "Geri dönüşüm kutusuna kaldır";
            this.UseRecycleBin.UseVisualStyleBackColor = true;
            // 
            // DeleteAnalysisFiles
            // 
            this.DeleteAnalysisFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteAnalysisFiles.AutoSize = true;
            this.DeleteAnalysisFiles.Location = new System.Drawing.Point(18, 290);
            this.DeleteAnalysisFiles.Name = "DeleteAnalysisFiles";
            this.DeleteAnalysisFiles.Size = new System.Drawing.Size(118, 17);
            this.DeleteAnalysisFiles.TabIndex = 3;
            this.DeleteAnalysisFiles.Text = "Analiz dosyalarını sil";
            this.DeleteAnalysisFiles.UseVisualStyleBackColor = true;
            this.DeleteAnalysisFiles.CheckedChanged += new System.EventHandler(this.DeleteAnalysisFiles_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(15, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aşağıdaki seçeneği işaretleyip ileri düğmesine tıklayarak tüm analiz dosyalarını " +
    "silebilirsiniz.";
            // 
            // SearchResultLabel
            // 
            this.SearchResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultLabel.Location = new System.Drawing.Point(15, 15);
            this.SearchResultLabel.Name = "SearchResultLabel";
            this.SearchResultLabel.Size = new System.Drawing.Size(320, 43);
            this.SearchResultLabel.TabIndex = 0;
            this.SearchResultLabel.Text = "#SEARCHRESULT#";
            // 
            // SearchResultList
            // 
            this.SearchResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultList.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            ımageListViewColumnHeader1.DisplayIndex = 0;
            ımageListViewColumnHeader1.Key = "";
            ımageListViewColumnHeader1.Text = "Ad";
            ımageListViewColumnHeader1.Type = Manina.Windows.Forms.ColumnType.Name;
            ımageListViewColumnHeader1.Width = 70;
            ımageListViewColumnHeader2.DisplayIndex = 1;
            ımageListViewColumnHeader2.Key = "";
            ımageListViewColumnHeader2.Text = "Klasör";
            ımageListViewColumnHeader2.Type = Manina.Windows.Forms.ColumnType.FilePath;
            ımageListViewColumnHeader2.Width = 160;
            ımageListViewColumnHeader3.DisplayIndex = 2;
            ımageListViewColumnHeader3.Key = "assoc_files";
            ımageListViewColumnHeader3.Text = "Boyut";
            ımageListViewColumnHeader3.Type = Manina.Windows.Forms.ColumnType.Custom;
            ımageListViewColumnHeader3.Width = 60;
            this.SearchResultList.Columns.AddRange(new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader[] {
            ımageListViewColumnHeader1,
            ımageListViewColumnHeader2,
            ımageListViewColumnHeader3});
            this.SearchResultList.GroupHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SearchResultList.Location = new System.Drawing.Point(18, 73);
            this.SearchResultList.Name = "SearchResultList";
            this.SearchResultList.PersistentCacheDirectory = "";
            this.SearchResultList.PersistentCacheSize = ((long)(100));
            this.SearchResultList.ShowCheckBoxes = true;
            this.SearchResultList.ShowFileIcons = true;
            this.SearchResultList.Size = new System.Drawing.Size(317, 165);
            this.SearchResultList.TabIndex = 1;
            this.SearchResultList.UseWIC = true;
            this.SearchResultList.View = Manina.Windows.Forms.View.Details;
            this.SearchResultList.ItemDoubleClick += new Manina.Windows.Forms.ItemDoubleClickEventHandler(this.SearchResultList_ItemDoubleClick);
            // 
            // WizardPage4
            // 
            this.WizardPage4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WizardPage4.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage4.Controls.Add(this.DeleteFileLabel);
            this.WizardPage4.Controls.Add(this.label4);
            this.WizardPage4.Controls.Add(this.DeleteProgress);
            this.WizardPage4.Location = new System.Drawing.Point(1150, 13);
            this.WizardPage4.Name = "WizardPage4";
            this.WizardPage4.Size = new System.Drawing.Size(353, 352);
            this.WizardPage4.TabIndex = 3;
            // 
            // DeleteFileLabel
            // 
            this.DeleteFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFileLabel.AutoEllipsis = true;
            this.DeleteFileLabel.Location = new System.Drawing.Point(18, 93);
            this.DeleteFileLabel.Name = "DeleteFileLabel";
            this.DeleteFileLabel.Size = new System.Drawing.Size(316, 80);
            this.DeleteFileLabel.TabIndex = 2;
            this.DeleteFileLabel.Text = "#DELETEFILE#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Analiz dosyaları siliniyor...";
            // 
            // DeleteProgress
            // 
            this.DeleteProgress.Location = new System.Drawing.Point(18, 46);
            this.DeleteProgress.Name = "DeleteProgress";
            this.DeleteProgress.Size = new System.Drawing.Size(316, 24);
            this.DeleteProgress.TabIndex = 1;
            // 
            // WizardPage5
            // 
            this.WizardPage5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WizardPage5.BackColor = System.Drawing.SystemColors.Window;
            this.WizardPage5.Controls.Add(this.label5);
            this.WizardPage5.Controls.Add(this.DeleteResultLabel);
            this.WizardPage5.Location = new System.Drawing.Point(1524, 13);
            this.WizardPage5.Name = "WizardPage5";
            this.WizardPage5.Size = new System.Drawing.Size(353, 352);
            this.WizardPage5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Analiz dosyaları silindi.";
            // 
            // DeleteResultLabel
            // 
            this.DeleteResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteResultLabel.Location = new System.Drawing.Point(15, 46);
            this.DeleteResultLabel.Name = "DeleteResultLabel";
            this.DeleteResultLabel.Size = new System.Drawing.Size(317, 108);
            this.DeleteResultLabel.TabIndex = 1;
            this.DeleteResultLabel.Text = "#DELETERESULT#";
            // 
            // SearchFolder
            // 
            this.SearchFolder.Location = new System.Drawing.Point(18, 93);
            this.SearchFolder.Name = "SearchFolder";
            this.SearchFolder.Path = "C:\\";
            this.SearchFolder.Size = new System.Drawing.Size(316, 80);
            this.SearchFolder.TabIndex = 1;
            this.SearchFolder.Text = "SearchFolder";
            this.SearchFolder.Click += new System.EventHandler(this.SearchFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1893, 436);
            this.Controls.Add(this.WizardPage3);
            this.Controls.Add(this.WizardPage5);
            this.Controls.Add(this.WizardPage4);
            this.Controls.Add(this.WizardPage2);
            this.Controls.Add(this.WizardPage1);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.NextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(390, 475);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Analiz Dosyası Temizleyici";
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
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.Panel WizardPage1;
        private System.Windows.Forms.Label label1;
        private FileSystemLabel SearchFolder;
        private System.Windows.Forms.Panel WizardPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel WizardPage3;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.CheckBox DeleteAnalysisFiles;
    }
}

