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
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            this.SearchResultList = new System.Windows.Forms.ListView();
            this.FilenameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CleanButton = new System.Windows.Forms.Button();
            this.SizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.SearchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchProgress.Location = new System.Drawing.Point(12, 357);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(429, 15);
            this.SearchProgress.TabIndex = 2;
            this.SearchProgress.Visible = false;
            // 
            // SearchResultList
            // 
            this.SearchResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilenameColumn,
            this.PathColumn,
            this.SizeColumn});
            this.SearchResultList.Location = new System.Drawing.Point(461, 12);
            this.SearchResultList.Name = "SearchResultList";
            this.SearchResultList.Size = new System.Drawing.Size(467, 360);
            this.SearchResultList.TabIndex = 3;
            this.SearchResultList.UseCompatibleStateImageBehavior = false;
            this.SearchResultList.View = System.Windows.Forms.View.Details;
            this.SearchResultList.DoubleClick += new System.EventHandler(this.SearchResultList_DoubleClick);
            // 
            // FilenameColumn
            // 
            this.FilenameColumn.Text = "Ad";
            this.FilenameColumn.Width = 140;
            // 
            // PathColumn
            // 
            this.PathColumn.Text = "Klasör";
            this.PathColumn.Width = 210;
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
            // SizeColumn
            // 
            this.SizeColumn.Text = "Boyut";
            this.SizeColumn.Width = 80;
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
        private System.Windows.Forms.ListView SearchResultList;
        private System.Windows.Forms.ColumnHeader FilenameColumn;
        private System.Windows.Forms.ColumnHeader PathColumn;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.ColumnHeader SizeColumn;
    }
}

