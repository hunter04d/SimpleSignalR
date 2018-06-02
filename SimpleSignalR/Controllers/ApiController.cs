using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleSignalR.Models;

namespace SimpleSignalR.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet, Route("messages")]
        public ActionResult<IEnumerable<Message>> Messages([FromServices] AppDbContext appDbContext) =>
            appDbContext.Messages;
    }
}