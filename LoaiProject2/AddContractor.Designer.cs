namespace LoaiProject2
{
    partial class AddContractor
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
            this.ContractorName = new System.Windows.Forms.TextBox();
            this.Phonenumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contractor Name :";
            // 
            // ContractorName
            // 
            this.ContractorName.Location = new System.Drawing.Point(137, 12);
            this.ContractorName.Name = "ContractorName";
            this.ContractorName.Size = new System.Drawing.Size(170, 20);
            this.ContractorName.TabIndex = 1;
           // this.ContractorName.Validating += new System.ComponentModel.CancelEventHandler(this.ContractorName_Validating);
            // 
            // Phonenumber
            // 
            this.Phonenumber.Location = new System.Drawing.Point(457, 16);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(172, 20);
            this.Phonenumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contractor phone :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.ContractorName);
            this.Controls.Add(this.label1);
            this.Name = "AddContractor";
            this.Size = new System.Drawing.Size(795, 109);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ContractorName;
        public System.Windows.Forms.TextBox Phonenumber;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
