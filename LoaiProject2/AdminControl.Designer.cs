namespace LoaiProject2
{
    partial class AdminControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Workers");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Places");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Contractor");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Supplier");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Daily update");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Workers";
            treeNode1.Text = "Workers";
            treeNode2.Name = "Places";
            treeNode2.Text = "Places";
            treeNode3.Name = "Contractor";
            treeNode3.Text = "Contractor";
            treeNode4.Name = "Supplier";
            treeNode4.Text = "Supplier";
            treeNode5.Name = "Daily update";
            treeNode5.Text = "Daily update";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(121, 410);
            this.treeView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(121, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(121, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 23);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(6, 0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(50, 23);
            this.refresh.TabIndex = 0;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(121, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(559, 287);
            this.dataGridView1.TabIndex = 4;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(680, 410);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
