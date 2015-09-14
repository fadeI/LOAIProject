using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class DataBaseContext :DbContext

    {
        public DataBaseContext()
            : base()
        {

        }
        public DbSet<Worker> Workers { get; set; } 

    }
}
