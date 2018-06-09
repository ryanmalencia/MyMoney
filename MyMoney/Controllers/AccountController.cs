using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using MyMoney.Logic;

namespace MyMoney.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AccountController : ApiController
    {
        private readonly AccountLogic AccountLogic = new AccountLogic();

        [Route("api/account/get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(JsonConvert.SerializeObject(AccountLogic.Get()));
        }
    }
}