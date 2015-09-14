using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace LoaiProject2
{
    public partial class Form1 : Form
    {

   
        AdminControl adminControl = new AdminControl();
        ReportControl reportControl = new ReportControl();

        public Form1()
        {
            InitializeComponent();
        }
        


        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.admin.Checked = false;
            this.reportControl.Visible = true;
            this.adminControl.Visible = false;
            
        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            
            this.reports.Checked = false;
            this.reportControl.Visible = false;
            this.adminControl.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.right.Controls.Add(adminControl);
            this.right.Controls.Add(reportControl);
            this.reportControl.Visible = false;
        }
    }
}
