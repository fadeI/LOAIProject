using System;
namespace LoaiProject2
{
    partial class AddWorker
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
            this.firstname = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.TextBox();
            this.Salay_Tex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hireDate = new System.Windows.Forms.DateTimePicker();
            this.fireDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(3, 12);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(63, 13);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name :";
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(72, 9);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(129, 20);
            this.First.TabIndex = 1;
            //this.First.Validating += new System.ComponentModel.CancelEventHandler(this.FristName_Validating);
            // 
            // Salay_Tex
            // 
            this.Salay_Tex.Location = new System.Drawing.Point(324, 9);
            this.Salay_Tex.Name = "Salay_Tex";
            this.Salay_Tex.Size = new System.Drawing.Size(129, 20);
            this.Salay_Tex.TabIndex = 3;
           // this.Salay_Tex.Validating += new System.ComponentModel.CancelEventHandler(this.Salay_Tex_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary :";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(324, 37);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(129, 20);
            this.phoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone number :";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(73, 38);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(129, 20);
            this.LastName.TabIndex = 7;
            //this.LastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hire date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fire Date";
            // 
            // hireDate
            // 
            this.hireDate.Location = new System.Drawing.Point(522, 8);
            this.hireDate.Name = "hireDate";
            this.hireDate.Size = new System.Drawing.Size(200, 20);
            this.hireDate.TabIndex = 12;
            // 
            // fireDate
            // 
            this.fireDate.Location = new System.Drawing.Point(522, 34);
            this.fireDate.Name = "fireDate";
            this.fireDate.Size = new System.Drawing.Size(200, 20);
            this.fireDate.TabIndex = 13;
            this.fireDate.Value = this.fireDate.MinDate;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.fireDate);
            this.Controls.Add(this.hireDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salay_Tex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.First);
            this.Controls.Add(this.firstname);
            this.Name = "AddWorker";
            this.Size = new System.Drawing.Size(795, 94);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstname;
        public  System.Windows.Forms.TextBox First;
        public  System.Windows.Forms.TextBox Salay_Tex;
        private System.Windows.Forms.Label label2;
        public  System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label3;
        public  System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public  System.Windows.Forms.DateTimePicker hireDate;
        public System.Windows.Forms.DateTimePicker fireDate;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
