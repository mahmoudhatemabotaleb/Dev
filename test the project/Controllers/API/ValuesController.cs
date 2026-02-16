using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test_the_project.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
