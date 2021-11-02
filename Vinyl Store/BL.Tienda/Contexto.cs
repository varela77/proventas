using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tienda
{
   public class contexto : DbContext
    {
        internal static object Tipos;

        public contexto() : base("Musica")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Tipo> tipos { get; set; }



    }

    
}
