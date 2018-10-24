using System;
using System.Windows.Forms;

namespace SapCleaner
{
    public partial class ItemDetailsForm : Form
    {
        public void SetItem(SearchResult result)
        {
            FilenameLabel.Text = result.SourceFile.Name;

            foreach (var file in result.AssociatedFiles)
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(Utility.ByteSizeToString(file.Length));
                AssociatedFileList.Items.Add(item);
            }
        }

        public ItemDetailsForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
