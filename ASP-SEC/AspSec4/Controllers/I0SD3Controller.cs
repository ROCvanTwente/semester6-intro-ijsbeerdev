using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspSec4.Controllers
{
    [Authorize(Roles = "I0SD3")]
    public class I0SD3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
