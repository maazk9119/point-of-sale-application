namespace POS_pointofsale
{
    partial class FORM_MAIN
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BUTTON_MIN = new System.Windows.Forms.Button();
            this.BUTTON_EXIT = new System.Windows.Forms.Button();
            this.PANEL_TOP_MAIN = new System.Windows.Forms.Panel();
            this.BUTTON_BACK = new System.Windows.Forms.Button();
            this.PANEL_CONTROL = new System.Windows.Forms.Panel();
            this.PANEL_BOTTM_MAIN = new System.Windows.Forms.Panel();
            this.PANEL_TOP_MAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUTTON_MIN
            // 
            this.BUTTON_MIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.BUTTON_MIN.FlatAppearance.BorderSize = 3;
            this.BUTTON_MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_MIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_MIN.ForeColor = System.Drawing.Color.White;
            this.BUTTON_MIN.Location = new System.Drawing.Point(1271, -18);
            this.BUTTON_MIN.Name = "BUTTON_MIN";
            this.BUTTON_MIN.Size = new System.Drawing.Size(51, 60);
            this.BUTTON_MIN.TabIndex = 12;
            this.BUTTON_MIN.Text = "__";
            this.BUTTON_MIN.UseVisualStyleBackColor = false;
            this.BUTTON_MIN.Click += new System.EventHandler(this.BUTTON_MIN_Click);
            // 
            // BUTTON_EXIT
            // 
            this.BUTTON_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.BUTTON_EXIT.FlatAppearance.BorderSize = 3;
            this.BUTTON_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_EXIT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_EXIT.ForeColor = System.Drawing.Color.White;
            this.BUTTON_EXIT.Location = new System.Drawing.Point(1319, -3);
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(57, 45);
            this.BUTTON_EXIT.TabIndex = 11;
            this.BUTTON_EXIT.Text = "X";
            this.BUTTON_EXIT.UseVisualStyleBackColor = false;
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // PANEL_TOP_MAIN
            // 
            this.PANEL_TOP_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.PANEL_TOP_MAIN.Controls.Add(this.BUTTON_BACK);
            this.PANEL_TOP_MAIN.Location = new System.Drawing.Point(1, -3);
            this.PANEL_TOP_MAIN.Name = "PANEL_TOP_MAIN";
            this.PANEL_TOP_MAIN.Size = new System.Drawing.Size(1269, 41);
            this.PANEL_TOP_MAIN.TabIndex = 13;
            // 
            // BUTTON_BACK
            // 
            this.BUTTON_BACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.BUTTON_BACK.FlatAppearance.BorderSize = 3;
            this.BUTTON_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_BACK.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_BACK.ForeColor = System.Drawing.Color.White;
            this.BUTTON_BACK.Location = new System.Drawing.Point(-1, -2);
            this.BUTTON_BACK.Name = "BUTTON_BACK";
            this.BUTTON_BACK.Size = new System.Drawing.Size(82, 46);
            this.BUTTON_BACK.TabIndex = 20;
            this.BUTTON_BACK.Text = " Back";
            this.BUTTON_BACK.UseVisualStyleBackColor = false;
            this.BUTTON_BACK.Click += new System.EventHandler(this.BUTTON_BACK_Click);
            // 
            // PANEL_CONTROL
            // 
            this.PANEL_CONTROL.BackColor = System.Drawing.Color.White;
            this.PANEL_CONTROL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PANEL_CONTROL.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.PANEL_CONTROL.Location = new System.Drawing.Point(1, 42);
            this.PANEL_CONTROL.Name = "PANEL_CONTROL";
            this.PANEL_CONTROL.Size = new System.Drawing.Size(1362, 684);
            this.PANEL_CONTROL.TabIndex = 14;
            this.PANEL_CONTROL.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_CONTROL_Paint);
            // 
            // PANEL_BOTTM_MAIN
            // 
            this.PANEL_BOTTM_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.PANEL_BOTTM_MAIN.Location = new System.Drawing.Point(0, 732);
            this.PANEL_BOTTM_MAIN.Name = "PANEL_BOTTM_MAIN";
            this.PANEL_BOTTM_MAIN.Size = new System.Drawing.Size(1375, 61);
            this.PANEL_BOTTM_MAIN.TabIndex = 15;
            // 
            // FORM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 788);
            this.Controls.Add(this.PANEL_BOTTM_MAIN);
            this.Controls.Add(this.PANEL_CONTROL);
            this.Controls.Add(this.PANEL_TOP_MAIN);
            this.Controls.Add(this.BUTTON_MIN);
            this.Controls.Add(this.BUTTON_EXIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_MAIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FORM_MAIN_Load);
            this.PANEL_TOP_MAIN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUTTON_MIN;
        private System.Windows.Forms.Button BUTTON_EXIT;
        private System.Windows.Forms.Panel PANEL_TOP_MAIN;
        private System.Windows.Forms.Panel PANEL_CONTROL;
        private System.Windows.Forms.Panel PANEL_BOTTM_MAIN;
        private System.Windows.Forms.Button BUTTON_BACK;
    }
}