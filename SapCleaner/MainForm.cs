using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SapCleaner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Application.Idle += Application_Idle;
        }

        private string[] extensionsToKeep = new string[] { "sdb", "$2k", "sbk", "log", "out", "txt", "dwg", "doc", "docx", "xls", "xlsx", "pdf" };


        private void Application_Idle(object sender, EventArgs e)
        {
            AnalyzeButton.Enabled = DriveList.SelectedDrives.Length > 0;
            CleanButton.Enabled = SearchResultList.Items.Count > 0;
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            FileSearcher searcher = new FileSearcher(DriveList.SelectedDrives.Select(p => p.RootDirectory), "*.sdb", extensionsToKeep);
            searcher.ProgressChanged += Searcher_ProgressChanged;
            searcher.SearchCompleted += Searcher_SearchCompleted;

            DriveList.Enabled = false;
            AnalyzeButton.Enabled = false;
            SearchProgress.Minimum = 0;
            SearchProgress.Maximum = 100;
            SearchProgress.Value = 0;
            SearchProgress.Visible = true;
            Width = 956;
            SearchResultList.Items.Clear();

            searcher.StartSearch();
        }

        private void Searcher_SearchCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DriveList.Enabled = true;
            AnalyzeButton.Enabled = true;
            SearchProgress.Visible = false;
        }

        private void Searcher_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            SearchProgress.Value = e.ProgressPercentage;
            foreach (var result in e.UserState as List<SearchResult>)
            {
                ListViewItem item = new ListViewItem(result.SourceFile.Name);
                item.SubItems.Add(result.SourceFile.DirectoryName);
                item.SubItems.Add(string.Format("{0} ({1} dosya)", Utility.ByteSizeToString(result.TotalFileSize), result.AssociatedFiles.Count));
                item.Tag = result;
                SearchResultList.Items.Add(item);
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            SearchProgress.Minimum = 0;
            SearchProgress.Maximum = SearchResultList.Items.Count > 0 ? SearchResultList.Items.Count : 1;
            SearchProgress.Value = 0;
            SearchProgress.Visible = true;

            foreach (ListViewItem item in SearchResultList.Items)
            {
                var result = item.Tag as SearchResult;
                foreach (var file in result.AssociatedFiles)
                {
                    System.Diagnostics.Debug.Print(file.Name);
                }
            }

            SearchResultList.Items.Clear();
            SearchProgress.Visible = false;
        }

        private void SearchResultList_DoubleClick(object sender, EventArgs e)
        {
            if (SearchResultList.SelectedItems.Count > 0)
            {
                var result = SearchResultList.SelectedItems[0].Tag as SearchResult;
                using (var detailForm = new ItemDetailsForm())
                {
                    detailForm.SetItem(result);
                    detailForm.ShowDialog();
                }
            }
        }
    }
}
