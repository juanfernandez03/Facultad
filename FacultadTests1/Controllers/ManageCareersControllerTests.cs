using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facultad.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Facultad.Interface;
using Microsoft.Extensions.Logging;

namespace Facultad.Controllers.Tests
{
    [TestClass()]
    public class ManageCareersControllerTests
    {
        [TestMethod()]
        public void GetAllStudentSubjectTest()
        {
            Mock<IManageCareer> postRepositoryMock = new Mock<IManageCareer>();
            Mock<ILogger<ManageCareersController>> mock = new Mock<ILogger<ManageCareersController>>();


            ManageCareersController controller = new ManageCareersController(mock,postRepositoryMock.Object);

            postRepositoryMock.Setup(it => it.Get(It.IsAny<int?>()).Returns(new Post() { //here what you need to build your post object })

        var result = controller.GetPost(1);

            Assert.That(result, Is.Not.Null, "Unexpected null result");

            var retrievedPostContent = result as OkNegotiatedContentResult<Post>;
            Assert.That(retrievedPostContent, Is.Not.Null, "Unexpected null retrievedPost");
            var retrievedPost = result.Content;
            Assert.That(retrievedPost.Id, Is.EqualTo(1), "retrievedPost.Id is unexpected")
    }
        Assert.Fail();
        }
    }
}