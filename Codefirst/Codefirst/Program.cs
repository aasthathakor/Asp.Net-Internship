using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (var ctx = new SchoolContext())
            {
         
                var grade = new Grade() { GradeName = "First Grade", Section = "A" };
                ctx.Grades.Add(grade);
                ctx.SaveChanges();
                var stud = new Stud()
                {
                    StudentName = "Dhawani",
                    DateOfBirth = new DateTime(2000, 5, 12),
                    Height = 5.2M,
                    Weight = 55.5F,
                    Grade = grade 
                };

                ctx.Studs.Add(stud);
                ctx.SaveChanges(); 
                Console.WriteLine("Student and Grade saved successfully.");
            }
            Console.ReadKey();
        }
    }
}
