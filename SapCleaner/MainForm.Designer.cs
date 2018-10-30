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
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader1 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Name, "Ad", 140, 0, true);
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader2 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.FilePath, "Klasör", 240, 1, true);
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader3 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Custom, "assoc_files", "Boyut", 60, 2, true);
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            this.CleanButton = new System.Windows.Forms.Button();
            this.SearchResultList = new Manina.Windows.Forms.ImageListView();
            this.DriveList = new SapCleaner.DriveListView();
            this.SuspendLayout();
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Location = new System.Drawing.Point(341, 12);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(100, 57);
            this.AnalyzeButton.TabIndex = 1;
            this.AnalyzeButton.Text = "Temizlenecek Dosyaları Bul";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // SearchProgress
            // 
            this.SearchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchProgress.Location = new System.Drawing.Point(12, 357);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(429, 15);
            this.SearchProgress.TabIndex = 2;
            this.SearchProgress.Visible = false;
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(341, 75);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(100, 57);
            this.CleanButton.TabIndex = 1;
            this.CleanButton.Text = "Dosyaları Temizle";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
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
            ımageListViewColumnHeader1.Width = 140;
            ımageListViewColumnHeader2.DisplayIndex = 1;
            ımageListViewColumnHeader2.Key = "";
            ımageListViewColumnHeader2.Text = "Klasör";
            ımageListViewColumnHeader2.Type = Manina.Windows.Forms.ColumnType.FilePath;
            ımageListViewColumnHeader2.Width = 240;
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
            this.SearchResultList.Location = new System.Drawing.Point(466, 13);
            this.SearchResultList.Name = "SearchResultList";
            this.SearchResultList.PersistentCacheDirectory = "";
            this.SearchResultList.PersistentCacheSize = ((long)(100));
            this.SearchResultList.ShowCheckBoxes = true;
            this.SearchResultList.ShowFileIcons = true;
            this.SearchResultList.Size = new System.Drawing.Size(462, 359);
            this.SearchResultList.TabIndex = 3;
            this.SearchResultList.UseWIC = true;
            this.SearchResultList.View = Manina.Windows.Forms.View.Details;
            this.SearchResultList.ItemDoubleClick += new Manina.Windows.Forms.ItemDoubleClickEventHandler(this.SearchResultList_ItemDoubleClick);
            // 
            // DriveList
            // 
            this.DriveList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DriveList.Location = new System.Drawing.Point(12, 12);
            this.DriveList.Name = "DriveList";
            this.DriveList.Size = new System.Drawing.Size(312, 331);
            this.DriveList.TabIndex = 0;
            this.DriveList.Text = "driveListView1";
            this.DriveList.TileWidth = 280;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 384);
            this.Controls.Add(this.SearchResultList);
            this.Controls.Add(this.SearchProgress);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.DriveList);
            this.Name = "MainForm";
            this.Text = "SAP2000 Cleaner";
            this.ResumeLayout(false);

        }

        #endregion

        private DriveListView DriveList;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.ProgressBar SearchProgress;
        private System.Windows.Forms.Button CleanButton;
        private Manina.Windows.Forms.ImageListView SearchResultList;
    }
}

