#pragma checksum "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\Shared\Components\KategoriList\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd2e065d292de6a705ea270916b91e21f5f5a2bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_KategoriList_default), @"mvc.1.0.view", @"/Views/Shared/Components/KategoriList/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd2e065d292de6a705ea270916b91e21f5f5a2bb", @"/Views/Shared/Components/KategoriList/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcdb3787a52db84fc85a84ce4e55849aabc495b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_KategoriList_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kategori>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\Shared\Components\KategoriList\default.cshtml"
 foreach(var kategori in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 5 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\Shared\Components\KategoriList\default.cshtml"
                                                          Write(kategori.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 6 "C:\Users\korha\source\repos\NetCoreProje\NetCoreProje\Views\Shared\Components\KategoriList\default.cshtml"
    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kategori>> Html { get; private set; }
    }
}
#pragma warning restore 1591
