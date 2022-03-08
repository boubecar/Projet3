using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using WebApiCqrs.Models;

namespace CommonData
{
    public class PolinaDBContext : DbContext
    {
        public PolinaDBContext() {
            }
        public PolinaDBContext(DbContextOptions<PolinaDBContext> options)  
          : base(options)
        {
        }

       public DbSet<Filiale> fliales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {    if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = PolinaDbv1;Integrated Security=true");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
