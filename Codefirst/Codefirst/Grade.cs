using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst
{
    public class Grade
    {
        [Key]  
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Stud> Studs { get; set; }
    }
}
