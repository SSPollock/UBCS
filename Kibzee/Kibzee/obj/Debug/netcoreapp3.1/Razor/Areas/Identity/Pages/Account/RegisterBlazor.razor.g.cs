#pragma checksum "C:\UBCS\Kibzee\Kibzee\Areas\Identity\Pages\Account\RegisterBlazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53bace7b86e7674acb9a7f7201bd516515264a3f"
// <auto-generated/>
#pragma warning disable 1591
namespace Kibzee.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Kibzee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\UBCS\Kibzee\Kibzee\_Imports.razor"
using Kibzee.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Identity/Account/RegisterBlazor")]
    public partial class RegisterBlazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Register here (using Blazor)</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<h4>Create a new account.</h4>\r\n        <hr>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\UBCS\Kibzee\Kibzee\Areas\Identity\Pages\Account\RegisterBlazor.razor"
                          _inputModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\UBCS\Kibzee\Kibzee\Areas\Identity\Pages\Account\RegisterBlazor.razor"
                                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "label");
                __builder2.AddMarkupContent(21, "\r\n                    Email Address:\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "email");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\UBCS\Kibzee\Kibzee\Areas\Identity\Pages\Account\RegisterBlazor.razor"
                                                       _inputModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _inputModel.Email = __value, _inputModel.Email))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _inputModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    <span asp-validation-for=\"Input.Email\" class=\"text-danger\"></span>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "label");
                __builder2.AddMarkupContent(34, "\r\n                    Create a Password:\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "password");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\UBCS\Kibzee\Kibzee\Areas\Identity\Pages\Account\RegisterBlazor.razor"
                                                          _inputModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _inputModel.Password = __value, _inputModel.Password))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _inputModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                    <span asp-validation-for=\"Input.Password\" class=\"text-danger\"></span>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "label");
                __builder2.AddMarkupContent(47, "\r\n                    Confirm Password:\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "id", "confirmpassword");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\UBCS\Kibzee\Kibzee\Areas\Identity\Pages\Account\RegisterBlazor.razor"
                                                                 _inputModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _inputModel.ConfirmPassword = __value, _inputModel.ConfirmPassword))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _inputModel.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                    <span asp-validation-for=\"Input.ConfirmPassword\" class=\"text-danger\"></span>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.AddMarkupContent(56, "<button type=\"submit\">Submit</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\UBCS\Kibzee\Kibzee\Areas\Identity\Pages\Account\RegisterBlazor.razor"
       
    private RegisterBlazorModel.InputModel _inputModel =
        new RegisterBlazorModel.InputModel();

    private void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
