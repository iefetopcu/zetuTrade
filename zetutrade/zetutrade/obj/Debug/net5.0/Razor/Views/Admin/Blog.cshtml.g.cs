#pragma checksum "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd1afb7579d07d9fc7068222c66f8d4a6f4ccf21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Blog), @"mvc.1.0.view", @"/Views/Admin/Blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1afb7579d07d9fc7068222c66f8d4a6f4ccf21", @"/Views/Admin/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308475e880d8dc6236fd9c65b3b931004f90500b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<zetutrade_Model.Models.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TextAddBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
  
    ViewData["Title"] = "Blog";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header row no-gutters py-4"">
    <div class=""col-12 col-sm-6 text-center text-sm-left mb-0"">
        <span class=""text-uppercase page-subtitle"">Zetu Trade</span>
        <h3 class=""page-title"">Blog Y??netimi</h3>
    </div>
    <div class=""col-12 col-sm-6 text-center text-sm-left mb-0"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1afb7579d07d9fc7068222c66f8d4a6f4ccf214920", async() => {
                WriteLiteral("Blog Gir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
     if (Model.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
         foreach (var posts in Model)
        {
            var blogtext = posts.BlogTexts.FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 col-sm-12 mb-4\">\r\n                <div class=\"card card-small card-post card-post--1\">\r\n                    <div class=\"card-post__image\"");
            BeginWriteAttribute("style", " style=\"", 913, "\"", 964, 4);
            WriteAttributeValue("", 921, "background-image:", 921, 17, true);
            WriteAttributeValue(" ", 938, "url(\'/", 939, 7, true);
#nullable restore
#line 25 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
WriteAttributeValue("", 945, posts.blogPhoto, 945, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 961, "\');", 961, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1063, 1);
#nullable restore
#line 26 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
WriteAttributeValue("", 1001, Url.Action("DeleteBlog", "Admin" , new { id = posts.blogID }), 1001, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Bu ????eri??i Silmek ??stedi??inize Emin Misiniz?')""><i class=""material-icons badge badge-pill badge-secondary"" style=""color:white; padding:10px;"">X</i></a>
                        <p class=""card-post__category badge badge-pill badge-dark"">Blog </p>
                        <div class=""card-post__author d-flex"">
                           
                        </div>
                    </div>
                    <div class=""card-body"">
                        <h5 class=""card-title"">
                            <a class=""text-fiord-blue""");
            BeginWriteAttribute("href", " href=\"", 1638, "\"", 1707, 1);
#nullable restore
#line 34 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
WriteAttributeValue("", 1645, Url.Action("UpdateBlog", "Admin" , new { id = posts.blogID }), 1645, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
                                                                                                                        Write(blogtext.blogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h5>\r\n                        <span class=\"text-muted\">Yay??nlanma Tarihi : ");
#nullable restore
#line 36 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
                                                                Write(posts.releasetime.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1afb7579d07d9fc7068222c66f8d4a6f4ccf219935", async() => {
                WriteLiteral("Text Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
                                                      WriteLiteral(posts.blogID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-12\">\r\n            <h3 class=\"alert-danger text-center\" style=\"padding:20px;\">Herhangi bir blog yaz??s?? bulunmuyor !</h3>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\Blog.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<zetutrade_Model.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
