using Facultad.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facultad.Data
{
    public class FacultadContext : DbContext
    {
        public FacultadContext(DbContextOptions<FacultadContext> opt) : base(opt)
        {

        }

        public DbSet<Career> Careers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<SubjectCareer> SubjectCareers { get; set; }


    }
}
