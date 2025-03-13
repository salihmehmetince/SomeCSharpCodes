using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IO;

namespace WebApplication1.Web.TagHelpers
{
    public class ImageThumbnailTagHelper : TagHelper
    {
        public string imageSRC { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            string fileName = Path.GetFileNameWithoutExtension(imageSRC);
            string extension = Path.GetExtension(imageSRC);
            output.Attributes.SetAttribute("src", $"/images/resized/{fileName}-{width}x{height}{extension}");
        }
    }
}
