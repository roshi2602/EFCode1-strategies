using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
namespace ClassLibrary
{
  public  class EFContext:DbContext
    {
        //create constructor
        public EFContext() : base("demo")
        {
            Database.SetInitializer<EFContext>(new CreateDatabaseIfNotExists<EFContext>());

        }
        public DbSet<StudentClass> studentClasses { get; set; }
        public DbSet<StudentAdd> studentAdds { get; set; }
    }
}
