#pragma checksum "C:\UBCS\CoreConcepts\CoreConcepts\Pages\MyPartials\_MyPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2488ee05004d675498e040461b37b52d8bd03bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreConcepts.Pages.MyPartials.Pages_MyPartials__MyPortfolio), @"mvc.1.0.view", @"/Pages/MyPartials/_MyPortfolio.cshtml")]
namespace CoreConcepts.Pages.MyPartials
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
#line 1 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\_ViewImports.cshtml"
using CoreConcepts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2488ee05004d675498e040461b37b52d8bd03bc", @"/Pages/MyPartials/_MyPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54c362dc6fe825585e83c60a78322f512e10e19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyPartials__MyPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.StockInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\MyPartials\_MyPortfolio.cshtml"
   
    var m = Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">     \r\n    <tr>         \r\n        <th>Stock</th>         \r\n        <th>Price</th>     \r\n    </tr>     \r\n");
#nullable restore
#line 14 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\MyPartials\_MyPortfolio.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 16 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\MyPartials\_MyPortfolio.cshtml"
           Write(item.Symbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\MyPartials\_MyPortfolio.cshtml"
                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 17 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\MyPartials\_MyPortfolio.cshtml"
    }     

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr></tr> \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.StockInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
