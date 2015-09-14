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
    public partial class AddContractor : UserControl
    {
        //        public  DBLayer dblayer;
        public bool validate = true;
        public AddContractor()
        {
            //          dblayer = new DBLayer();
            InitializeComponent();

        }
    }
}

        /*
        private void ContractorName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(this.ContractorName, null);
            
            if (string.IsNullOrEmpty(this.ContractorName.Text))
            {
                errorProvider1.SetError(this.ContractorName, "Please Fill Contructor Name");
                validate = false;
            }
        }

        


        internal void clearData()
        {
            this.ContractorName.Text = String.Empty;
            this.Phonenumber.Text = String.Empty;
        }
    }
}
        */