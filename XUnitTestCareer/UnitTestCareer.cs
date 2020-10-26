
using Facultad.Data;
using Facultad.Interface;
using Facultad.Model;
using Facultad.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Linq;
using Xunit;

namespace XUnitTestCareer
{
    public class UnitTestCareerApp
    {

        [Fact]
        public void Test_GetAllSubject()
        {
            CareerManagerService careerManagerService = MoqContext();
            var allStudentSubject = careerManagerService.GetAllStudentSubject();

            Assert.NotNull(allStudentSubject);
        }
        [Fact]
        public void Test_AddStudentSubject()
        {
            CareerManagerService careerManagerService = MoqContext();
            var opt = new DbContextOptionsBuilder<FacultadContext>()
               .UseInMemoryDatabase(databaseName: "CareerDB").Options;
            var context = new FacultadContext(opt);
            var newStudentSubject = new StudentSubject()
            {
                IdCareer = 1,
                IdStudent = 1,
                IdSubject = 1,
                Status = "InProgress",
                Average = 7
            };
            var studentSubject = careerManagerService.AddStudentSubject(newStudentSubject);

            Assert.NotNull(studentSubject);
            Assert.True(studentSubject.IdStudentSubject > 0);
        }
        [Fact]
        public void Test_UpdateStudentSubject()
        {
            CareerManagerService careerManagerService = MoqContext();
            var opt = new DbContextOptionsBuilder<FacultadContext>()
               .UseInMemoryDatabase(databaseName: "CareerDB").Options;
            var context = new FacultadContext(opt);
            var  studentSubject1 = new StudentSubject()
            {
                IdCareer = 1,
                IdStudent = 1,
                IdSubject = 1,
                Status = "InProgress",
                Average = 7,
                IdStudentSubject = 1
            };
            var studentSubject = careerManagerService.UpdateStudentStatus(studentSubject1);

            Assert.NotNull(studentSubject);
            Assert.Equal(7, studentSubject.Average);

        }


        private static CareerManagerService MoqContext()
        {
            var opt = new DbContextOptionsBuilder<FacultadContext>()
                .UseInMemoryDatabase(databaseName: "CareerDB").Options;
            var context = new FacultadContext(opt);
            CareerManagerService careerManagerService = new CareerManagerService(context);
            return careerManagerService;
        }
    }
}
