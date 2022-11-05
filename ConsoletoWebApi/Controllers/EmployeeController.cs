using ConsoletoWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ConsoletoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetEmployee()
        {
            return new List<EmployeeModel>()
            {
            new EmployeeModel(){
                ID = 187,
                Name = "Md. Rifatul Islam."
            },

              new EmployeeModel()   {
                    ID = 221,
                Name = "Md. Abid Hasan Naim."
            }
                };
        }

        [Route("{id}")]
        public IActionResult GetEmplyee(int id)
        {
            if( id == 0)
            {
                return NotFound();
            }

            return Ok(new EmployeeModel () { ID = id , Name = "Tanvir" });
        }
    }
}
