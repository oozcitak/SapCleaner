using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SapCleaner
{
    [Designer(typeof(FileSystemLabelDesigner))]
    public class FileSystemLabel : Control
    {
        private readonly Color disabledBackColor = Color.FromArgb(217, 217, 217);
        private readonly Color backColor = Color.FromArgb(252, 255, 255);
        private readonly Color foreColor = Color.FromArgb(0, 0, 0);
        private readonly Color detailColor = Color.FromArgb(96, 96, 96);
        private readonly Color focusBorderColor = Color.FromArgb(153, 209, 255);
        private readonly Color hoverBackColor = Color.FromArgb(229, 243, 255);
        private readonly Color selectedBackColor = Color.FromArgb(204, 232, 255);
        private bool mouseOver = false;
        private bool mouseDown = false;

        private RectangleF iconRect;
        private RectangleF textRect;
        private Image icon = null;
        private Size thumbnailSize = new Size(64, 64);
        private readonly Size itemPadding = new Size(8, 8);

        private string path = "";
        private BorderStyle borderStyle = BorderStyle.FixedSingle;

        private string displayName = "";
        private string fullName = "";

        [Category("Data")]
        public string Path
        {
            get => path;
            set
            {
                path = value;
                UpdateInfo();
                Invalidate();
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            Size sz = MeasureItem();
            base.SetBoundsCore(x, y, width, Math.Max(23, sz.Height), specified);
        }

        [Category("Appearance"), DefaultValue(typeof(BorderStyle), "FixedSingle")]
        public BorderStyle BorderStyle
        {
            get => borderStyle;
            set
            {
                borderStyle = value;
                UpdateHeight();
                Invalidate();
            }
        }


        [Category("Appearance"), DefaultValue(typeof(Size), "64,64")]
        public Size ThumbnailSize
        {
            get => thumbnailSize;
            set
            {
                thumbnailSize = value;
                UpdateHeight();
                UpdateInfo();
                Invalidate();
            }
        }

        [Browsable(false)]
        public new Rectangle ClientRectangle
        {
            get
            {
                Rectangle rect = base.ClientRectangle;
                if (borderStyle != BorderStyle.None)
                {
                    rect.Offset(1, 1);
                    rect.Width -= 2;
                    rect.Height -= 2;
                }
                return rect;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected override bool DoubleBuffered { get => true; set => base.DoubleBuffered = true; }

        public FileSystemLabel()
        {
            DoubleBuffered = true;
            Path = System.IO.DriveInfo.GetDrives()[0].RootDirectory.FullName;
        }

        private void UpdateInfo()
        {
            if (Directory.Exists(path) || File.Exists(path))
            {
                Shell32.SHCreateItemFromParsingName(path, IntPtr.Zero, Shell32.IID_IShellItem, out var shItem);
                shItem.GetDisplayName(Shell32.SIGDN.NORMALDISPLAY, out var ptrDisplay);
                displayName = Marshal.PtrToStringAuto(ptrDisplay);
                shItem.GetDisplayName(Shell32.SIGDN.FILESYSPATH, out var ptrFull);
                fullName = Marshal.PtrToStringAuto(ptrFull);
                ((Shell32.IShellItemImageFactory)shItem).GetImage(new Shell32.SIZE(thumbnailSize.Width, thumbnailSize.Height), Shell32.SIIGBF.NONE, out var hbitmap);
                icon = ConvertToAlphaBitmap(Bitmap.FromHbitmap(hbitmap));
            }
            else
            {
                icon = null;
                displayName = "";
                fullName = "";
            }
        }

        private void UpdateHeight()
        {
            Size sz = MeasureItem();
            Size = new Size(Size.Width, sz.Height);
        }

        private void DrawBorder(Graphics g)
        {
            if (borderStyle == BorderStyle.FixedSingle)
            {
                ControlPaint.DrawBorder3D(g, base.ClientRectangle, Border3DStyle.Flat);
            }
            else if (borderStyle == BorderStyle.Fixed3D)
            {
                ControlPaint.DrawBorder3D(g, base.ClientRectangle, Border3DStyle.SunkenOuter);
            }
        }

        private Size MeasureItem()
        {
            int width = ClientRectangle.Width;
            int lineHeight = Font.Height;
            float textHeight = 2.2f * lineHeight;
            float maxHeight = Math.Max(textHeight, thumbnailSize.Height);

            // Calculate item size
            iconRect = new RectangleF(itemPadding.Width, itemPadding.Height, thumbnailSize.Width, thumbnailSize.Height);
            textRect = new RectangleF(2 * itemPadding.Width + thumbnailSize.Width, itemPadding.Height,
                        width - 3 * itemPadding.Width - thumbnailSize.Width, textHeight);
            if (thumbnailSize.Height > textHeight)
                textRect.Offset(0, (maxHeight - textRect.Height) / 2f);
            else
                iconRect.Offset(0, (maxHeight - iconRect.Height) / 2f);

            return new Size((int)(iconRect.Width + textRect.Width + 3 * itemPadding.Width), (int)(maxHeight + 2 * itemPadding.Height));
        }

        private void DrawItem(Graphics g)
        {
            Rectangle bounds = ClientRectangle;

            // Paint background 
            using (Brush back = new SolidBrush(!Enabled ? disabledBackColor : mouseDown ? selectedBackColor : mouseOver ? hoverBackColor : backColor))
            {
                g.FillRectangle(back, bounds);
            }

            // Draw the image
            if (icon != null)
            {
                Rectangle pos = GetSizedIconBounds(icon, ToRectangle(iconRect), 0.0f, 0.5f);
                g.DrawImage(icon, pos);
            }

            // Draw item text
            int lineHeight = Font.Height;
            RectangleF rt = textRect;
            rt.Height = lineHeight;
            using (StringFormat sf = new StringFormat())
            {
                // File name
                sf.Alignment = StringAlignment.Near;
                sf.FormatFlags = StringFormatFlags.NoWrap;
                sf.LineAlignment = StringAlignment.Center;
                sf.Trimming = StringTrimming.EllipsisCharacter;
                using (Brush bItemFore = new SolidBrush(foreColor))
                {
                    g.DrawString(displayName, Font, bItemFore, rt, sf);
                }

                // File system text
                rt.Offset(0, 1.2f * lineHeight);
                using (Brush bItemDetails = new SolidBrush(detailColor))
                {
                    g.DrawString(fullName, Font, bItemDetails, rt, sf);
                }
            }

            // Focus rectangle
            if (Focused)
            {
                using (Pen bFocused = new Pen(focusBorderColor))
                {
                    g.DrawRectangle(bFocused, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
                }
            }
        }

        /// <summary>
        /// Gets the bounding rectangle of an image required to fit
        /// in to the given rectangle keeping the image aspect ratio.
        /// </summary>
        /// <param name="image">The source image.</param>
        /// <param name="fit">The rectangle to fit in to.</param>
        /// <param name="hAlign">Horizontal image aligment in percent.</param>
        /// <param name="vAlign">Vertical image aligment in percent.</param>
        /// <returns>New image size.</returns>
        private Rectangle GetSizedIconBounds(Image image, Rectangle fit, float hAlign, float vAlign)
        {
            if (hAlign < 0 || hAlign > 1.0f)
                throw new ArgumentException("hAlign must be between 0.0 and 1.0 (inclusive).", "hAlign");
            if (vAlign < 0 || vAlign > 1.0f)
                throw new ArgumentException("vAlign must be between 0.0 and 1.0 (inclusive).", "vAlign");
            Size scaled = GetSizedIconBounds(image, fit.Size);
            int x = fit.Left + (int)(hAlign * (fit.Width - scaled.Width));
            int y = fit.Top + (int)(vAlign * (fit.Height - scaled.Height));

            return new Rectangle(x, y, scaled.Width, scaled.Height);
        }

        /// <summary>
        /// Gets the scaled size of an image required to fit
        /// in to the given size keeping the image aspect ratio.
        /// </summary>
        /// <param name="image">The source image.</param>
        /// <param name="fit">The size to fit in to.</param>
        /// <returns>New image size.</returns>
        private Size GetSizedIconBounds(Image image, Size fit)
        {
            float f = System.Math.Max(image.Width / (float)fit.Width, image.Height / (float)fit.Height);
            if (f < 1.0f) f = 1.0f; // Do not upsize small images
            int width = (int)System.Math.Round(image.Width / f);
            int height = (int)System.Math.Round(image.Height / f);
            return new Size(width, height);
        }

        private Rectangle ToRectangle(RectangleF r)
        {
            return new Rectangle((int)r.Left, (int)r.Top, (int)r.Width, (int)r.Height);
        }

        private Bitmap ConvertToAlphaBitmap(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height, PixelFormat.Format32bppArgb);

            BitmapData sourceData = null;
            BitmapData resultData = null;
            try
            {
                sourceData = source.LockBits(new Rectangle(0, 0, source.Width, source.Height), ImageLockMode.ReadOnly, source.PixelFormat);
                resultData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height), ImageLockMode.WriteOnly, result.PixelFormat);

                for (int y = 0; y <= sourceData.Height - 1; y++)
                {
                    for (int x = 0; x <= sourceData.Width - 1; x++)
                    {
                        int color = Marshal.ReadInt32(sourceData.Scan0, (sourceData.Stride * y) + (4 * x));
                        Marshal.WriteInt32(resultData.Scan0, (resultData.Stride * y) + (4 * x), color);
                    }
                }
            }
            finally
            {
                result.UnlockBits(resultData);
                source.UnlockBits(sourceData);
            }

            return result;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawBorder(e.Graphics);

            MeasureItem();
            DrawItem(e.Graphics);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            mouseOver = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            mouseOver = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!mouseDown)
            {
                mouseDown = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (mouseDown)
            {
                mouseDown = false;
                Invalidate();
            }

        }

        internal class FileSystemLabelDesigner : ControlDesigner
        {
            private FileSystemLabelDesigner()
            {
                base.AutoResizeHandles = true;
            }
            public override SelectionRules SelectionRules
            {
                get
                {
                    return SelectionRules.LeftSizeable | SelectionRules.RightSizeable | SelectionRules.Moveable;
                }
            }
        }
    }
}
