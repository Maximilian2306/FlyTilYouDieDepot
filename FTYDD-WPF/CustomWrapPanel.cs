using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace FTYDD_WPF
{
    public class CustomWrapPanel : WrapPanel
    {
        public int MaxItemsPerRow { get; set; } = 3;

        protected override Size MeasureOverride(Size availableSize)
        {
            Size curLineSize = new Size(0, 0);
            Size panelSize = new Size(0, 0);
            int itemsInCurrentRow = 0;

            foreach (UIElement child in this.InternalChildren)
            {
                child.Measure(availableSize);
                Size sz = child.DesiredSize;

                if (itemsInCurrentRow >= MaxItemsPerRow)
                {
                    panelSize.Width = Math.Max(curLineSize.Width, panelSize.Width);
                    panelSize.Height += curLineSize.Height;
                    curLineSize = sz;
                    itemsInCurrentRow = 0;
                }
                else
                {
                    curLineSize.Width += sz.Width;
                    curLineSize.Height = Math.Max(sz.Height, curLineSize.Height);
                }

                itemsInCurrentRow++;
            }

            panelSize.Width = Math.Max(curLineSize.Width, panelSize.Width);
            panelSize.Height += curLineSize.Height;

            return panelSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            Size curLineSize = new Size(0, 0);
            double curY = 0;
            int itemsInCurrentRow = 0;

            foreach (UIElement child in this.InternalChildren)
            {
                Size sz = child.DesiredSize;

                if (itemsInCurrentRow >= MaxItemsPerRow)
                {
                    ArrangeLine(curY, curLineSize.Height, itemsInCurrentRow);
                    curY += curLineSize.Height;
                    curLineSize = sz;
                    itemsInCurrentRow = 0;
                }
                else
                {
                    curLineSize.Width += sz.Width;
                    curLineSize.Height = Math.Max(sz.Height, curLineSize.Height);
                }

                itemsInCurrentRow++;
            }

            ArrangeLine(curY, curLineSize.Height, itemsInCurrentRow);

            return finalSize;
        }

        private void ArrangeLine(double y, double height, int itemsInCurrentRow)
        {
            double curX = 0;
            foreach (UIElement child in this.InternalChildren)
            {
                if (itemsInCurrentRow <= 0) break;
                Size sz = child.DesiredSize;
                child.Arrange(new Rect(curX, y, sz.Width, height));
                curX += sz.Width;
                itemsInCurrentRow--;
            }
        }
    }
}