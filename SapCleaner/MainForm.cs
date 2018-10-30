using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Manina.Windows.Forms;

namespace SapCleaner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SearchResultList.SetRenderer(new Manina.Windows.Forms.ImageListViewRenderers.ThemeRenderer());

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
            SearchResultList.Enabled = false;
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
            SearchResultList.Enabled = true;
            AnalyzeButton.Enabled = true;
            SearchProgress.Visible = false;
        }

        private void Searcher_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            SearchProgress.Value = e.ProgressPercentage;
            foreach (var result in e.UserState as List<SearchResult>)
            {
                ImageListViewItem item = new ImageListViewItem(result.SourceFile.FullName);
                item.SubItems.Add("assoc_files", string.Format("{0} ({1} dosya)", Manina.Windows.Forms.Utility.FormatSize(result.TotalFileSize), result.AssociatedFiles.Count));
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

            foreach (ImageListViewItem item in SearchResultList.Items)
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

        private void SearchResultList_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            using (var detailForm = new ItemDetailsForm())
            {
                detailForm.SetItem(e.Item.Tag as SearchResult);
                detailForm.ShowDialog();
            }
        }
    }
}
