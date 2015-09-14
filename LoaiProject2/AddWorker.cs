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
    public partial class AddWorker : UserControl
    {

//        public DBLayer dblayer;
        public bool validate = true;
        public AddWorker()
        {
  //          dblayer = new DBLayer();
            InitializeComponent();
        }
        /*
        private void FristName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(First.Text))
            {
                errorProvider1.SetError(First, "First Name is required ");
                validate = false;
            }
        }

        
        private void LastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LastName.Text))
            {
                errorProvider1.SetError(LastName, "Last Name required ");
                validate = false;
            }
        }

        private void Salay_Tex_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if (string.IsNullOrEmpty(Salay_Tex.Text) || !Int32.TryParse(Salay_Tex.Text,out result))
            {
                errorProvider1.SetError(Salay_Tex, "insert validate Salary");
                validate = false;
            } 
        }

        internal void clearData()
        {
            this.Salay_Tex.Text = String.Empty;
            this.LastName.Text = String.Empty;
            this.First.Text = String.Empty;
            this.phoneNumber.Text = String.Empty;
 
        }

        internal void updateworker(object p1, object p2, object p3, object p4, object p5, object p6, object p7)
        {

            // update data
            throw new NotImplementedException();
        }
         * 
         **/
    }
    
    
}
