using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Manina.Windows.Forms;

namespace SapCleaner
{
    public partial class MainForm : Form
    {
        private Panel[] Pages { get; set; }
        private int CurrentPage { get; set; }

        private long totalFiles = 0;
        private long totalSize = 0;

        public MainForm()
        {
            InitializeComponent();

            Pages = new Panel[] { WizardPage1, WizardPage2, WizardPage3, WizardPage4, WizardPage5 };
            CurrentPage = 0;
            UpdatePages();
            foreach (var page in Pages)
                page.SetBounds(ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Width, ClientRectangle.Height - 52);
            Size = new System.Drawing.Size(390, 475);

            SearchResultList.SetRenderer(new Manina.Windows.Forms.ImageListViewRenderers.ThemeRenderer());

            string path = Properties.Settings.Default.LastPath;
            if (System.IO.Directory.Exists(path))
                SearchFolder.Path = path;

            var sizeColumn = new ImageListView.ImageListViewColumnHeader(ColumnType.Custom, "assoc_files", "Boyut", 120);
            sizeColumn.Comparer = new SizeColumnComparer();
            SearchResultList.Columns.Add(sizeColumn);
        }

        private class SizeColumnComparer : IComparer<ImageListViewItem>
        {
            public int Compare(ImageListViewItem x, ImageListViewItem y)
            {
                return ((FileSearcher.SearchResult)x.Tag).TotalFileSize.CompareTo(((FileSearcher.SearchResult)y.Tag).TotalFileSize);
            }
        }

        private void NextPage()
        {
            CurrentPage++;
            CurrentPage = Math.Max(0, Math.Min(Pages.Length - 1, CurrentPage));
            UpdatePages();
            ProcessPage();
        }

        private void UpdatePages()
        {
            int i = 0;
            foreach (var page in Pages)
            {
                page.Visible = (i == CurrentPage);
                i++;
            }

            NextButton.Enabled = true;
        }

        private void ProcessPage()
        {
            if (CurrentPage == 1)
            {
                List<Cleaner> cleaners = new List<Cleaner>();
                if (SearchSapFiles.Checked) cleaners.Add(new Sap2000Cleaner());
                if (SearchEtabsFiles.Checked) cleaners.Add(new EtabsCleaner());
                if (SearchSafeFiles.Checked) cleaners.Add(new SafeCleaner());
                if (SearchLarsaFiles.Checked) cleaners.Add(new Larsa4DCleaner());
                FileSearcher searcher = new FileSearcher(new System.IO.DirectoryInfo(SearchFolder.Path), cleaners);
                searcher.ProgressChanged += Searcher_ProgressChanged;
                searcher.SearchCompleted += Searcher_SearchCompleted;

                SearchProgress.Minimum = 0;
                SearchProgress.Maximum = 100;
                SearchProgress.Value = 0;
                SearchResultList.Items.Clear();
                SearchFileLabel.Text = "";

                NextButton.Enabled = false;
                totalFiles = 0;
                totalSize = 0;
                searcher.StartSearch();
            }
            else if (CurrentPage == 3)
            {
                FileDeleter deleter = new FileDeleter(SearchResultList.CheckedItems.Select(item => (FileSearcher.SearchResult)item.Tag), UseRecycleBin.Checked);
                deleter.ProgressChanged += Deleter_ProgressChanged;
                deleter.DeleteCompleted += Deleter_DeleteCompleted;

                DeleteProgress.Minimum = 0;
                DeleteProgress.Maximum = 100;
                DeleteProgress.Value = 0;
                DeleteFileLabel.Text = "";

                NextButton.Enabled = false;
                deleter.StartDelete();
            }
        }

        private void Searcher_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            SearchProgress.Value = e.ProgressPercentage;
            foreach (var result in e.UserState as List<FileSearcher.SearchResult>)
            {
                ImageListViewItem item = new ImageListViewItem(result.SourceFile.FullName);
                item.SubItems.Add("assoc_files", string.Format("{0} ({1} dosya)", Manina.Windows.Forms.Utility.FormatSize(result.TotalFileSize), result.AssociatedFiles.Count()));
                item.Tag = result;
                SearchResultList.Items.Add(item);
                SearchFileLabel.Text = result.SourceFile.Name;

                totalFiles += result.AssociatedFiles.Count();
                totalSize += result.TotalFileSize;
            }
        }

        private void Searcher_SearchCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            SearchFileLabel.Text = "";
            SearchResultLabel.Text = string.Format("Silinebilecek {0} dosya bulundu. Bu dosyalar silindiğinde {1} yer kazanılacak. Silinecek dosyaları seçip ileri düğmesine tıklayın.", totalFiles, Manina.Windows.Forms.Utility.FormatSize(totalSize));

            NextPage();
            NextButton.Enabled = false;
        }

        private void Deleter_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            DeleteProgress.Value = e.ProgressPercentage;
            var file = e.UserState as System.IO.FileInfo;
            DeleteFileLabel.Text = file.Name;
        }

        private void Deleter_DeleteCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DeleteFileLabel.Text = "";
            var result = e.Result as FileDeleter.DeleteResult;

            DeleteResultLabel.Text = string.Format("{0} dosya silindi. {1} yer kazanıldı.", result.Count, Manina.Windows.Forms.Utility.FormatSize(result.TotalFileSize));

            NextButton.Text = "Kapat";
            NextButton.Enabled = true;
            NextPage();
        }

        private void SearchResultList_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            using (var detailForm = new ItemDetailsForm())
            {
                detailForm.SetItem(e.Item.Tag as FileSearcher.SearchResult);
                detailForm.ShowDialog();
            }
        }

        private void SearchFolder_Click(object sender, EventArgs e)
        {
            SearchFolderBrowserDialog.SelectedPath = SearchFolder.Path;
            if (SearchFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = SearchFolderBrowserDialog.SelectedPath;
                SearchFolder.Path = path;
                Properties.Settings.Default.LastPath = path;
                Properties.Settings.Default.Save();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 4)
            {
                Close();
            }
            else if (CurrentPage == 2)
            {
                if (MessageBox.Show("Seçili dosyaları silmek istediğinizden emin misiniz?", "Analiz Dosyası Temizleyici", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    NextPage();
            }
            else
            {
                NextPage();
            }
        }

        private void SearchFiles_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = SearchSapFiles.Checked || SearchEtabsFiles.Checked || SearchSafeFiles.Checked || SearchLarsaFiles.Checked;
        }

        private void SelectAllFilesButton_Click(object sender, EventArgs e)
        {
            SearchResultList.CheckAll();
        }

        private void ClearSelectedFilesButton_Click(object sender, EventArgs e)
        {
            SearchResultList.UncheckAll();
        }

        private void SelectOlderThanOneWeekButton_Click(object sender, EventArgs e)
        {
            SearchResultList.UncheckAll();
            SearchResultList.CheckWhere(item => item.DateModified < DateTime.Now - TimeSpan.FromDays(7));
        }

        private void SelectOlderThanTwoWeeksButton_Click(object sender, EventArgs e)
        {
            SearchResultList.UncheckAll();
            SearchResultList.CheckWhere(item => item.DateModified < DateTime.Now - TimeSpan.FromDays(14));
        }

        private void SelectOlderThanOneMonthButton_Click(object sender, EventArgs e)
        {
            SearchResultList.UncheckAll();
            SearchResultList.CheckWhere(item => item.DateModified < DateTime.Now - TimeSpan.FromDays(30));
        }

        private void SelectOlderThanThreeMonthsButton_Click(object sender, EventArgs e)
        {
            SearchResultList.UncheckAll();
            SearchResultList.CheckWhere(item => item.DateModified < DateTime.Now - TimeSpan.FromDays(90));
        }

        private void SelectOlderThanSixMonthsButton_Click(object sender, EventArgs e)
        {
            SearchResultList.UncheckAll();
            SearchResultList.CheckWhere(item => item.DateModified < DateTime.Now - TimeSpan.FromDays(180));
        }

        private void SelectOlderThanOneYearButton_Click(object sender, EventArgs e)
        {
            SearchResultList.UncheckAll();
            SearchResultList.CheckWhere(item => item.DateModified < DateTime.Now - TimeSpan.FromDays(365));
        }

        private void SearchResultList_ItemCheckBoxClick(object sender, ItemEventArgs e)
        {
            NextButton.Enabled = SearchResultList.CheckedItems.Count > 0;
        }
    }
}
