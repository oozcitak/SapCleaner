using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Manina.Windows.Forms;

namespace SapCleaner
{
    public partial class MainForm : Form
    {
        private long totalFiles = 0;
        private long totalSize = 0;

        public MainForm()
        {
            InitializeComponent();

            SearchResultList.SetRenderer(new Manina.Windows.Forms.ImageListViewRenderers.ThemeRenderer());

            string path = Properties.Settings.Default.LastPath;
            if (System.IO.Directory.Exists(path))
                SearchFolder.Path = path;

            wizardControl1.BackButtonText = LocalizedStrings.BackButtonText;
            wizardControl1.NextButtonText = LocalizedStrings.NextButtonText;
            wizardControl1.CloseButtonText = LocalizedStrings.CloseButtonText;

            SearchResultList.Columns.Add(ColumnType.Name);
            SearchResultList.Columns.Add(ColumnType.FolderName);
            SearchResultList.Columns.Add(ColumnType.DateModified);
            var sizeColumn = new ImageListView.ImageListViewColumnHeader(ColumnType.Custom, "assoc_files", LocalizedStrings.AssociatedFilesColumnName, 120);
            sizeColumn.Comparer = new SizeColumnComparer();
            SearchResultList.Columns.Add(sizeColumn);

            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
            ((ToolStripDropDownMenu)SelectFilesByDateButton.DropDown).ShowImageMargin = false;
        }

        private class SizeColumnComparer : IComparer<ImageListViewItem>
        {
            public int Compare(ImageListViewItem x, ImageListViewItem y)
            {
                return ((FileSearcher.SearchResult)x.Tag).TotalFileSize.CompareTo(((FileSearcher.SearchResult)y.Tag).TotalFileSize);
            }
        }


        private void wizardControl1_PageChanging(object sender, WizardControl.PageChangingEventArgs e)
        {
            if (e.NewPage == WizardPage2 && e.CurrentPage == WizardPage3)
                e.NewPage = WizardPage1;
            else if (e.NewPage == WizardPage4 && e.CurrentPage == WizardPage5)
                e.NewPage = WizardPage3;
            else if (e.CurrentPage == WizardPage1 && e.NewPage == WizardPage2)
            {
                bool check = SearchSapFiles.Checked || SearchEtabsFiles.Checked || SearchSafeFiles.Checked || SearchLarsaFiles.Checked;
                if (!check)
                {
                    MessageBox.Show(LocalizedStrings.SelectAnalysisFilesMessage, LocalizedStrings.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                }
            }
            else if (e.CurrentPage == WizardPage3 && e.NewPage == WizardPage4)
            {
                bool check = (SearchResultList.CheckedItems.Count > 0);
                if (!check)
                {
                    MessageBox.Show(LocalizedStrings.SelectDeleteFilesMessage, LocalizedStrings.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = !(MessageBox.Show(LocalizedStrings.ConfirmDeleteMessage, LocalizedStrings.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes);
                }
            }
        }

        private void wizardControl1_PageShown(object sender, WizardControl.PageEventArgs e)
        {
            if (e.Page == WizardPage2)
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

                totalFiles = 0;
                totalSize = 0;

                wizardControl1.NextButtonEnabled = false;
                wizardControl1.BackButtonEnabled = false;
                wizardControl1.CloseButtonEnabled = false;

                searcher.StartSearch();
            }
            else if (e.Page == WizardPage4)
            {
                FileDeleter deleter = new FileDeleter(SearchResultList.CheckedItems.Select(item => (FileSearcher.SearchResult)item.Tag), UseRecycleBin.Checked);
                deleter.ProgressChanged += Deleter_ProgressChanged;
                deleter.DeleteCompleted += Deleter_DeleteCompleted;

                DeleteProgress.Minimum = 0;
                DeleteProgress.Maximum = 100;
                DeleteProgress.Value = 0;
                DeleteFileLabel.Text = "";

                wizardControl1.NextButtonEnabled = false;
                wizardControl1.BackButtonEnabled = false;
                wizardControl1.CloseButtonEnabled = false;

                deleter.StartDelete();
            }
        }

        private void Searcher_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            SearchProgress.Value = e.ProgressPercentage;
            foreach (var result in e.UserState as List<FileSearcher.SearchResult>)
            {
                ImageListViewItem item = new ImageListViewItem(result.SourceFile.FullName);
                item.SubItems.Add("assoc_files", string.Format(LocalizedStrings.AssociatedFilesSubItemText, Manina.Windows.Forms.Utility.FormatSize(result.TotalFileSize), result.AssociatedFiles.Count()));
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
            SearchResultLabel.Text = string.Format(LocalizedStrings.SearchResultLabelText, totalFiles, Manina.Windows.Forms.Utility.FormatSize(totalSize));

            wizardControl1.GoNext();
            wizardControl1.NextButtonEnabled = true;
            wizardControl1.BackButtonEnabled = true;
            wizardControl1.CloseButtonEnabled = true;
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

            DeleteResultLabel.Text = string.Format(LocalizedStrings.DeleteResultLabelText, result.Count, Manina.Windows.Forms.Utility.FormatSize(result.TotalFileSize));

            wizardControl1.GoNext();
            wizardControl1.NextButtonEnabled = true;
            wizardControl1.BackButtonEnabled = true;
            wizardControl1.CloseButtonEnabled = true;

            wizardControl1.NextButtonVisible = false;
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

        private class CustomColorTable : ProfessionalColorTable
        {
            private readonly Color backColor = Color.FromArgb(252, 255, 255);
            private readonly Color foreColor = Color.FromArgb(0, 0, 0);
            private readonly Color borderColor = Color.FromArgb(153, 153, 153);

            private readonly Color selectedItemBackColor = Color.FromArgb(204, 232, 255);
            private readonly Color selectedItemBorderColor = Color.FromArgb(153, 209, 255);

            private readonly Color hoveredItemBackColor = Color.FromArgb(229, 243, 255);

            public override Color ToolStripGradientBegin => backColor;
            public override Color ToolStripGradientMiddle => backColor;
            public override Color ToolStripGradientEnd => backColor;
            public override Color ToolStripBorder => backColor;

            public override Color SeparatorDark => backColor;
            public override Color SeparatorLight => backColor;

            public override Color MenuStripGradientBegin => backColor;
            public override Color MenuStripGradientEnd => backColor;

            public override Color ImageMarginGradientBegin => backColor;
            public override Color ImageMarginGradientMiddle => backColor;
            public override Color ImageMarginGradientEnd => backColor;

            public override Color ToolStripDropDownBackground => backColor;

            public override Color ToolStripPanelGradientBegin => backColor;
            public override Color ToolStripPanelGradientEnd => backColor;

            public override Color GripDark => backColor;
            public override Color GripLight => backColor;

            public override Color OverflowButtonGradientBegin => backColor;
            public override Color OverflowButtonGradientMiddle => backColor;
            public override Color OverflowButtonGradientEnd => backColor;
        }
    }
}
