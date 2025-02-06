using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
        [ToolboxItem(true)]
        public class GraphicLabel : Control
        {
            public GraphicLabel()
            {
                // Set styles to support transparent background
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                this.BackColor = Color.Transparent;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                // Draw a string
                using (Brush brush = new SolidBrush(ForeColor))
                {
                    e.Graphics.DrawString(Text, Font, brush, new PointF(0, 0));
                }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public override string Text
            {
                get { return base.Text; }
                set { base.Text = value; Invalidate(); }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public override Font Font
            {
                get { return base.Font; }
                set { base.Font = value; Invalidate(); }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public override Color ForeColor
            {
                get { return base.ForeColor; }
                set { base.ForeColor = value; Invalidate(); }
            }
        }
    }


