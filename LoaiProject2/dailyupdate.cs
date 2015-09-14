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
    public partial class Dailyupdate : UserControl
    {
        
        public bool validate =true; 
        public Dailyupdate()
        {
            
            InitializeComponent();
        }
        /*
        private void dailyupdate_Load(object sender, EventArgs e)
        {
            //here to load data choose
            foreach (Worker worker in dblayer.database.Workers.ToList())
            {

                listWorkers.Items.Add(worker);
                listWorkers.ValueMember = worker.WorkerID.ToString();
                // here I need to add formatted name
                listWorkers.DisplayMember = "First_Name";

            }
            foreach (Place place in dblayer.database.Places.ToList())
            {

                listPlaces.Items.Add(place);
                listPlaces.ValueMember = place.PlaceId.ToString();
                listPlaces.DisplayMember = "PlaceCity";
            }
            foreach (Contractor con in dblayer.database.Contractors.ToList())
            {

                listContractor.Items.Add(con);
                listContractor.ValueMember = con.ContractorID.ToString();
                listContractor.DisplayMember = "ContractorName";
               
            }
        }

        

        private void listWorkers_Validating(object sender, CancelEventArgs e)
        {
            
            if (listWorkers.SelectedIndex < 0){
                errorProvider1.SetError(this.listWorkers, "Pleace choose at least one element");
                validate = false;

            }

        }

        private void listPlaces_Validating(object sender, CancelEventArgs e)
        {
            if (listPlaces.SelectedIndex < 0)
            {
                errorProvider1.SetError(this.listPlaces, "Pleace choose at least one element");
                validate = false;

            }
        }

        private void listContractor_Validating(object sender, CancelEventArgs e)
        {
            if (listContractor.SelectedIndex < 0)
            {
                errorProvider1.SetError(this.listContractor, "Pleace choose at least one element");
                validate = false;

            }


        }

          */

    }
          
}
