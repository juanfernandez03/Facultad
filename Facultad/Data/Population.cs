using Facultad.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

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
            if (context.Careers.Any())
            {
                context.Careers.AddRange(
                    new Career() { Name = "Engineering" , ObtainedTitle = "Software Engineering" },
                    new Career() { Name = "Medicine", ObtainedTitle = "Doctor" }
                    );
            }
            if (context.Subjects.Any())
            {
                context.Subjects.AddRange(
                    new Subject() { Name = "Math",  Workload = 8 },
                    new Subject() { Name = "Pathology",  Workload = 10 }
                    );
            }
            if (context.Students.Any())
            {
                context.Students.AddRange(
                    new Student() { Name = "Juan Carlos Paez",  Address = "San Martin 234" },
                    new Student() { Name = "Julieta Fox", Address = "San Juan 234" }
                    );
            }

        }
    }
}
