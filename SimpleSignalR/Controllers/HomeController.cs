using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace SimpleSignalR.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index([FromServices] IHostingEnvironment env) => 
            PhysicalFile(Path.Combine(env.WebRootPath, "index.html"), "text/html");
    }
}