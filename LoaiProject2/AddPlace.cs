using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace LoaiProject2
{
    public partial class AddPlace : UserControl
    {
       // public DBLayer dblayer;       
        public bool validate = true;

        public AddPlace()
        {
           // dblayer = new DBLayer();
            InitializeComponent();
        }
    }
}
       /*
        private void AddPlace_Load(object sender, EventArgs e)
        {
            this.contructorName.DataSource = dblayer.database.Contractors.ToList();
            this.contructorName.ValueMember = "ContractorID";
            this.contructorName.DisplayMember = "ContractorName";
            this.contructorName.SelectedIndex = -1;
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.Location.Text))
            {
                errorProvider1.SetError(this.Location, "Please Fill Location");
                validate = false;
            }

        }

        private void Address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.Address.Text))
            {
                errorProvider1.SetError(this.Address, "Please Fill Address");
                validate = false;
            }
        }

        private void contructorName_Validating(object sender, CancelEventArgs e)
        {
            if (contructorName.SelectedIndex== -1){
                errorProvider1.SetError(this.contructorName, "you should choose one contructor");
                validate = false;
            }
        }

        internal void clearData()
        {
            this.Address.Text = String.Empty;
            this.Location.Text = String.Empty;
            this.contructorName.SelectedIndex = -1;
        }
         
    }
}
*/