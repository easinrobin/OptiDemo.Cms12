using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Pages
{
    [ContentType(DisplayName = "Rooms content page", GUID = "E23D3C7D-BEAD-4B7A-8AB6-DC9D119AFAF8", GroupName = "Rooms content")]
    public class RoomsPage : PageData
    {
        [Display(Name = "Banner image", GroupName = SystemTabNames.Content, Order = 5)]
        public virtual ContentArea? BannerImage { get; set; }

        [Display(Name = "Room title", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string? RoomTitle { get; set; }

        [Display(Name = "Short description", GroupName = SystemTabNames.Content, Order = 15)]
        public virtual string? RoomShortDescription { get; set; }

        [Display(Name = "Room description", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString? RoomDescription { get; set; }

        [Display(Name = "Room rent", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual double RoomRent { get; set; }

        [Display(Name = "Primary image", GroupName = SystemTabNames.Content, Order = 40)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? RoomPrimaryImage { get; set; }

        [Display(Name = "Room rent unit", GroupName = SystemTabNames.Content, Order = 50)]
        [SelectOne(SelectionFactoryType = typeof(RoomRentUnitsFactory))]
        public virtual string? RoomRentUnit { get; set; }

        private class RoomRentUnitsFactory : ISelectionFactory
        {
            public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
            {
                return new ISelectItem[] {
                    new SelectItem() { Text = "Per Night", Value = "/Night" },
                    new SelectItem() { Text = "Per Day", Value = "/Day" },
                };
            }
        }
    }
}
