using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Costumers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController: ControllerBase
    {
        [HttpGet, Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "John Doe", "Chandrashekhar Singh" };
        }
    }
}