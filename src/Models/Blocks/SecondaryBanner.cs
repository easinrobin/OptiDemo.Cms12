using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Blocks
{
    [ContentType(
        DisplayName = "Secondary Banner", 
        GUID = "DB0C811B-C642-4900-A50F-A8080AD58DE4", 
        GroupName = "Banner")]
    public class SecondaryBanner : BaseBlockData
    {
        [Display(Name = "Page title", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string? PageTitle { get; set; }

        [Display(Name = "Sub title", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string? SubTitle { get; set; }

        [Display(Name = "Banner image", GroupName = SystemTabNames.Content, Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
