using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Blocks
{
    [ContentType(DisplayName = "Primary banner", GUID = "B265D160-C321-482A-9D9A-26117F5D4C8A", GroupName = "Banner")]
    public class PrimaryBanner : BaseBlockData
    {
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string? Title { get; set; }

        [Display(Name = "Subtitle", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string? Subtitle { get; set; }

        [Display(Name = "Banner image", GroupName = SystemTabNames.Content, Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image {  get; set; }
    }
}
