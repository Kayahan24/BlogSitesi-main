#pragma checksum "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bdfcf66d7eb6f292de32db6b77ccde719837ebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TurSil), @"mvc.1.0.view", @"/Views/Admin/TurSil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bdfcf66d7eb6f292de32db6b77ccde719837ebe", @"/Views/Admin/TurSil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6a5e3f8e4a9028d18ef63a17fba931ba61b642", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TurSil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tur>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("for", new global::Microsoft.AspNetCore.Html.HtmlString("id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-75 m-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml"
  
    ViewData["Title"] = "Tür Sil";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container mt-5\">\n        <h1 style=\"text-align:center;\">Tür Sil</h1>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bdfcf66d7eb6f292de32db6b77ccde719837ebe5181", async() => {
                WriteLiteral("\n            <div class=\"form-group\">\n");
                WriteLiteral("                <select class=\"form-control\" name=\"id\">\n");
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bdfcf66d7eb6f292de32db6b77ccde719837ebe5628", async() => {
                    WriteLiteral("Tür Adını Seçin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 15 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml"
                     foreach (var tur in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bdfcf66d7eb6f292de32db6b77ccde719837ebe7313", async() => {
#nullable restore
#line 17 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml"
                                                       Write(tur.TurAdi);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml"
                           WriteLiteral(tur.TurId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 18 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary float-right\">Sil</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div>\n\n    <div class=\"container mt-2\">\n        <p class=\"w-75 text-primary text-center\">");
#nullable restore
#line 27 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml"
                                            Write(ViewBag.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p class=\"w-75 text-danger text-center\">");
#nullable restore
#line 28 "C:\Users\kayah\OneDrive\Masaüstü\kAkAYDET\HayvanBarinagiCalisma\OyunKiralamaSitesi\HayvanBarinagiCalisma\Views\Admin\TurSil.cshtml"
                                           Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tur>> Html { get; private set; }
    }
}
#pragma warning restore 1591
