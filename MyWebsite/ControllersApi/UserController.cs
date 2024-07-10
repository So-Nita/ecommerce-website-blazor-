using System.Web.Http;
namespace MyWebApplication.ControllersApi
{
    public class UserController : ApiController
    {
        [HttpGet]
        public object GetAsync()
        {
            return new object();
        }
    }
}
