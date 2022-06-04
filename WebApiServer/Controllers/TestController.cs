using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiServer.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/Test/{teamId}/Channels/{channelId}")]
        public IHttpActionResult Get(string teamId, string channelId)
        {
            return Ok(new
            {
                teamId,
                channelId
            });
        }

        [HttpDelete]
        [Route("api/Test/{teamId}/Channels/{channelId}")]
        public IHttpActionResult Delete(string teamId, string channelId)
        {
            return Ok(new
            {
                teamId,
                channelId
            });
        }
    }
}
