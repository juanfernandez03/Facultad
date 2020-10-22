using System;
using System.ComponentModel.DataAnnotations;

namespace Facultad.Model
{
    public class Subject
    {
        [Key]
        public int IdSubject { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Workload { get; set; }
    }
}
