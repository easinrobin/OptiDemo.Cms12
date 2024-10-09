using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace OptiDemo.Cms12.Models.Media
{
    [ContentType(DisplayName = "Image", GUID = "")]
    [MediaDescriptor(
        ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class BannerImage : ImageData
    {
        [Display(Name = "Alt text")]
        public virtual string? AltText { get; set; }
    }
}
