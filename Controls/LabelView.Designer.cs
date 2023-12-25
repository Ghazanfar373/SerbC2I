namespace MissionPlanner.Controls
{
    partial class LabelView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new MissionPlanner.Controls.MyLabel();
            this.labelNumber = new MissionPlanner.Controls.MyLabel();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(6, 11);
            this.labelName.Name = "labelName";
            this.labelName.resize = false;
            this.labelName.Size = new System.Drawing.Size(91, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Airspeed";
            this.labelName.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs>(this.myLabel1_PaintSurface);
            // 
            // labelNumber
            // 
            this.labelNumber.Location = new System.Drawing.Point(108, 11);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.resize = false;
            this.labelNumber.Size = new System.Drawing.Size(92, 23);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "0.000";
            // 
            // LabelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelName);
            this.Name = "LabelView";
            this.Size = new System.Drawing.Size(204, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private MyLabel labelName;
        private MyLabel labelNumber;
    }
}
