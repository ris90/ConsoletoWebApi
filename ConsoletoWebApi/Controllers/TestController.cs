using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebApi.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public int Get()
        {

            return 187;
        }

        public int Get1()
        {

            return 187;
        }


    }
}
