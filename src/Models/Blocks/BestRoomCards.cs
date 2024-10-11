using OptiDemo.Cms12.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Blocks
{
    [ContentType(DisplayName = "Best room cards", GUID = "932A2BB8-56DD-4162-A8EE-F2AE73437DEE", GroupName = "Room link cards")]
    public class BestRoomCards : BaseBlockData
    {
        [Display(Name = "Card title", GroupName = SystemTabNames.Content, Order = 5)]
        public virtual string? CardTitle { get; set; }

        [Display(Name = "Rooms link", GroupName = SystemTabNames.Content, Order = 10)]
        [AllowedTypes(AllowedTypes = new[] { typeof(RoomsPage) })]
        public virtual ContentArea? RoomsLink { get; set; }
    }
}
