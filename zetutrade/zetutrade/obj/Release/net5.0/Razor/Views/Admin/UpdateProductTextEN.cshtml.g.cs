#pragma checksum "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c71f59bba25f7efaea36949053f3da3eb29ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateProductTextEN), @"mvc.1.0.view", @"/Views/Admin/UpdateProductTextEN.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c71f59bba25f7efaea36949053f3da3eb29ba8", @"/Views/Admin/UpdateProductTextEN.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308475e880d8dc6236fd9c65b3b931004f90500b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateProductTextEN : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<zetutrade_Model.Models.ProductText>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml"
  
    ViewData["Title"] = "UpdateProductTextEN";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header row no-gutters py-4"">
    <div class=""col-12 col-sm-12 text-center text-sm-left mb-0"">
        <span class=""text-uppercase page-subtitle"">Zetu Trade</span>
        <h3 class=""page-title"">İngilizce Text Güncelle</h3>
    </div>

</div>
");
#nullable restore
#line 15 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml"
 using (Html.BeginForm("UpdateProductText", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""main-content-container container-fluid px-12"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12"">
                <div class=""card card-small mb-9"">
                    <div class=""card-body"">
                        ");
#nullable restore
#line 22 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml"
                   Write(Html.TextBoxFor(m => m.productTextID, new { @class = "invisible" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 23 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml"
                   Write(Html.TextBoxFor(m => m.productID, new { @class = "invisible" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        <label>Ürün Adı</label>\r\n                        ");
#nullable restore
#line 25 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml"
                   Write(Html.TextBoxFor(m => m.productName, new { @class = "form-control form-control-lg mb-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label>Ürün Açıklaması</label>\r\n                        ");
#nullable restore
#line 27 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml"
                   Write(Html.TextAreaFor(m => m.productDescription, new { @class = "form-control form-control-lg mb-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <br /><br />
                        <button class=""btn btn-sm btn-accent ml-auto"">
                            <i class=""material-icons"">file_copy</i> Güncelle
                        </button>
                    </div>
                </div>
            </div>

        </div>
    </div>
");
#nullable restore
#line 39 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateProductTextEN.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<zetutrade_Model.Models.ProductText> Html { get; private set; }
    }
}
#pragma warning restore 1591
