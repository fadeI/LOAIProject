namespace LoaiProject2
{
    partial class Form1
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
            this.admin = new System.Windows.Forms.CheckBox();
            this.tabpanel = new System.Windows.Forms.Panel();
            this.reports = new System.Windows.Forms.CheckBox();
            this.right = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabpanel.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.Appearance = System.Windows.Forms.Appearance.Button;
            this.admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.admin.Location = new System.Drawing.Point(0, 0);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(120, 56);
            this.admin.TabIndex = 0;
            this.admin.Text = "administrator";
            this.admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admin.UseVisualStyleBackColor = true;
            this.admin.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
            // 
            // tabpanel
            // 
            this.tabpanel.Controls.Add(this.reports);
            this.tabpanel.Controls.Add(this.admin);
            this.tabpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabpanel.Location = new System.Drawing.Point(0, 0);
            this.tabpanel.Name = "tabpanel";
            this.tabpanel.Size = new System.Drawing.Size(120, 488);
            this.tabpanel.TabIndex = 1;
            // 
            // reports
            // 
            this.reports.Appearance = System.Windows.Forms.Appearance.Button;
            this.reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.reports.Location = new System.Drawing.Point(0, 56);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(120, 50);
            this.reports.TabIndex = 1;
            this.reports.Text = "reports";
            this.reports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reports.UseVisualStyleBackColor = true;
            this.reports.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // right
            // 
            this.right.Controls.Add(this.panel2);
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.Location = new System.Drawing.Point(120, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(586, 488);
            this.right.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 0);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(120, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 488);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 488);
            this.Controls.Add(this.right);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabpanel.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox admin;
        private System.Windows.Forms.Panel tabpanel;
        private System.Windows.Forms.Panel right;
        private System.Windows.Forms.CheckBox reports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

