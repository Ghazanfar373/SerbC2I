using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    partial class FlightStatus_LLM:MyUserControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ====== UI Controls =================================================
        private System.Windows.Forms.Panel hudPanel;          // Heads‑up display
        private System.Windows.Forms.Label lblFlightNumber;  // Example label
        private System.Windows.Forms.ListView lvFlightDetails; // Example list
        // Add additional controls here as needed...

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support – do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ====== Instantiate Controls ======================================
            this.hudPanel = new System.Windows.Forms.Panel();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lvFlightDetails = new System.Windows.Forms.ListView();
            // Instantiate additional controls here...

            // ====== hudPanel ==================================================
            this.hudPanel.Anchor = (System.Windows.Forms.AnchorStyles.Top |
                                    System.Windows.Forms.AnchorStyles.Left |
                                    System.Windows.Forms.AnchorStyles.Right);
            this.hudPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hudPanel.Location = new System.Drawing.Point(12, 12);
            this.hudPanel.Name = "hudPanel";
            this.hudPanel.Size = new System.Drawing.Size(760, 100);
            this.hudPanel.TabIndex = 0;
            // (Drop your HUD controls inside this panel)

            // ====== lblFlightNumber ===========================================
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Location = new System.Drawing.Point(12, 120);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(108, 20);
            this.lblFlightNumber.TabIndex = 1;
            this.lblFlightNumber.Text = "Flight Number:";

            // ====== lvFlightDetails ===========================================
            this.lvFlightDetails.Anchor = (System.Windows.Forms.AnchorStyles.Top |
                                           System.Windows.Forms.AnchorStyles.Bottom |
                                           System.Windows.Forms.AnchorStyles.Left |
                                           System.Windows.Forms.AnchorStyles.Right);
            this.lvFlightDetails.Location = new System.Drawing.Point(12, 150);
            this.lvFlightDetails.Name = "lvFlightDetails";
            this.lvFlightDetails.Size = new System.Drawing.Size(760, 300);
            this.lvFlightDetails.TabIndex = 2;
            this.lvFlightDetails.View = System.Windows.Forms.View.Details;
            // Example columns (add/remove as needed)
            this.lvFlightDetails.Columns.Add("Parameter", 120, HorizontalAlignment.Left);
            this.lvFlightDetails.Columns.Add("Value", 200, HorizontalAlignment.Left);
            this.lvFlightDetails.Columns.Add("Unit", 80, HorizontalAlignment.Left);

            // ====== Form Properties ===========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.lvFlightDetails);
            this.Controls.Add(this.lblFlightNumber);
            this.Controls.Add(this.hudPanel);
            // Add additional controls to the form here...
            this.Name = "FlightStatus";
            this.Text = "Flight Status";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

