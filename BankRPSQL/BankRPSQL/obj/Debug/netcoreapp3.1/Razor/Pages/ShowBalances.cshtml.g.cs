#pragma checksum "C:\UBCS\BankRPSQL\BankRPSQL\Pages\ShowBalances.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155102ed58a0bdf33d94005a39bc426f48dd0dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BankRPSQL.Pages.Pages_ShowBalances), @"mvc.1.0.razor-page", @"/Pages/ShowBalances.cshtml")]
namespace BankRPSQL.Pages
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
#line 1 "C:\UBCS\BankRPSQL\BankRPSQL\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\UBCS\BankRPSQL\BankRPSQL\Pages\_ViewImports.cshtml"
using BankRPSQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\UBCS\BankRPSQL\BankRPSQL\Pages\_ViewImports.cshtml"
using BankRPSQL.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155102ed58a0bdf33d94005a39bc426f48dd0dae", @"/Pages/ShowBalances.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dceaf9fa7ad443d514a49e89b62487b43e5301", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShowBalances : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\UBCS\BankRPSQL\BankRPSQL\Pages\ShowBalances.cshtml"
   
    ViewData["Title"] = "ShowBalances"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Saving and Checking Balances</h2>\r\n<h3>Checking Balance : ");
#nullable restore
#line 8 "C:\UBCS\BankRPSQL\BankRPSQL\Pages\ShowBalances.cshtml"
                  Write(Model.CheckingBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Saving Balance : ");
#nullable restore
#line 9 "C:\UBCS\BankRPSQL\BankRPSQL\Pages\ShowBalances.cshtml"
                Write(Model.SavingsBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankRPSQL.Pages.ShowBalancesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankRPSQL.Pages.ShowBalancesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankRPSQL.Pages.ShowBalancesModel>)PageContext?.ViewData;
        public BankRPSQL.Pages.ShowBalancesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
