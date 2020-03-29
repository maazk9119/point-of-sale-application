namespace POS_pointofsale
{
    partial class Main_usercontrol
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
            this.Button_Report = new System.Windows.Forms.Button();
            this.BUTTON_POS = new System.Windows.Forms.Button();
            this.Button_PdtInfo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Report
            // 
            this.Button_Report.BackColor = System.Drawing.Color.White;
            this.Button_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Report.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.Button_Report.Location = new System.Drawing.Point(634, 141);
            this.Button_Report.Name = "Button_Report";
            this.Button_Report.Size = new System.Drawing.Size(328, 205);
            this.Button_Report.TabIndex = 1;
            this.Button_Report.Text = "REPORTS";
            this.Button_Report.UseVisualStyleBackColor = false;
            this.Button_Report.Click += new System.EventHandler(this.Button_Report_Click);
            // 
            // BUTTON_POS
            // 
            this.BUTTON_POS.BackColor = System.Drawing.Color.White;
            this.BUTTON_POS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_POS.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_POS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.BUTTON_POS.Location = new System.Drawing.Point(300, 141);
            this.BUTTON_POS.Name = "BUTTON_POS";
            this.BUTTON_POS.Size = new System.Drawing.Size(328, 205);
            this.BUTTON_POS.TabIndex = 2;
            this.BUTTON_POS.Text = "POS";
            this.BUTTON_POS.UseVisualStyleBackColor = false;
            this.BUTTON_POS.Click += new System.EventHandler(this.BUTTON_POS_Click);
            // 
            // Button_PdtInfo
            // 
            this.Button_PdtInfo.BackColor = System.Drawing.Color.White;
            this.Button_PdtInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PdtInfo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_PdtInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.Button_PdtInfo.Location = new System.Drawing.Point(300, 352);
            this.Button_PdtInfo.Name = "Button_PdtInfo";
            this.Button_PdtInfo.Size = new System.Drawing.Size(328, 205);
            this.Button_PdtInfo.TabIndex = 3;
            this.Button_PdtInfo.Text = "PRODUCT DETAILS";
            this.Button_PdtInfo.UseVisualStyleBackColor = false;
            this.Button_PdtInfo.Click += new System.EventHandler(this.Button_PdtInfo_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.button4.Location = new System.Drawing.Point(634, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(328, 205);
            this.button4.TabIndex = 4;
            this.button4.Text = "ORDERS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Main_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Button_PdtInfo);
            this.Controls.Add(this.BUTTON_POS);
            this.Controls.Add(this.Button_Report);
            this.Name = "Main_usercontrol";
            this.Size = new System.Drawing.Size(1362, 704);
            this.Load += new System.EventHandler(this.Main_usercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_Report;
        private System.Windows.Forms.Button BUTTON_POS;
        private System.Windows.Forms.Button Button_PdtInfo;
        private System.Windows.Forms.Button button4;
    }
}
