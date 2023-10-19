using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ImageApi.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("api/[controller]")]
        public string Index()
        {
            return "Hi";
        }

    }
}