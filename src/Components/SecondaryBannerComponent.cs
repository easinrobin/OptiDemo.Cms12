using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptiDemo.Cms12.Models.Blocks;

namespace OptiDemo.Cms12.Components
{
    public class SecondaryBannerComponent : BlockComponent<SecondaryBanner>
    {
        protected override IViewComponentResult InvokeComponent(SecondaryBanner currentContent)
        {
            return View(currentContent);
        }
    }
}
