using Facultad.Data;
using Facultad.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facultad.Services.Tests
{
    [TestClass()]
    public class CareerManagerServiceTests
    {
        [TestMethod()]
        public void AddStudentStatusTest()
        {

            var mockRepo = new Mock<IBrainstormSessionRepository>();

            FacultadContext facultadContext = new FacultadContext();
            StudentSubject studentSubject = new StudentSubject();
            studentSubject.IdCareer = 2;
            studentSubject.IdStudent = 2;
            studentSubject.IdSubject = 2;
            studentSubject.Status = "Finish";
            studentSubject.Average = 6;
            var response = 
            Assert.Fail();
        }
    }
}