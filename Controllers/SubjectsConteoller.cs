using CustomerPro.Data.ViewModel;
using CustomerPro.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        public SubjectService _customerService;

        public SubjectsController(SubjectService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("add-Subject")]
        public IActionResult AddSubject([FromBody] SubjectVM book)
        {
            _customerService.AddSubject(book);
            return Ok();
        }

		[HttpGet("Get-all-Subjects")]
		public IActionResult GetAllSubjects()
		{
			var allMovies = _customerService.GetAllSubjects();
			return Ok(allMovies);
		}

        [HttpGet("Get-Subject-By-Id/{Id}")]
        public IActionResult GetSubjectById(int Id)
        {
            var Movie = _customerService.GetSubjectById(Id);
            return Ok(Movie);
        }

    }
}
