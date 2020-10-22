using System;
using System.ComponentModel.DataAnnotations;

namespace Facultad.Model
{
    public class StudentSubject
    {

        [Key]
        public int IdStudentSubject { get; set; }
        [Required]
        public int IdStudent { get; set; }
        [Required]
        public int IdSubject { get; set; }
        [Required]
        public int IdCareer { get; set; }
        [Required]
        public string Status { get; set; }
        public decimal Average { get; set; }
    }
}
