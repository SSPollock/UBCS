#pragma checksum "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64bb28a0ad9b28a43c5c804a3f167ef89af4db4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StateManagement.Pages.Pages_ShowProductOnSale), @"mvc.1.0.razor-page", @"/Pages/ShowProductOnSale.cshtml")]
namespace StateManagement.Pages
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
#line 1 "C:\UBCS\StateManagement\StateManagement\Pages\_ViewImports.cshtml"
using StateManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bb28a0ad9b28a43c5c804a3f167ef89af4db4d", @"/Pages/ShowProductOnSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"691cc7629982491fcebe0b4c5e462bb7657f13e1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShowProductOnSale : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml"
   
    ViewData["Title"] = "ShowProductOnSale"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product On Sale</h1> \r\n");
#nullable restore
#line 8 "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml"
 if (Model.Prod != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml"
Write(Model.Prod.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 12 "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml"
Write(Model.Prod.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml"
Write(Model.Prod.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml"
                      
}
else
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral(" No Product on Sale \r\n");
#nullable restore
#line 19 "C:\UBCS\StateManagement\StateManagement\Pages\ShowProductOnSale.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StateManagement.Pages.ShowProductOnSaleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateManagement.Pages.ShowProductOnSaleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateManagement.Pages.ShowProductOnSaleModel>)PageContext?.ViewData;
        public StateManagement.Pages.ShowProductOnSaleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
