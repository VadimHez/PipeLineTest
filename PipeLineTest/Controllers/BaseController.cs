using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PipeLineTest.Controllers
{
    public class BaseController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetData()
        {
            return Ok("BaseController - GetData - works");
        }
    }
}