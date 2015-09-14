using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Worker
    {

        public Worker()
        {

        }
        public int WorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName {get; set;}
        public string FormattedName { get; set; }
        public int Salary { get; set; }
        public string PhoneNumber { get; set; }



    }
}
