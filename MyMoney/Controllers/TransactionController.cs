using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using MyMoney.Logic;
using MyMoney.Models;

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

        [Route("api/transaction/get/types")]
        [HttpGet]
        public IHttpActionResult GetTypes()
        {
            return Ok(JsonConvert.SerializeObject(TransactionLogic.GetTypes()));
        }

        [Route("api/transaction/put")]
        [HttpPut]
        public IHttpActionResult Put(Transaction transaction)
        {
            int status = TransactionLogic.Put(transaction);
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