using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{


    [ToolboxItem(true)]
    public class GraphicLabel : Control
    {
        private string _text = "";
        private bool _isValidated = false;
        private string _originalText;
        private bool _baseVisibility = true;
        public GraphicLabel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
                // Set styles to support transparent background
                UpdateBaseVisibility();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

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
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    if (value != _originalText)
                    {
                        _isValidated = true;
                        OnTextValidated(EventArgs.Empty);
                    }
                    UpdateBaseVisibility();
                    Invalidate();
                }
            }
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

        public event EventHandler TextValidated;

        protected virtual void OnTextValidated(EventArgs e)
        {
            TextValidated?.Invoke(this, e);
        }
        [Browsable(false)]
        public bool IsValidated
        {
            get { return _isValidated; }
        }

        // Override the base Visible property
        public new bool Visible
        {
            get { return base.Visible && _baseVisibility; }
            set { base.Visible = value; 
            Invalidate();
            }
            
        }

        private void UpdateBaseVisibility()
        {
            bool newVisibility = !string.IsNullOrEmpty(_text);
            if (_baseVisibility != newVisibility)
            {
                _baseVisibility = newVisibility;
                OnVisibleChanged(EventArgs.Empty);
            }
        }
    }
}


