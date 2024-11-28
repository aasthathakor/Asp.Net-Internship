using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Codefirst
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=MyDbConnection")
        {
        }
        public DbSet<Stud> Studs { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
