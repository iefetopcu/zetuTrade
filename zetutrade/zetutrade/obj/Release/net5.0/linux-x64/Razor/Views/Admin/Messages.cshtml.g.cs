#pragma checksum "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e90b94df79137c1fe39bb6078e2111f8c406f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Messages), @"mvc.1.0.view", @"/Views/Admin/Messages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e90b94df79137c1fe39bb6078e2111f8c406f4", @"/Views/Admin/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308475e880d8dc6236fd9c65b3b931004f90500b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<zetutrade_Model.Models.Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
  
    ViewData["Title"] = "Messages";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header row no-gutters py-4"">
    <div class=""col-12 col-sm-12 text-center text-sm-left mb-0"">
        <span class=""text-uppercase page-subtitle"">Zetu Trade</span>
        <h3 class=""page-title"">Mesaj Yönetimi</h3>
    </div>
   
</div>
<div class=""row"">
");
#nullable restore
#line 15 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-lg-6"">
            <div class=""col-12 col-sm-12 text-center text-sm-left mb-0"">
                <span class=""text-uppercase page-subtitle"" style=""color:darkgreen"">Okunmamış Mesajlar</span>
            </div>
            <hr />
");
#nullable restore
#line 22 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
             foreach (var message in Model)
            {
                if (message.status == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card card-small card-post mb-4\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                              Write(message.subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text text-muted\">");
#nullable restore
#line 29 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                       Write(message.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <div class=""card-footer border-top d-flex"">
                            <div class=""card-post__author d-flex"">

                                <div class=""d-flex flex-column justify-content-center ml-3"">
                                    <span class=""card-post__author-name"">");
#nullable restore
#line 35 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                                    Write(message.nameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <small class=\"text-muted\"><a");
            BeginWriteAttribute("href", " href=\"", 1543, "\"", 1571, 2);
            WriteAttributeValue("", 1550, "mailto:", 1550, 7, true);
#nullable restore
#line 36 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
WriteAttributeValue("", 1557, message.email, 1557, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                                                         Write(message.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - ");
#nullable restore
#line 36 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                                                                              Write(message.createtime.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"my-auto ml-auto\">\r\n                                <a class=\"btn btn-sm btn-white\"");
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1919, 1);
#nullable restore
#line 40 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
WriteAttributeValue("", 1851, Url.Action("ReadMessage", "Admin" , new { id = message.contactID }), 1851, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"far fa-bookmark mr-1\"></i> Okundu\r\n                                </a><a class=\"btn btn-sm btn-white\"");
            BeginWriteAttribute("href", " href=\"", 2071, "\"", 2148, 1);
#nullable restore
#line 42 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
WriteAttributeValue("", 2078, Url.Action("DeleteMessage", "Admin" , new { id = message.contactID }), 2078, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Bu mesajı Silmek İstediğinize Emin Misiniz?')"">
                                    <i class=""far fa-bookmark mr-1""></i> Sil
                                </a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 48 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-lg-6"">
            <div class=""col-12 col-sm-12 text-center text-sm-left mb-0"">
                <span class=""text-uppercase page-subtitle"" style=""color:darkorange"">Okunmuş Mesajlar</span>
            </div>
            <hr />
");
#nullable restore
#line 57 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
             foreach (var message in Model)
            {
                if (message.status == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card card-small card-post mb-4\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 63 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                              Write(message.subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text text-muted\">");
#nullable restore
#line 64 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                       Write(message.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <div class=""card-footer border-top d-flex"">
                            <div class=""card-post__author d-flex"">
                                <div class=""d-flex flex-column justify-content-center ml-3"">
                                    <span class=""card-post__author-name"">");
#nullable restore
#line 69 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                                    Write(message.nameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <small class=\"text-muted\"><a");
            BeginWriteAttribute("href", " href=\"", 3564, "\"", 3592, 2);
            WriteAttributeValue("", 3571, "mailto:", 3571, 7, true);
#nullable restore
#line 70 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
WriteAttributeValue("", 3578, message.email, 3578, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                                                         Write(message.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - ");
#nullable restore
#line 70 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                                                                                                              Write(message.createtime.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"my-auto ml-auto\">\r\n                                <a class=\"btn btn-sm btn-white\"");
            BeginWriteAttribute("href", " href=\"", 3865, "\"", 3942, 1);
#nullable restore
#line 74 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
WriteAttributeValue("", 3872, Url.Action("UnreadMessage", "Admin" , new { id = message.contactID }), 3872, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"far fa-bookmark mr-1\"></i> Okunmadı\r\n                                </a><a class=\"btn btn-sm btn-white\"");
            BeginWriteAttribute("href", " href=\"", 4096, "\"", 4173, 1);
#nullable restore
#line 76 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
WriteAttributeValue("", 4103, Url.Action("DeleteMessage", "Admin" , new { id = message.contactID }), 4103, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Bu mesajı Silmek İstediğinize Emin Misiniz?')"">
                                    <i class=""far fa-bookmark mr-1""></i> Sil
                                </a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 82 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 85 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-12\">\r\n            <h3 class=\"alert-danger text-center\" style=\"padding:20px;\">Herhangi bir mesaj bulunmuyor !</h3>\r\n        </div>\r\n");
#nullable restore
#line 92 "C:\Users\EfeTopcu\source\repos\zetuTrade\zetutrade\Views\Admin\Messages.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<zetutrade_Model.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
