using OptiDemo.Cms12.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Pages
{
    [ContentType(
        DisplayName = "Homepage",
        GUID = "1903741B-0624-40D9-9642-069C9121072C",
        GroupName = "Specialized content")]
    public class HomePage : BaseContentPage
    {
        [Display(Name = "Banner image", GroupName = SystemTabNames.Content, Order = 10)]
        [AllowedTypes(typeof(PrimaryBanner))]
        public virtual ContentArea? BannerImage { get; set; }

        [Display(Name = "Best rooms", GroupName = SystemTabNames.Content, Order = 20)]
        [AllowedTypes(AllowedTypes = new[] { typeof(BestRoomCards) })]
        public virtual ContentArea? BestRoomCards { get; set; }
    }
}
