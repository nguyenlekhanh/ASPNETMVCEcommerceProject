using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
