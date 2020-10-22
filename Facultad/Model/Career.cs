using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facultad.Model
{
    public class Career
    {
        [Key]
        public int IdCareer { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ObtainedTitle { get; set; }
    }
}
