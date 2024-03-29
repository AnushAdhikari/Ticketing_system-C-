
namespace Recreation_Center_Ticketing_Method
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnPrice);
            this.panelMenu.Controls.Add(this.btnVisit);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 449);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(29, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Check-Out Visitors";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gray;
            this.btnReport.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(29, 324);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(174, 57);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = " Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.Gray;
            this.btnPrice.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.Location = new System.Drawing.Point(29, 233);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(174, 57);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "Set Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.BackColor = System.Drawing.Color.Gray;
            this.btnVisit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisit.Location = new System.Drawing.Point(29, 79);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(174, 57);
            this.btnVisit.TabIndex = 1;
            this.btnVisit.Text = "Add Visitors";
            this.btnVisit.UseVisualStyleBackColor = false;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // panelDisplay
            // 
            this.panelDisplay.Location = new System.Drawing.Point(226, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(891, 449);
            this.panelDisplay.TabIndex = 1;
            this.panelDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplay_Paint);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1120, 454);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuForm";
            this.Text = "Recreation_Center_Ticketing_Method";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnExit;
    }
}

