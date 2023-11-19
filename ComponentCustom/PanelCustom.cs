using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject_QUANLYKHO.ComponentCustom
{
    internal class PanelCustom : Panel
    {
        public PanelCustom()
        {
            // Set the border style to None to hide the default border.
            this.BorderStyle = BorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a dashed border Pen with the desired color and line style.
            using (Pen dashedPen = new Pen(Color.Black))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                // Get the client area of the panel.
                Rectangle clientRect = this.ClientRectangle;

                // Draw the dashed border only along the bottom edge of the panel.
                e.Graphics.DrawLine(dashedPen, clientRect.Left, clientRect.Bottom, clientRect.Right, clientRect.Bottom);

                // Draw a solid line at the top edge of the panel to clear the top border.
                e.Graphics.DrawLine(Pens.Transparent, clientRect.Left, clientRect.Top, clientRect.Right, clientRect.Top);

                // Draw a solid line at the left edge of the panel to clear the left border.
                e.Graphics.DrawLine(Pens.Transparent, clientRect.Left, clientRect.Top, clientRect.Left, clientRect.Bottom);

                // Draw a solid line at the right edge of the panel to clear the right border.
                e.Graphics.DrawLine(Pens.Transparent, clientRect.Right, clientRect.Top, clientRect.Right, clientRect.Bottom);
            }
        }
    }
}
