#pragma checksum "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a17e7bfe1fd78ddc2622e016d02377c5c3cc5a05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
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
#line 1 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\_ViewImports.cshtml"
using OyunKiralamaSitesi.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\_ViewImports.cshtml"
using OyunKiralamaSitesi.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using OyunKiralamaSitesi.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using OyunKiralamaSitesi.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using OyunKiralamaSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17e7bfe1fd78ddc2622e016d02377c5c3cc5a05", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64097b8280e30f284729b6b56cfa9ab5bfe28731", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef20101b4a64f8ada7ff8ad557fa58daae85ecd", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8d31cf6a8244ba6a839ef62404b1acf06b6342", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 139, "\"", 196, 4);
            WriteAttributeValue("", 147, "alert", 147, 5, true);
            WriteAttributeValue(" ", 152, "alert-", 153, 7, true);
#nullable restore
#line 6 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 159, statusMessageClass, 159, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 178, "alert-dismissible", 179, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        ");
#nullable restore
#line 8 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 10 "C:\Users\kayah\OneDrive\Masaüstü\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
