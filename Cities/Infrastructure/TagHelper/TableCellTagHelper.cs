using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cities.Infrastructure.TagHelper
{
    [HtmlTargetElement("td", Attributes = "wrap")]
    public class TableCellTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<b></i>");
            output.PostContent.SetHtmlContent("</b></i>");
        }
    }
}
