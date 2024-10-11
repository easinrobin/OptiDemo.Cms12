using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptiDemo.Cms12.Models.Pages;

namespace OptiDemo.Cms12.Controllers.Pages
{
    public class RoomsPageController : PageController<RoomsPage>
    {
        public IActionResult Index(RoomsPage currentPage)
        {
            return View("~/Views/RoomsPage/RoomDetails.cshtml", currentPage);
        }
    }
}
