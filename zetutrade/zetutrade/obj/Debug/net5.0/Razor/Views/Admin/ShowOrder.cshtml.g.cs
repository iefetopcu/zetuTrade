#pragma checksum "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9b08e239401f9c4a5e0a89ad433012d3ae478d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowOrder), @"mvc.1.0.view", @"/Views/Admin/ShowOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9b08e239401f9c4a5e0a89ad433012d3ae478d4", @"/Views/Admin/ShowOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308475e880d8dc6236fd9c65b3b931004f90500b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ShowOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<zetutrade_Model.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewOffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
  
    ViewData["Title"] = "ShowOrder";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header row no-gutters py-4"">
    <div class=""col-12 col-sm-12 text-center text-sm-left mb-0"">
        <span class=""text-uppercase page-subtitle"">Sipari?? Kontrol??</span>       
    </div>
</div>
<hr />
<div class=""row"">
    <div class=""col-lg-3"">
        <h5>??r??n ??smi</h5>
        <h5>Ad Soyad</h5>
        <h5>E-Mail</h5>
        <h5>Sipari?? Zaman??</h5>
        <h5>Sipari?? Adresi</h5>
    </div>
    <div class=""col-lg-9"">
        <h5> : ");
#nullable restore
#line 22 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
          Write(ViewBag.productname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5> : ");
#nullable restore
#line 23 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
          Write(Model.orderNameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5> : ");
#nullable restore
#line 24 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
          Write(Model.orderEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5> : ");
#nullable restore
#line 25 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
          Write(Model.ordertime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5> : ");
#nullable restore
#line 26 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
          Write(Model.orderAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
    </div>
    <hr />
</div>
<hr />
<div class=""page-header row no-gutters py-4"">
    <div class=""col-12 col-sm-12 text-center text-sm-left mb-0"">
        <span class=""text-uppercase page-subtitle"">Teklif Olu??tur</span>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b08e239401f9c4a5e0a89ad433012d3ae478d46451", async() => {
                WriteLiteral("\r\n            <input type=\"number\" name=\"orderID\"");
                BeginWriteAttribute("value", " value=\"", 1214, "\"", 1236, 1);
#nullable restore
#line 39 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
WriteAttributeValue("", 1222, Model.orderID, 1222, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""invisible"" required /><br />
            <div class=""row"">
                <div class=""col-lg-3"">
                    <h5>??r??n Adeti</h5><br />
                    <h5>??r??n Fiyat?? $ </h5><br />
                    <h5>Nakliye Toplam ??creti $ </h5><br />
                    <h5>??ndirim (Varsa) % </h5><br />
                </div>
                <div class=""col-lg-9"">
                    <input type=""number"" name=""orderNumber""");
                BeginWriteAttribute("value", " value=\"", 1683, "\"", 1709, 1);
#nullable restore
#line 48 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\ShowOrder.cshtml"
WriteAttributeValue("", 1691, Model.orderNumber, 1691, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" required /><br />
                    <input type=""number"" name=""productPrice"" class=""form-control"" required /><br />
                    <input type=""number"" name=""shippingPrice"" class=""form-control"" required /><br />

                    <input type=""number"" name=""discount"" min=""0"" max=""100"" step=""0.01"" class=""form-control"" /><br />
                    <br />
                    <input type=""submit"" value=""Teklif Olu??tur"" class=""btn btn-primary"" style=""width:100%!important;"" />
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<zetutrade_Model.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
