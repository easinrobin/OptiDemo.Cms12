using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using OptiDemo.Cms12.Models.Blocks;
using OptiDemo.Cms12.Models.Pages;

namespace OptiDemo.Cms12.Business.Rendering
{
    [ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(PrimaryBanner), new TemplateModel
            {
                Name = "PrimaryBanner-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/Shared/Banner/PrimaryBanner.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(BestRoomCards), new TemplateModel
            {
                Name = "BestRoomCards-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/Shared/Cards/BestRoomCards.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(RoomsPage), new TemplateModel
            {
                Name = "RoomCard-Default",
                AvailableWithoutTag = false,
                Tags = new[] { "RoomCard" },
                Inherit = true,
                TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/Shared/Cards/RoomCard.cshtml"
            });
        }
    }
}
