using System;
using System.Collections.Generic;
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
                string[] extensionsToKeep = new string[] { "sdb", "$2k", "s2k", "sbk", "log", "out", "txt", "dwg", "doc", "docx", "xls", "xlsx", "pdf" };
                FileSearcher searcher = new FileSearcher(new System.IO.DirectoryInfo(SearchFolder.Path), "*.sdb", extensionsToKeep);
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
                DeleteProgress.Minimum = 0;
                DeleteProgress.Maximum = SearchResultList.Items.Count > 0 ? SearchResultList.Items.Count : 1;
                DeleteProgress.Value = 0;
                DeleteFileLabel.Text = "";

                NextButton.Enabled = false;
                long deletedFiles = 0;
                long deletedSize = 0;
                foreach (ImageListViewItem item in SearchResultList.Items)
                {
                    var result = item.Tag as SearchResult;
                    foreach (var file in result.AssociatedFiles)
                    {
                        if (DeleteAnalysisFiles.Checked)
                        {
                            deletedFiles++;
                            deletedSize += file.Length;

                            // Delete file
                            DeleteFile(file.FullName, UseRecycleBin.Checked);
                        }
                    }
                    DeleteFileLabel.Text = result.SourceFile.Name;
                    DeleteProgress.Value++;
                }

                SearchResultList.Items.Clear();
                DeleteResultLabel.Text = string.Format("{0} dosya silindi. {1} yer kazanıldı.", deletedFiles, Manina.Windows.Forms.Utility.FormatSize(deletedSize));
                NextButton.Text = "Kapat";

                NextPage();
                NextButton.Enabled = true;
            }
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
                SearchFileLabel.Text = result.SourceFile.Name;

                totalFiles += result.AssociatedFiles.Count;
                totalSize += result.TotalFileSize;
            }
        }

        private void Searcher_SearchCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            SearchFileLabel.Text = "";
            SearchResultLabel.Text = string.Format("Silinebilecek {0} dosya bulundu. Bu dosyalar silindiğinde {1} yer kazanılacak.", totalFiles, Manina.Windows.Forms.Utility.FormatSize(totalSize));

            NextPage();
            NextButton.Enabled = false;
        }

        private void SearchResultList_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            using (var detailForm = new ItemDetailsForm())
            {
                detailForm.SetItem(e.Item.Tag as SearchResult);
                detailForm.ShowDialog();
            }
        }

        private void SearchFolder_Click(object sender, EventArgs e)
        {
            SearchFolderBrowserDialog.SelectedPath = SearchFolder.Path;
            if (SearchFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SearchFolder.Path = SearchFolderBrowserDialog.SelectedPath;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 4)
            {
                Close();
            }
            else
            {
                NextPage();
            }
        }

        private void DeleteAnalysisFiles_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = DeleteAnalysisFiles.Checked;
        }

        private void DeleteFile(string path, bool sendToRecycleBin)
        {
            try
            {
                if (sendToRecycleBin)
                {
                    var fs = new Shell32.SHFILEOPSTRUCT();
                    fs.wFunc = Shell32.FileOperationType.FO_DELETE;
                    fs.pFrom = path + '\0' + '\0';
                    fs.fFlags = Shell32.FileOperationFlags.FOF_SILENT | Shell32.FileOperationFlags.FOF_NOCONFIRMATION |
                        Shell32.FileOperationFlags.FOF_NOERRORUI | Shell32.FileOperationFlags.FOF_SILENT;
                    Shell32.SHFileOperation(ref fs);
                }
                else
                {
                    System.IO.File.Delete(path);
                }
            }
            catch
            {
                ;
            }
        }
    }
}
