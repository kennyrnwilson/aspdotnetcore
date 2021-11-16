using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IServiceClient _serviceClient;

        public HelloController(IServiceClient serviceClient)
        {
            _serviceClient = serviceClient;
        }

        [HttpGet("{userName}/example")]
        public Task<string> GetExample(string userName)
        {
            return _serviceClient.GetExample(userName);
        }
    }
}
