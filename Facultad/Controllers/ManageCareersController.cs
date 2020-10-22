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
        private readonly CareerManagerService _careerManagerService;
        public ManageCareersController(ILogger<ManageCareersController> logger, CareerManagerService careerManagerService)
        {
            _logger = logger;
            _careerManagerService = careerManagerService;
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
                return _careerManagerService.AddStudentStatus(value);
            }
            catch (Exception e)
            {
                _logger.LogError("Error adding AddStudentSubject " + e.Message);
                throw;
            }
        }

    }
}
