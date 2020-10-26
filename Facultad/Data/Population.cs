using Facultad.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Runtime.InteropServices;

namespace Facultad.Data
{
    public static class Population
    {
        public static void PopulationDB(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<FacultadContext>());
            }
        }

        public static void SeedData(FacultadContext context)
        {
            context.Database.Migrate();
            if (!context.Careers.Any())
            {
                context.Careers.AddRange(
                    new Career() { Name = "Engineering" , ObtainedTitle = "Software Engineering" },
                    new Career() { Name = "Medicine", ObtainedTitle = "Doctor" }
                    );
            }
            if (!context.Subjects.Any())
            {
                context.Subjects.AddRange(
                    new Subject() { Name = "Math",  Workload = 8 },
                    new Subject() { Name = "Pathology",  Workload = 10 }
                    );
            }
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student() { Name = "Juan Carlos Paez",  Address = "San Martin 234" },
                    new Student() { Name = "Julieta Fox", Address = "San Juan 234" }
                    );
            }
            context.SaveChanges();

            if (!context.StudentSubjects.Any())
            {

               var newStudentSubject = new StudentSubject()
                {
                     IdCareer = context.Careers.FirstOrDefault().IdCareer,
                     IdStudent = context.Students.FirstOrDefault().IdStudent,
                   IdSubject  = context.Subjects.FirstOrDefault().IdSubject,
                   Status = "InProgress",
                   Average = 7
                };

                context.Add(newStudentSubject);
            }
            context.SaveChanges();
        }
    }
}
