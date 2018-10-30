using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Manina.Windows.Forms;

namespace SapCleaner
{
    public class DriveListView : Control
    {
        private ImageListView lvDrives;

        public int TileWidth { get; set; } = 280;
        public DriveInfo[] SelectedDrives => lvDrives.CheckedItems.Select(p => p.Tag as DriveInfo).ToArray();

        public DriveListView()
        {
            InitializeComponent();

            RefreshDrives();
            lvDrives.SetRenderer(new DriveListRenderer(TileWidth));
        }

        public void RefreshDrives()
        {
            lvDrives.Items.Clear();

            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Fixed)
                {
                    var item = new ImageListViewItem(drive.Name);
                    item.Tag = drive;
                    lvDrives.Items.Add(item);
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            lvDrives = new ImageListView();
            lvDrives.View = Manina.Windows.Forms.View.Thumbnails;
            lvDrives.Dock = DockStyle.Fill;
            lvDrives.ThumbnailSize = new Size(64, 64);
            lvDrives.ShowCheckBoxes = true;
            lvDrives.CheckBoxAlignment = ContentAlignment.TopLeft;
            lvDrives.CheckBoxPadding = new Size(4, 4);
            lvDrives.MultiSelect = false;
            lvDrives.ItemClick += LvDrives_ItemClick;

            this.Controls.Add(lvDrives);

            this.ResumeLayout(false);
        }

        private void LvDrives_ItemClick(object sender, ItemClickEventArgs e)
        {
            e.Item.Checked = !e.Item.Checked;
        }

        private void LvDrives_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            DriveInfo drive = e.Item.Tag as DriveInfo;

            e.DrawBackground();

            int textMargin = 3;
            Rectangle iconBounds = new Rectangle(e.Bounds.Left, e.Bounds.Top, e.Bounds.Height, e.Bounds.Height);
            Rectangle textBounds = new Rectangle(iconBounds.Right + textMargin, e.Bounds.Top, e.Bounds.Width - iconBounds.Width - textMargin, e.Bounds.Height);
            e.Graphics.DrawImage(Properties.Resources.drive_128, iconBounds);

            if (string.IsNullOrEmpty(drive.VolumeLabel))
                TextRenderer.DrawText(e.Graphics, drive.Name, lvDrives.Font, textBounds, SystemColors.WindowText, TextFormatFlags.Left | TextFormatFlags.Top);
            else
                TextRenderer.DrawText(e.Graphics, string.Format("{0} ({1})", drive.VolumeLabel, drive.Name), lvDrives.Font, textBounds, SystemColors.WindowText, TextFormatFlags.Left | TextFormatFlags.Top);

            e.DrawFocusRectangle();
        }

        private void LvDrives_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            ;
        }

        private class DriveListRenderer : ImageListViewRenderers.TilesRenderer
        {
            private readonly Color disabledBackColor = Color.FromArgb(217, 217, 217);
            private readonly Color selectedBackColor = Color.FromArgb(204, 232, 255);
            private readonly Color hoverBackColor = Color.FromArgb(229, 243, 255);
            private readonly Color focusBorderColor = Color.FromArgb(153, 209, 255);

            private readonly Color barColor = Color.FromArgb(38, 160, 218);
            private readonly Color fullBarColor = Color.FromArgb(218, 38, 38);
            private readonly float spaceWarningPercent = 0.9f;

            private RectangleF iconRect;
            private RectangleF textRect;
            private readonly Size itemPadding = new Size(8, 8);

            public DriveListRenderer(int tileWidth) : base(tileWidth)
            {
                ;
            }

            public override Size MeasureItem(Manina.Windows.Forms.View view)
            {
                if (view == Manina.Windows.Forms.View.Thumbnails)
                {
                    int lineHeight = ImageListView.Font.Height;
                    float textHeight = 4.6f * lineHeight;
                    float maxHeight = Math.Max(textHeight, ImageListView.ThumbnailSize.Height);

                    // Calculate item size
                    iconRect = new RectangleF(itemPadding.Width, itemPadding.Height, ImageListView.ThumbnailSize.Width, ImageListView.ThumbnailSize.Height);
                    textRect = new RectangleF(2 * itemPadding.Width + ImageListView.ThumbnailSize.Width, itemPadding.Height,
                                TileWidth - 3 * itemPadding.Width - ImageListView.ThumbnailSize.Width, textHeight);
                    if (ImageListView.ThumbnailSize.Height > textHeight)
                        textRect.Offset(0, (maxHeight - textRect.Height) / 2f);
                    else
                        iconRect.Offset(0, (maxHeight - iconRect.Height) / 2f);

                    return new Size((int)(iconRect.Width + textRect.Width + 3 * itemPadding.Width), (int)(maxHeight + 2 * itemPadding.Height));
                }
                else
                    return base.MeasureItem(view);
            }

            public override void DrawItem(Graphics g, ImageListViewItem item, ItemState state, Rectangle bounds)
            {
                if (ImageListView.View == Manina.Windows.Forms.View.Thumbnails)
                {
                    DriveInfo drive = item.Tag as DriveInfo;

                    RectangleF itemIconRect = iconRect;
                    RectangleF itemTextRect = textRect;
                    itemIconRect.Offset(bounds.Location);
                    itemTextRect.Offset(bounds.Location);

                    // Paint background disabled
                    if ((state & ItemState.Disabled) != ItemState.None)
                    {
                        using (Brush bDisabled = new SolidBrush(disabledBackColor))
                        {
                            g.FillRectangle(bDisabled, bounds);
                        }
                    }
                    else if (((state & ItemState.Hovered) != ItemState.None))
                    {
                        using (Brush bHovered = new SolidBrush(hoverBackColor))
                        {
                            g.FillRectangle(bHovered, bounds);
                        }
                    }
                    else if (ImageListView.Focused && ((state & ItemState.Selected) != ItemState.None))
                    {
                        using (Brush bSelected = new SolidBrush(selectedBackColor))
                        {
                            g.FillRectangle(bSelected, bounds);
                        }
                    }
                    else if (!ImageListView.Focused && ((state & ItemState.Selected) != ItemState.None))
                    {
                        using (Brush bGray64 = new SolidBrush(disabledBackColor))
                        {
                            g.FillRectangle(bGray64, bounds);
                        }
                    }


                    // Draw the image
                    Image img = Properties.Resources.drive_128;
                    if (img != null)
                    {
                        Rectangle pos = Manina.Windows.Forms.Utility.GetSizedImageBounds(img, ToRectangle(itemIconRect), 0.0f, 50.0f);
                        g.DrawImage(img, pos);
                    }

                    // Draw item text
                    int lineHeight = ImageListView.Font.Height;
                    RectangleF rt = itemTextRect;
                    rt.Height = lineHeight;
                    using (StringFormat sf = new StringFormat())
                    {
                        // Drive label
                        sf.Alignment = StringAlignment.Near;
                        sf.FormatFlags = StringFormatFlags.NoWrap;
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Trimming = StringTrimming.EllipsisCharacter;
                        using (Brush bItemFore = new SolidBrush(ImageListView.Colors.ForeColor))
                        {
                            string driveName = (string.IsNullOrEmpty(drive.VolumeLabel) ? drive.Name.Trim('\\') : string.Format("{0} ({1})", drive.VolumeLabel, drive.Name.Trim('\\')));
                            g.DrawString(driveName, ImageListView.Font, bItemFore, rt, sf);
                        }

                        // File system text
                        rt.Offset(0, 1.2f * lineHeight);
                        using (Brush bItemDetails = new SolidBrush(ImageListView.Colors.PaneLabelColor))
                        {
                            string fsText = string.Format("File system: {0}", drive.DriveFormat);
                            g.DrawString(fsText, ImageListView.Font, bItemDetails, rt, sf);
                        }

                        // Draw bar
                        rt.Offset(0, 1.2f * lineHeight);
                        float percentFull = (drive.TotalSize - drive.TotalFreeSpace) / (float)drive.TotalSize;
                        RectangleF barRect = new RectangleF(rt.Left, rt.Top, rt.Width, lineHeight);
                        RectangleF barFillRect = new RectangleF(rt.Left, rt.Top, rt.Width * percentFull, lineHeight);
                        using (Brush barFill = new SolidBrush(percentFull > spaceWarningPercent ? fullBarColor : barColor))
                        using (Pen pOuterBorder = new Pen(ImageListView.Colors.ImageOuterBorderColor))
                        {
                            g.FillRectangle(barFill, barFillRect);
                            g.DrawRectangle(pOuterBorder, barRect.Left, barRect.Top, barRect.Width, barRect.Height);
                        }

                        // Free space text
                        rt.Offset(0, 1.2f * lineHeight);
                        using (Brush bItemDetails = new SolidBrush(ImageListView.Colors.PaneLabelColor))
                        {
                            string driveSpace = string.Format("{0} free, {1} total", Manina.Windows.Forms.Utility.FormatSize(drive.TotalFreeSpace), Manina.Windows.Forms.Utility.FormatSize(drive.TotalSize));
                            g.DrawString(driveSpace, ImageListView.Font, bItemDetails, rt, sf);
                        }
                    }

                    // Focus rectangle
                    if (ImageListView.Focused && ((state & ItemState.Focused) != ItemState.None))
                    {
                        using (Pen bFocused = new Pen(focusBorderColor))
                        {
                            g.DrawRectangle(bFocused, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
                        }
                    }
                }
                else
                    base.DrawItem(g, item, state, bounds);
            }

            private Rectangle ToRectangle(RectangleF r)
            {
                return new Rectangle((int)r.Left, (int)r.Top, (int)r.Width, (int)r.Height);
            }
        }
    }
}
