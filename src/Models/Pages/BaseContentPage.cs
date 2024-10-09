using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Pages
{
    public class BaseContentPage : PageData
    {
        [Display(Name = "Page title", GroupName = "SEO", Order = 10)]
        public virtual string? PageTitle { get; set; }

        [Display(Name = "Meta description", GroupName = "SEO", Order = 20)]
        public virtual string? MetaDescription { get; set; }
    }
}
