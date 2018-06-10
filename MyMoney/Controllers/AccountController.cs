using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using MyMoney.Logic;
using MyMoney.Models;

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

        [Route("api/account/put")]
        [HttpPut]
        public IHttpActionResult Put(Account account)
        {
            int status = AccountLogic.Put(account);
            if (status == 0)
            {
                return BadRequest("0");
            }
            else
            {
                return Ok(status);
            }
        }
    }
}