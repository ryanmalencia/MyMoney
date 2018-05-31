using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using MyMoney.Interfaces;
using MyMoney.Models;
//using MyMoney.Logic;

namespace MyMoney.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ActivityController : ApiController
    {
        [Route("api/activity/get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Success");
        }
    }
}