using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptiDemo.Cms12.Models.Pages;

namespace OptiDemo.Cms12.Controllers.Pages
{
    public class GeneralPageController : PageController<GeneralTextPage>
    {
        public IActionResult Index(GeneralTextPage currentPageModel)
        {
            return View(currentPageModel);
        }
    }
}
