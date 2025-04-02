using AspSec01.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspSec01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string inputText, int key, string action)
        {
            string result = "";

            if (action == "encrypt")
            {
                result = EncryptionFunctions.Encrypt(inputText, key);
            }
            else if (action == "decrypt")
            {
                result = EncryptionFunctions.Decrypt(inputText, key);
            }

            ViewBag.ResultText = result;
            return View();
        }
    }
}
