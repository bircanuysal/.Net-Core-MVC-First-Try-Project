#pragma checksum "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb3a2cb27d4e44e9700d8fb0bc28191bff81d8c"
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
#line 1 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\_ViewImports.cshtml"
using NetCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\_ViewImports.cshtml"
using NetCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\_ViewImports.cshtml"
using NetCoreProje.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb3a2cb27d4e44e9700d8fb0bc28191bff81d8c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcdb3787a52db84fc85a84ce4e55849aabc495b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 4 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("KategoriList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-md-9\">\r\n        ");
#nullable restore
#line 8 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("UrunList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\"\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
