#pragma checksum "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "444126611fa985cde9f772a3c0ec910a3efd1915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StateManagement.Pages.Pages_Confirm), @"mvc.1.0.razor-page", @"/Pages/Confirm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444126611fa985cde9f772a3c0ec910a3efd1915", @"/Pages/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"691cc7629982491fcebe0b4c5e462bb7657f13e1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Confirm : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Prev"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "prevButton", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("prevButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Finish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "finishButton", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("finishButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
   
    ViewData["Title"] = "Confirm"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Confirm</h1>\r\n\r\n<div>\r\n    <h4>UserInfo</h4>     \r\n    <hr />     \r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 14 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 17 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 20 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 23 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 26 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">              \r\n            ");
#nullable restore
#line 29 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 32 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 35 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 38 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 41 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 44 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 47 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 50 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 53 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 56 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.CellPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 59 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.CellPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n        <dt class=\"col-sm-2\">             \r\n            ");
#nullable restore
#line 62 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayNameFor(model => model.UInfo.UserPin));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dt>\r\n        <dd class=\"col-sm-10\">             \r\n            ");
#nullable restore
#line 65 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
       Write(Html.DisplayFor(model => model.UInfo.UserPin));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "444126611fa985cde9f772a3c0ec910a3efd191513166", async() => {
                WriteLiteral("     \r\n    <div class=\"form-group\">         \r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "444126611fa985cde9f772a3c0ec910a3efd191513481", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 72 "C:\UBCS\StateManagement\StateManagement\Pages\Confirm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UInfo.Wizhidden);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("         \r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "444126611fa985cde9f772a3c0ec910a3efd191515277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("         \r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "444126611fa985cde9f772a3c0ec910a3efd191516836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("     \r\n    </div> \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StateManagement.Pages.ConfirmModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateManagement.Pages.ConfirmModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateManagement.Pages.ConfirmModel>)PageContext?.ViewData;
        public StateManagement.Pages.ConfirmModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
