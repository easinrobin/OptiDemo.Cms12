using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Pages
{
    [ContentType(
        DisplayName = "GeneralPage",
        GUID = "CFD4B7E3-9F14-478A-931B-B3642B3DA911",
        GroupName = "General content")]
    public class GeneralPage : BaseContentPage
    {
        [Display(Name = "Body", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual XhtmlString? Body { get; set; }

        public virtual ContentArea? BlockReference { get; set; }
    }
}
