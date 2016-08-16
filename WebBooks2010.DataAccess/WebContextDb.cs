using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks2010.Model;

namespace WebBooks2010.DataAccess
{
   public class WebContextDb : DbContext
    {

        public WebContextDb() : base("name=WebBooks2010ConnectionString")
        {
            Database.SetInitializer(new WebBooks2010Initializer());
            
        }
        public DbSet<Books> Book { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
