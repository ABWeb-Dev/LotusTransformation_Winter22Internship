using Microsoft.AspNetCore.Mvc;

namespace LotusTransformation.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminLogIn()
        {
            return View();
        }
    }
}
