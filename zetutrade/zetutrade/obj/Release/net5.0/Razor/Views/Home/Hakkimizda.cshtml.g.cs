#pragma checksum "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Home\Hakkimizda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6948ccf4e893d6701a044ce9027079ed6f5812f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hakkimizda), @"mvc.1.0.view", @"/Views/Home/Hakkimizda.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\_ViewImports.cshtml"
using zetutrade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\_ViewImports.cshtml"
using zetutrade.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Home\Hakkimizda.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6948ccf4e893d6701a044ce9027079ed6f5812f", @"/Views/Home/Hakkimizda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308475e880d8dc6236fd9c65b3b931004f90500b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hakkimizda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Home\Hakkimizda.cshtml"
  
    ViewData["Title"] = localizer["about_title"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-title\">\r\n    <div class=\"container\">\r\n        <div class=\"page-title-inner\">\r\n            <h3>");
#nullable restore
#line 12 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Home\Hakkimizda.cshtml"
           Write(localizer["about_title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"breadcumb\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6948ccf4e893d6701a044ce9027079ed6f5812f4584", async() => {
#nullable restore
#line 13 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Home\Hakkimizda.cshtml"
                                                                           Write(localizer["home_title"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<span> / </span><span>");
#nullable restore
#line 13 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Home\Hakkimizda.cshtml"
                                                                                                                             Write(localizer["about_title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            <div class=\"clearfix\"></div>\r\n        </div>\r\n        <div class=\"row\" style=\"margin-top:30px; margin-bottom:30px; padding:20px;\">\r\n            <div class=\"col-lg-12\">\r\n                <p>");
#nullable restore
#line 18 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Home\Hakkimizda.cshtml"
              Write(localizer["about_description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591