using Microsoft.AspNetCore.Mvc;
using router.Api;

namespace client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IApiClient _serviceClient;

        public HelloController(IApiClient serviceClient)
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
