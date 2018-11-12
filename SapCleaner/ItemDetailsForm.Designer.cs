namespace SapCleaner
{
    partial class ItemDetailsForm
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
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader1 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.Name, "Filename", 180, 0, true);
            Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader ımageListViewColumnHeader2 = new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader(Manina.Windows.Forms.ColumnType.FileSize, "Size", 100, 1, true);
            this.CloseButton = new System.Windows.Forms.Button();
            this.AssociatedFileList = new Manina.Windows.Forms.ImageListView();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(241, 439);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AssociatedFileList
            // 
            this.AssociatedFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssociatedFileList.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            ımageListViewColumnHeader1.Comparer = null;
            ımageListViewColumnHeader1.DisplayIndex = 0;
            ımageListViewColumnHeader1.Key = "";
            ımageListViewColumnHeader1.Text = "Filename";
            ımageListViewColumnHeader1.Type = Manina.Windows.Forms.ColumnType.Name;
            ımageListViewColumnHeader1.Width = 180;
            ımageListViewColumnHeader2.Comparer = null;
            ımageListViewColumnHeader2.DisplayIndex = 1;
            ımageListViewColumnHeader2.Key = "";
            ımageListViewColumnHeader2.Type = Manina.Windows.Forms.ColumnType.FileSize;
            this.AssociatedFileList.Columns.AddRange(new Manina.Windows.Forms.ImageListView.ImageListViewColumnHeader[] {
            ımageListViewColumnHeader1,
            ımageListViewColumnHeader2});
            this.AssociatedFileList.GroupHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.AssociatedFileList.Location = new System.Drawing.Point(12, 68);
            this.AssociatedFileList.Name = "AssociatedFileList";
            this.AssociatedFileList.PersistentCacheDirectory = "";
            this.AssociatedFileList.PersistentCacheSize = ((long)(100));
            this.AssociatedFileList.ShowFileIcons = true;
            this.AssociatedFileList.Size = new System.Drawing.Size(304, 357);
            this.AssociatedFileList.TabIndex = 3;
            this.AssociatedFileList.UseWIC = true;
            this.AssociatedFileList.View = Manina.Windows.Forms.View.Details;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsLabel.Location = new System.Drawing.Point(12, 9);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(304, 40);
            this.DetailsLabel.TabIndex = 1;
            this.DetailsLabel.Text = "label1";
            // 
            // ItemDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 474);
            this.Controls.Add(this.AssociatedFileList);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DetailsLabel);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "ItemDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemDetails";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private Manina.Windows.Forms.ImageListView AssociatedFileList;
        private System.Windows.Forms.Label DetailsLabel;
    }
}