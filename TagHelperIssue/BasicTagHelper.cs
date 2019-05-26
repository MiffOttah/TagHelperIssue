using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TagHelperIssue
{
    [HtmlTargetElement("span", Attributes = "test-label")]
    public class BasicTagHelper : TagHelper
    {
        [HtmlAttributeName("test-label")]
        public string Label { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent($"<b>{WebUtility.HtmlEncode(Label)}</b> ");
        }
    }
}
