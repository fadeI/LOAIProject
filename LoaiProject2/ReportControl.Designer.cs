using System.Windows.Forms;
namespace LoaiProject2
{
    partial class ReportControl
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
            this.reports_tree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // reports_tree
            // 
            this.reports_tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.reports_tree.Location = new System.Drawing.Point(0, 0);
            this.reports_tree.Name = "reports_tree";
            treeNode1.Name = "Workers";
            treeNode1.Text = "Workers";
            this.reports_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.reports_tree.Size = new System.Drawing.Size(124, 410);
            this.reports_tree.TabIndex = 1;
            // 
            // reportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Dock = DockStyle.Fill;
            this.Controls.Add(this.reports_tree);
            this.Name = "reportControl";
            this.Size = new System.Drawing.Size(680, 410);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView reports_tree;
    }
}
