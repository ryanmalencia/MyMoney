using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using MyMoney.Logic;

namespace MyMoney.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TransactionController : ApiController
    {
        private readonly TransactionLogic TransactionLogic = new TransactionLogic();

        [Route("api/transaction/get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(JsonConvert.SerializeObject(TransactionLogic.Get()));
        }
    }
}