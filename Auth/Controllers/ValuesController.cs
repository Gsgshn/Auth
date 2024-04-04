using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<string> _values = new List<string>
        {
            "safs",
            "asdad"
        };
        [HttpGet]
        public IEnumerable<string> Index() 
        {
        return _values;
        }

        [HttpGet("fruit/{id}")]
        public ActionResult<string> View(int id)
        {
            if (id >= 0 && id < _values.Count)
            {
                return _values[id];
            }
            return NotFound();
        }

    }
}
