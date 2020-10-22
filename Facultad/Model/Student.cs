using System;
using System.ComponentModel.DataAnnotations;

namespace Facultad.Model
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
