using System;
using System.Linq;
using System.Windows.Forms;
using Manina.Windows.Forms;

namespace SapCleaner
{
    public partial class ItemDetailsForm : Form
    {
        public void SetItem(FileSearcher.SearchResult result)
        {
            Text = result.SourceFile.Name;
            DetailsLabel.Text = string.Format("{0} adet analiz dosyası toplam {1} yer kaplamaktadır.", result.AssociatedFiles.Count(), Manina.Windows.Forms.Utility.FormatSize(result.TotalFileSize));

            foreach (var file in result.AssociatedFiles)
            {
                var item = new ImageListViewItem(file.FullName);
                AssociatedFileList.Items.Add(item);
            }
        }

        public ItemDetailsForm()
        {
            InitializeComponent();

            AssociatedFileList.SetRenderer(new ImageListViewRenderers.ThemeRenderer());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
