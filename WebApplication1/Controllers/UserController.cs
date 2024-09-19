using Microsoft.AspNetCore.Mvc;

namespace E-CommerceClothingWebApp.WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public IActionResult Index()
        {
            return View();
        }

    }
}
