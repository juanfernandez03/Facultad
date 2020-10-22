using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facultad.Model
{
    public class SubjectCareer
    {
        [Key]
        public int IdSubjectCareer { get; set; }
        [Required]
        public int IdCareer { get; set; }
        [Required]
        public int IdSubject { get; set; }
    }
}
