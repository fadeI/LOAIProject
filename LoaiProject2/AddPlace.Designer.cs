namespace LoaiProject2
{
    partial class AddPlace
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contructorName = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(133, 8);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(184, 20);
            this.Location.TabIndex = 1;
         //   this.Location.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "constructor :";
            // 
            // contructorName
            // 
            this.contructorName.FormattingEnabled = true;
            this.contructorName.Location = new System.Drawing.Point(444, 3);
            this.contructorName.Name = "contructorName";
            this.contructorName.Size = new System.Drawing.Size(184, 21);
            this.contructorName.TabIndex = 3;
           // this.contructorName.Validating += new System.ComponentModel.CancelEventHandler(this.contructorName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address\\Location :";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(133, 43);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(184, 20);
            this.Address.TabIndex = 10;
            //this.Address.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // AddPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contructorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label1);
            this.Name = "AddPlace";
            this.Size = new System.Drawing.Size(795, 109);
            //this.Load += new System.EventHandler(this.AddPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox contructorName;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Address;
    }
}
