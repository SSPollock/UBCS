#pragma checksum "C:\UBCS\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11bb3b1cde36390c33c6ad3f2834bfc7c2a55456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AjaxCore.Pages.Pages__CourseEnrollmentPartial), @"mvc.1.0.view", @"/Pages/_CourseEnrollmentPartial.cshtml")]
namespace AjaxCore.Pages
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
#line 1 "C:\UBCS\AjaxCore\AjaxCore\Pages\_ViewImports.cshtml"
using AjaxCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11bb3b1cde36390c33c6ad3f2834bfc7c2a55456", @"/Pages/_CourseEnrollmentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad87c06f7ffe6af99f0a8423cede28625416d5de", @"/Pages/_ViewImports.cshtml")]
    public class Pages__CourseEnrollmentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.Enrollment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\">     \r\n    <tr><th>First Name</th><th>Last Name</th><th>StudentId</th><th>CourseNum</th></tr> \r\n");
#nullable restore
#line 5 "C:\UBCS\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>         \r\n            <td>");
#nullable restore
#line 8 "C:\UBCS\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>         \r\n            <td>");
#nullable restore
#line 9 "C:\UBCS\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>         \r\n            <td>");
#nullable restore
#line 10 "C:\UBCS\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
           Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>         \r\n            <td>");
#nullable restore
#line 11 "C:\UBCS\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
           Write(item.CourseNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>     \r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\UBCS\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.Enrollment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
