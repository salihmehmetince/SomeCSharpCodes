using Microsoft.AspNetCore.Razor.TagHelpers;
using WebApplication1.Web.Models;

namespace WebApplication1.Web.TagHelpers
{
    public class ProductShowTagHelper:TagHelper
    {
        public Product product { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "Alakazam";
            output.PreContent.SetHtmlContent("<tilt>");
            output.Content.SetHtmlContent(
        @$"<ul class='list-group'>
             <li class='list-group-item'>{product.Id}</li>       
             <li class='list-group-item'>{product.Name}</li>       
             <li class='list-group-item'>{product.Price}</li>       
             <li class='list-group-item'>{product.Color}</li>       
            </ul>");
            output.PostContent.SetHtmlContent("<odl>");

        }
    }
}
