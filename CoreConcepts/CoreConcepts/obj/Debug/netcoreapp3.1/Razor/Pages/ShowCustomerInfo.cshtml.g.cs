#pragma checksum "C:\UBCS\CoreConcepts\CoreConcepts\Pages\ShowCustomerInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4130289e990e373eef4c5e2d4ddb19a079e5f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreConcepts.Pages.Pages_ShowCustomerInfo), @"mvc.1.0.razor-page", @"/Pages/ShowCustomerInfo.cshtml")]
namespace CoreConcepts.Pages
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
#line 4 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\ShowCustomerInfo.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4130289e990e373eef4c5e2d4ddb19a079e5f7", @"/Pages/ShowCustomerInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54c362dc6fe825585e83c60a78322f512e10e19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShowCustomerInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MyPortfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <p>First Name : ");
#nullable restore
#line 7 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\ShowCustomerInfo.cshtml"
               Write(Model.CInfo.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Last Name : ");
#nullable restore
#line 8 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\ShowCustomerInfo.cshtml"
              Write(Model.CInfo.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Email : ");
#nullable restore
#line 9 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\ShowCustomerInfo.cshtml"
          Write(Model.CInfo.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<hr />\r\n");
#nullable restore
#line 12 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\ShowCustomerInfo.cshtml"
   
    ASCIIEncoding asc = new ASCIIEncoding(); 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f4130289e990e373eef4c5e2d4ddb19a079e5f74338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "C:\UBCS\CoreConcepts\CoreConcepts\Pages\ShowCustomerInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.CInfo.STList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreConcepts.Pages.ShowCustomerInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreConcepts.Pages.ShowCustomerInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreConcepts.Pages.ShowCustomerInfoModel>)PageContext?.ViewData;
        public CoreConcepts.Pages.ShowCustomerInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
