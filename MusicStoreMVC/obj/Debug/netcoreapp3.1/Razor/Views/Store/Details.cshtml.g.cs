#pragma checksum "C:\Users\Raju Rocks\Desktop\MusicStoreCore\MusicStoreMVC\Views\Store\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "215d7cdd136fee66c18d679425317ed80e6179ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Details), @"mvc.1.0.view", @"/Views/Store/Details.cshtml")]
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
#line 1 "C:\Users\Raju Rocks\Desktop\MusicStoreCore\MusicStoreMVC\Views\_ViewImports.cshtml"
using MusicStoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Raju Rocks\Desktop\MusicStoreCore\MusicStoreMVC\Views\_ViewImports.cshtml"
using MusicStoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"215d7cdd136fee66c18d679425317ed80e6179ea", @"/Views/Store/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a54859ea7d94016523f5ecc2af88f513a5d506c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicStoreMVC.Models.Album>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Raju Rocks\Desktop\MusicStoreCore\MusicStoreMVC\Views\Store\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Album: ");
#nullable restore
#line 6 "C:\Users\Raju Rocks\Desktop\MusicStoreCore\MusicStoreMVC\Views\Store\Details.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicStoreMVC.Models.Album> Html { get; private set; }
    }
}
#pragma warning restore 1591
