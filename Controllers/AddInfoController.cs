using mercer_web.Entity;
using Microsoft.AspNetCore.Mvc;

namespace mercer_web.Controllers
{
    public class AddInfoController : ControllerBase
    {
        private readonly ILogger<AddInfoController> _logger;

        public AddInfoController(ILogger<AddInfoController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{id, name, email}")]
        public int addInfo(string id, string name, string email)
        {
            int resultcount = 0;
            //
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(email);
            //

            return resultcount;
        }
    }
}
