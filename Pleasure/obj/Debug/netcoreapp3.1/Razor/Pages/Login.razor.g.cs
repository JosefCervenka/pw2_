#pragma checksum "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77ac73deaf0a8abee80cd057bcd0f9b13ceccb18"
// <auto-generated/>
#pragma warning disable 1591
namespace Pleasure.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Pleasure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pepak\source\repos\Pleasure\Pleasure\_Imports.razor"
using Pleasure.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                  register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                                            HandleValidRegister

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "placeholder", "Username");
                __builder2.AddAttribute(11, "id", "name");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                                                             register.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => register.UserName = __value, register.UserName))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => register.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "placeholder", "Password");
                __builder2.AddAttribute(18, "type", "password");
                __builder2.AddAttribute(19, "id", "password");
                __builder2.AddAttribute(20, "name", "password");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                                                                                                 register.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => register.Password = __value, register.Password))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => register.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "placeholder", "Email");
                __builder2.AddAttribute(27, "type", "email");
                __builder2.AddAttribute(28, "id", "name");
                __builder2.AddAttribute(29, "name", "email");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                                                                                    register.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => register.Email = __value, register.Email))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => register.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n\r\n    ");
                __builder2.AddMarkupContent(34, "<button type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(36);
            __builder.AddAttribute(37, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                  login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                                         HandleValidLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(41);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(43);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "placeholder", "Username or Email");
                __builder2.AddAttribute(47, "id", "name");
                __builder2.AddAttribute(48, "name", "email");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                                                                                   login.UserNameOrEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => login.UserNameOrEmail = __value, login.UserNameOrEmail))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => login.UserNameOrEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "placeholder", "Password");
                __builder2.AddAttribute(55, "type", "password");
                __builder2.AddAttribute(56, "id", "password");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
                                                                                 login.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => login.Password = __value, login.Password))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => login.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
                __builder2.AddMarkupContent(61, "<button type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n\r\n\r\n");
#nullable restore
#line 33 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
 foreach (var user in database.getUser())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "    ");
            __builder.OpenElement(64, "p");
            __builder.AddContent(65, 
#nullable restore
#line 35 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
        user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.OpenElement(67, "p");
            __builder.AddContent(68, 
#nullable restore
#line 36 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
        user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 37 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\pepak\source\repos\Pleasure\Pleasure\Pages\Login.razor"
       
    private Data.LoginAndRegister.Register register = new Data.LoginAndRegister.Register();
    private Data.LoginAndRegister.Login login = new Data.LoginAndRegister.Login();
    string Error = "";

    private void HandleValidLogin()
    {
        
    }
    private void HandleValidRegister()
    {
        bool NameValidationLenght = false;
        bool ValidationAvailability = true;
        bool PasswordValidationLenght = false;
        bool EmailValidation = true;

        if (register.UserName.Length >= 5 && register.UserName.Length <= 20)
        {
            NameValidationLenght = true;
            foreach (var selectItem in database.getUser())
            {
                if (register.UserName == selectItem.UserName)
                    ValidationAvailability = false;
                if (register.Email == selectItem.Email)
                    ValidationAvailability = false;
            }
        }
        if(register.Password != null)
        if (register.Password.Length >= 10)
            PasswordValidationLenght = true;

        try
        {
            var email = new MailAddress(register.Email);
        }
        catch
        {
            EmailValidation = false;
        }

        if (NameValidationLenght == true && ValidationAvailability == true && PasswordValidationLenght == true && EmailValidation == true)
        {
            database.addUser(register.UserName, register.Password, register.Email);
            Error = "";
        }
        else
            Error = "Error";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Database database { get; set; }
    }
}
#pragma warning restore 1591
