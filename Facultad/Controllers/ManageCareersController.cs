using Facultad.Interface;
using Facultad.Model;
using Facultad.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facultad.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManageCareersController : ControllerBase
    {
        private readonly ILogger<ManageCareersController> _logger;
        private readonly IManageCareer  _manageCareer;
        public ManageCareersController(ILogger<ManageCareersController> logger, IManageCareer careerManagerService)
        {
            _logger = logger;
            _manageCareer = careerManagerService;
        }

        // POST: api/ManageCareersController
        /// <summary>
        /// Save 
        /// </summary>
        /// <param name="value">StudentSubject</param>
        /// <returns>Return StudentSubjects adding</returns>
        [HttpPost]
        public StudentSubject AddStudentSubject([FromBody] StudentSubject value)
        {
            try
            {
                if (value != null)
                {
                    return _manageCareer.AddStudentSubject(value);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Error adding AddStudentSubject " + e.Message);
                throw;
            }
        }

        // PUT: api/ManageCareersController
        /// <summary>
        /// Update StudentS ubject
        /// </summary>
        /// <param name="value">StudentSubject</param>
        /// <returns>Return StudentSubjects updating</returns>
        [HttpPut]
        public StudentSubject UpdateStudentSubject([FromBody] StudentSubject value)
        {
            try
            {
                if (value != null)
                {
                    return _manageCareer.UpdateStudentStatus(value);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Error updating AddStudentSubject " + e.Message);
                throw;
            }
        }
        // PUT: api/ManageCareersController
        /// <summary>
        /// Update StudentS ubject
        /// </summary>
        /// <param name="value">StudentSubject</param>
        /// <returns>Return StudentSubjects updating</returns>
        [HttpGet]
        public IEnumerable<StudentSubject> GetAllStudentSubject()
        {
            try
            {
                return _manageCareer.GetAllStudentSubject();
            }
            catch (Exception e)
            {
                _logger.LogError("Error get all students AddStudentSubject " + e.Message);
                throw;
            }
        }


    }
}
