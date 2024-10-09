using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptiDemo.Cms12.Models.Pages;

namespace OptiDemo.Cms12.Controllers.Pages
{
    public class GeneralPageController : PageController<GeneralPage>
    {
        public IActionResult Index(GeneralPage currentPageModel)
        {
            return View(currentPageModel);
        }
    }
}
