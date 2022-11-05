using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      //  [Route("api/get-all")]
        public string GetAll()
        {
            return "Ok Here is your all Data.\n";
        }

       // [Route("api/get-city")]
        public string GetCity()
        {
            return "All the Cities are There. \n";
        }
    }
}
