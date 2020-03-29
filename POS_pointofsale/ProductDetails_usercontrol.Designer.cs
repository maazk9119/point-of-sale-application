namespace POS_pointofsale
{
    partial class ProductDetails_usercontrol
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BUTTON_ADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(363, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // BUTTON_ADD
            // 
            this.BUTTON_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(113)))));
            this.BUTTON_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BUTTON_ADD.FlatAppearance.BorderSize = 0;
            this.BUTTON_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_ADD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_ADD.ForeColor = System.Drawing.Color.White;
            this.BUTTON_ADD.Location = new System.Drawing.Point(615, 49);
            this.BUTTON_ADD.Name = "BUTTON_ADD";
            this.BUTTON_ADD.Size = new System.Drawing.Size(108, 46);
            this.BUTTON_ADD.TabIndex = 3;
            this.BUTTON_ADD.Text = "ADD";
            this.BUTTON_ADD.UseVisualStyleBackColor = false;
            this.BUTTON_ADD.Click += new System.EventHandler(this.BUTTON_ADD_Click);
            // 
            // ProductDetails_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BUTTON_ADD);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductDetails_usercontrol";
            this.Size = new System.Drawing.Size(1358, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button BUTTON_ADD;
    }
}
