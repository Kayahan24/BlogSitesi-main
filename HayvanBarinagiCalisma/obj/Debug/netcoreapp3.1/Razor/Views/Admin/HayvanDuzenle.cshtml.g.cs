#pragma checksum "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de23e9400ed1ea69e4df999bd241260408e9971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_HayvanDuzenle), @"mvc.1.0.view", @"/Views/Admin/HayvanDuzenle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de23e9400ed1ea69e4df999bd241260408e9971", @"/Views/Admin/HayvanDuzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6a5e3f8e4a9028d18ef63a17fba931ba61b642", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_HayvanDuzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HayvanlarTurCinsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HayvanSil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HayvanUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
  
    ViewData["Title"] = "Hayvan Düzenle";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Hayvanlar</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Resim</th>
                            <th>Adı</th>
                            <th>Türü</th>
                            <th>Cinsi</th>
                            <th>Yaşı</th>
                            <th>Cinsiyeti</th>
                            <th>Ek Açıklama</th>
                            <th>Sahiplenilme Durumu</th>
                            <th>İşlem</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                           int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                         foreach (var hayvan in Model.Hayvanlar)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td><img");
            BeginWriteAttribute("src", " src=\"", 1213, "\"", 1231, 1);
#nullable restore
#line 33 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
WriteAttributeValue("", 1219, hayvan.Foto, 1219, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\n                            <td>");
#nullable restore
#line 34 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                           Write(hayvan.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 35 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                           Write(Model.Turler.Where(x => x.TurId == hayvan.TurId).FirstOrDefault().TurAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 36 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                           Write(Model.Cinsler.Where(x => x.CinsId == hayvan.CinsId).FirstOrDefault().CinsAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 37 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                           Write(hayvan.Yasi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 38 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                             if (hayvan.Cinsiyet)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Erkek</td>\n");
#nullable restore
#line 41 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Dişi</td>\n");
#nullable restore
#line 45 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 46 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                           Write(hayvan.EkBilgiler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 47 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                             if (hayvan.SahiplenildiMi)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Sahiplenildi</td>\n");
#nullable restore
#line 50 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Sahiplenilmedi</td>\n");
#nullable restore
#line 54 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de23e9400ed1ea69e4df999bd241260408e997111533", async() => {
                WriteLiteral("Sil");
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
#line 56 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                                                                                                             WriteLiteral(hayvan.HayvanId);

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
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de23e9400ed1ea69e4df999bd241260408e997114131", async() => {
                WriteLiteral("Güncelle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                                                                                                              WriteLiteral(hayvan.HayvanId);

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
            WriteLiteral("\n                        </td>\n                        </tr>\n");
#nullable restore
#line 60 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\HayvanDuzenle.cshtml"
                            i++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HayvanlarTurCinsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
