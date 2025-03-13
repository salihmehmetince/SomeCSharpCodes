using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication1.Web.TagHelpers
{
    public class ItalicTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<i style='color:yellow;'>");
            output.PostContent.SetHtmlContent("</i>");
        }
    }
}
