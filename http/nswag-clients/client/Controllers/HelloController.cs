using Kenny;
using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IClient _serviceClient;

        public HelloController(IClient serviceClient)
        {
            _serviceClient = serviceClient;
        }

        [HttpGet("{userName}/example")]
        public async Task<string> GetExample(string userName)
        {

            var s = await _serviceClient.ExampleAsync(userName);
            return s.MyString;
        }
    }
}
