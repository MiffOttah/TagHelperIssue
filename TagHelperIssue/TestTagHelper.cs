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
    [HtmlTargetElement("input", Attributes = "asp-for,test-label")]
    public class TestTagHelper : InputTagHelper
    {
        public TestTagHelper(IHtmlGenerator generator) : base(generator)
        {
        }

        [HtmlAttributeName("test-label")]
        public string Label { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.PreContent.SetHtmlContent($"<b>{WebUtility.HtmlEncode(Label)}</b> ");
            output.PostContent.SetHtmlContent($" <i>({WebUtility.HtmlEncode(For.Name)})</i>"); // access information from the input tag
        }
    }
}
