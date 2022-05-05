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
    public class CategorysController : ControllerBase
    {
        public CategoryService _customerService;

        public CategorysController(CategoryService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("add-Category")]
        public IActionResult AddCategory([FromBody] CategoryVM book)
        {
            _customerService.AddCategory(book);
            return Ok();
        }

		[HttpGet("Get-all-Categorys")]
		public IActionResult GetAllCateogrys()
		{
			var allMovies = _customerService.GetAllCateogrys();
			return Ok(allMovies);
		}
        
        /*
        [HttpGet("Get-all-Results")]
        public IActionResult GetAllResult()
        {
            var allMovies = _customerService.GetAllResult();
            return Ok(allMovies);
        }
        */

        [HttpGet("Get-all-finish")]
        public IActionResult GetResults()
        {
            var allMovies = _customerService.GetResults();
            return Ok(allMovies);
        }

        
        [HttpGet("Get-Category-By-Id/{Id}")]
        public IActionResult GetCategoryById(int Id)
        {
            var Movie = _customerService.GetCategoryById(Id);
            return Ok(Movie);
        }

    }
}
