#pragma checksum "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a02f8181709a56c611acc956e262279c6a45aac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\_ViewImports.cshtml"
using zetutrade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\_ViewImports.cshtml"
using zetutrade.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a02f8181709a56c611acc956e262279c6a45aac2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308475e880d8dc6236fd9c65b3b931004f90500b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layimages/ihracat.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layimages/ecopack.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layimages/mobilya.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layimages/tekstil.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
  
    ViewData["Title"] = localizer["home_title"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"home-content\">\r\n        <div class=\"cat-offers\">\r\n            <div class=\"brand-title\">\r\n                <span>");
#nullable restore
#line 13 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                 Write(localizer["product_title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                ");
#nullable restore
#line 14 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <br />\r\n                ");
#nullable restore
#line 17 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
           Write(localizer["product_link"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 515, "\"", 551, 1);
#nullable restore
#line 20 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
WriteAttributeValue("", 522, Url.Action("Urunler","Home"), 522, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue\">");
#nullable restore
#line 20 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                                        Write(localizer["product_title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"home-content\">\r\n        <div class=\"cat-offers\">\r\n            <div class=\"brand-title\">\r\n                <span>");
#nullable restore
#line 30 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                 Write(localizer["services_title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\" style=\"margin-bottom:20px;\">\r\n                    <div class=\"cat-sec-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a02f8181709a56c611acc956e262279c6a45aac28062", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"cat-desc\">\r\n                            <div class=\"cat-inner\">\r\n                                <div class=\"cat-title\">");
#nullable restore
#line 38 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                  Write(localizer["export_consultancy"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1339, "\"", 1376, 1);
#nullable restore
#line 39 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
WriteAttributeValue("", 1346, Url.Action("Iletisim","Home"), 1346, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue\">");
#nullable restore
#line 39 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                                                         Write(localizer["getcontact"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-4"" style=""margin-bottom:20px;"">
                    <div class=""cat-sec-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a02f8181709a56c611acc956e262279c6a45aac210728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"cat-desc\">\r\n                            <div class=\"cat-inner\">\r\n                                <div class=\"cat-title\">");
#nullable restore
#line 50 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                  Write(localizer["eco_pack"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1975, "\"", 2012, 1);
#nullable restore
#line 51 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
WriteAttributeValue("", 1982, Url.Action("Iletisim","Home"), 1982, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue\">");
#nullable restore
#line 51 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                                                         Write(localizer["getcontact"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"" style=""margin-bottom:20px;"">
                    <div class=""cat-sec-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a02f8181709a56c611acc956e262279c6a45aac213383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"cat-desc\">\r\n                            <div class=\"cat-inner\">\r\n                                <div class=\"cat-title\">");
#nullable restore
#line 61 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                  Write(localizer["furniture_and_decoration"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2625, "\"", 2662, 1);
#nullable restore
#line 62 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
WriteAttributeValue("", 2632, Url.Action("Iletisim","Home"), 2632, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue\">");
#nullable restore
#line 62 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                                                         Write(localizer["getcontact"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"" style=""margin-bottom:20px;"">
                    <div class=""cat-sec-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a02f8181709a56c611acc956e262279c6a45aac216054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"cat-desc\">\r\n                            <div class=\"cat-inner\">\r\n                                <div class=\"cat-title\">");
#nullable restore
#line 72 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                  Write(localizer["textile"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3258, "\"", 3295, 1);
#nullable restore
#line 73 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
WriteAttributeValue("", 3265, Url.Action("Iletisim","Home"), 3265, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue\">");
#nullable restore
#line 73 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                                                         Write(localizer["getcontact"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </div>
                    </div>
                </div>


            </div>


        </div>
    </div>
</div>






<div class=""rec-blog"">
    <div class=""container"">
        <div class=""rec-blog-inner"">
            <div class=""blog-title"">
                <span>");
#nullable restore
#line 96 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                 Write(localizer["blog_title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            ");
#nullable restore
#line 98 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("HomeBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row text-center\">\r\n    <div class=\"col-lg-12\">\r\n        <br />\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3926, "\"", 3963, 1);
#nullable restore
#line 106 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
WriteAttributeValue("", 3933, Url.Action("Iletisim","Home"), 3933, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue\">");
#nullable restore
#line 106 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Home\Index.cshtml"
                                                                 Write(localizer["getcontact"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n\r\n</div>\r\n<br />\r\n<br />");
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
