using ConsoletoWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        //[BindProperty]
        //public CountryModel obj { get; set; }

        //[HttpPost("")]
        //public IActionResult GetAll()
        //{
        //    return Ok($"Country name is {this.obj.country} and Sub {this.obj.sub}");
        //}

        [HttpPost("/test")]

        public IActionResult GetMyCountry(CountryModel country)
        {
            return Ok($"Name Of My Country is {country.country}");
        }
    }
}
