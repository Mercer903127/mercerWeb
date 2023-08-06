using mercer_web.Entity;
using Microsoft.AspNetCore.Mvc;

namespace mercer_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {
        private readonly ILogger<UserInfoController> _logger;

        public UserInfoController(ILogger<UserInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<UserInfo> Get()
        {
            List<UserInfo> infos = new List<UserInfo>();

            UserInfo info = new UserInfo();
            infos = dummyData();
            //

            //

            return infos;
        }

        private List<UserInfo> dummyData()
        {
            List<UserInfo> infos = new List<UserInfo>();

            UserInfo info = new UserInfo();
            info.id = "01";
            info.Name = "Dummy01";
            info.Email = "abc@efg.com";
            infos.Add(info);
            info.id = "02";
            info.Name = "Dummy02";
            info.Email = "123@efg.com";
            infos.Add(info);
            info.id = "03";
            info.Name = "Dummy03";
            info.Email = "456@efg.com";
            infos.Add(info);

            return infos;
        }

    }
}
