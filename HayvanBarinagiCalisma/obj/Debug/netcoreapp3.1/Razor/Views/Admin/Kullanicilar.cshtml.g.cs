#pragma checksum "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9196a5f2c345dd98fa3871fdd67e3b70faebd6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Kullanicilar), @"mvc.1.0.view", @"/Views/Admin/Kullanicilar.cshtml")]
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
#line 1 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using OyunKiralamaSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using OyunKiralamaSitesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using OyunKiralamaSitesi.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9196a5f2c345dd98fa3871fdd67e3b70faebd6e", @"/Views/Admin/Kullanicilar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6a5e3f8e4a9028d18ef63a17fba931ba61b642", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Kullanicilar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CustomUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RolDegistir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
  
    ViewData["Title"] = "Kullanıcılar";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Kullanıcılar</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr class=""text-center"">
                        <th>Adı</th>
                        <th>Soyadı</th>
                        <th>E-mail</th>
                        <th>Rolü</th>
                        <th>İşlem</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 25 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                       int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                     foreach (var kullanici in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"text-center\">\n                            <td>");
#nullable restore
#line 30 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                           Write(kullanici.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 31 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                           Write(kullanici.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 32 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                           Write(kullanici.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 33 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                           Write(kullanici.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9196a5f2c345dd98fa3871fdd67e3b70faebd6e7574", async() => {
                WriteLiteral("Değiştir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                                                                                                                                       WriteLiteral(kullanici.Id);

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
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 36 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\Kullanicilar.cshtml"
                        i++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CustomUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
