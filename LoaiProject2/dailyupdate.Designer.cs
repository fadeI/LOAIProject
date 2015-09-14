namespace LoaiProject2
{
    partial class Dailyupdate
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
            this.workers = new System.Windows.Forms.Label();
            this.listWorkers = new System.Windows.Forms.ListBox();
            this.places = new System.Windows.Forms.Label();
            this.listPlaces = new System.Windows.Forms.ListBox();
            this.contractor = new System.Windows.Forms.Label();
            this.listContractor = new System.Windows.Forms.ListBox();
            this.DateChoosen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // workers
            // 
            this.workers.AutoSize = true;
            this.workers.Location = new System.Drawing.Point(3, 0);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(62, 13);
            this.workers.TabIndex = 0;
            this.workers.Text = "workers list:";
            // 
            // listWorkers
            // 
            this.listWorkers.FormattingEnabled = true;
            this.listWorkers.Location = new System.Drawing.Point(6, 16);
            this.listWorkers.Name = "listWorkers";
            this.listWorkers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listWorkers.Size = new System.Drawing.Size(120, 82);
            this.listWorkers.TabIndex = 2;
            //this.listWorkers.Validating += new System.ComponentModel.CancelEventHandler(this.listWorkers_Validating);
            // 
            // places
            // 
            this.places.AutoSize = true;
            this.places.Location = new System.Drawing.Point(157, 0);
            this.places.Name = "places";
            this.places.Size = new System.Drawing.Size(59, 13);
            this.places.TabIndex = 3;
            this.places.Text = "places list :";
            // 
            // listPlaces
            // 
            this.listPlaces.FormattingEnabled = true;
            this.listPlaces.Location = new System.Drawing.Point(160, 16);
            this.listPlaces.Name = "listPlaces";
            this.listPlaces.Size = new System.Drawing.Size(112, 82);
            this.listPlaces.TabIndex = 4;
            //this.listPlaces.Validating += new System.ComponentModel.CancelEventHandler(this.listPlaces_Validating);
            // 
            // contractor
            // 
            this.contractor.AutoSize = true;
            this.contractor.Location = new System.Drawing.Point(294, 0);
            this.contractor.Name = "contractor";
            this.contractor.Size = new System.Drawing.Size(73, 13);
            this.contractor.TabIndex = 5;
            this.contractor.Text = "contractor list:";
            // 
            // listContractor
            // 
            this.listContractor.FormattingEnabled = true;
            this.listContractor.Location = new System.Drawing.Point(297, 17);
            this.listContractor.Name = "listContractor";
            this.listContractor.Size = new System.Drawing.Size(110, 82);
            this.listContractor.TabIndex = 6;
           // this.listContractor.Validating += new System.ComponentModel.CancelEventHandler(this.listContractor_Validating);
            // 
            // DateChoosen
            // 
            this.DateChoosen.Location = new System.Drawing.Point(456, 17);
            this.DateChoosen.Name = "DateChoosen";
            this.DateChoosen.Size = new System.Drawing.Size(230, 20);
            this.DateChoosen.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "current date :";
            
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Dailyupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateChoosen);
            this.Controls.Add(this.listContractor);
            this.Controls.Add(this.contractor);
            this.Controls.Add(this.listPlaces);
            this.Controls.Add(this.places);
            this.Controls.Add(this.listWorkers);
            this.Controls.Add(this.workers);
            this.Name = "Dailyupdate";
            this.Size = new System.Drawing.Size(795, 109);
           // this.Load += new System.EventHandler(this.dailyupdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workers;
        public System.Windows.Forms.ListBox listWorkers;
        private System.Windows.Forms.Label places;
        public System.Windows.Forms.ListBox listPlaces;
        private System.Windows.Forms.Label contractor;
        public System.Windows.Forms.ListBox listContractor;
        public System.Windows.Forms.DateTimePicker DateChoosen;
        private System.Windows.Forms.Label label1;
        
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
