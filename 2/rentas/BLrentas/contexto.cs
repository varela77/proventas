using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLrentas
{
    public class contexto: DbContext
    {
        public contexto(): base()
        {

        }

        public DbSet<producto> productos { get; set; }

    }
}
