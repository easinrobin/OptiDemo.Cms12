using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptiDemo.Cms12.Models.Pages;

namespace OptiDemo.Cms12.Controllers.Pages
{
    public class HomeController : PageController<HomePage>
    {
        public IActionResult Index(HomePage model)
        {
            return View(model);
        }
    }
}
