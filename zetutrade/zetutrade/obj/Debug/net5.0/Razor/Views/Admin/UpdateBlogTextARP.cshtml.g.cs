#pragma checksum "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d19da7ddf1fd1ecf7efd117bd4ae70411f179197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateBlogTextARP), @"mvc.1.0.view", @"/Views/Admin/UpdateBlogTextARP.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d19da7ddf1fd1ecf7efd117bd4ae70411f179197", @"/Views/Admin/UpdateBlogTextARP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308475e880d8dc6236fd9c65b3b931004f90500b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateBlogTextARP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<zetutrade_Model.Models.BlogText>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml"
  
    ViewData["Title"] = "UpdateBlogTextARP";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
<script src=""https://cdn.ckeditor.com/4.15.1/full/ckeditor.js""></script>
<div class=""page-header row no-gutters py-4"">
    <div class=""col-12 col-sm-12 text-center text-sm-left mb-0"">
        <span class=""text-uppercase page-subtitle"">Zetu Trade</span>
        <h3 class=""page-title"">Türkçe Text Güncelle</h3>
    </div>

</div>
");
#nullable restore
#line 16 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml"
 using (Html.BeginForm("UpdateBlogText", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
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
#line 23 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml"
                   Write(Html.TextBoxFor(m => m.BlogTextID, new { @class = "invisible" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        <label>Blog Başlığı</label>\r\n                        ");
#nullable restore
#line 25 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml"
                   Write(Html.TextBoxFor(m => m.blogTitle, new { @class = "form-control form-control-lg mb-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label>Blog SpotText</label>\r\n                        ");
#nullable restore
#line 27 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml"
                   Write(Html.TextAreaFor(m => m.blogSpotText, new { @class = "form-control form-control-lg mb-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <textarea name=\"blogDescription\">");
#nullable restore
#line 28 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml"
                                                    Write(Model.blogDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea><br /><br />
                        <script>
                            CKEDITOR.replace('blogDescription');
                        </script>
                        <br />
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
#line 42 "C:\Users\EfeTopcu\source\repos\zetutrade\zetutrade\Views\Admin\UpdateBlogTextARP.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"//code.jquery.com/ui/1.12.0/themes/base/jquery-ui.css\">\r\n<script src=\"https://code.jquery.com/jquery-1.12.4.js\"></script>\r\n<script src=\"https://code.jquery.com/ui/1.12.0/jquery-ui.js\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<zetutrade_Model.Models.BlogText> Html { get; private set; }
    }
}
#pragma warning restore 1591
