using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("message")]
        public Task<string> GetMessage(string userName)
        {
            return Task.FromResult($"Hello {userName}");
        }

        [HttpGet("{userName}/example")]
        public Task<Wrapper> GetExample(string userName)
        {
            var w = new Wrapper
            {
                MyString = $"Example {userName}"
            };

            return Task.FromResult(w);
        }
    }

    public class Wrapper
    {
        public string MyString { get; set; }
    }
}
