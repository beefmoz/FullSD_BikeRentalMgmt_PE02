#pragma checksum "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b10c7526d2a79dccae189703bb24f4ad4b92105"
// <auto-generated/>
#pragma warning disable 1591
namespace BikeRentalMgmt2.Client.Pages.Customers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Client.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers/create/")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Register New customer</h3>\r\n\r\n<hr>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                  customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                           Createcustomer

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label>First Name: </label>\r\n\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                     customer.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.FirstName = __value, customer.FirstName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Customers.Create.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 19 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                      () => customer.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label>Last Name: </label>\r\n\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                     customer.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.LastName = __value, customer.LastName))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Customers.Create.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 28 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                      () => customer.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "<label>Customer Email: </label>\r\n\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                     customer.CustEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustEmail = __value, customer.CustEmail))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Customers.Create.TypeInference.CreateValidationMessage_2(__builder2, 45, 46, 
#nullable restore
#line 37 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                      () => customer.CustEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "<label>Customer Contact: </label>\r\n\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                     customer.CustContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustContact = __value, customer.CustContact))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustContact));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Customers.Create.TypeInference.CreateValidationMessage_3(__builder2, 58, 59, 
#nullable restore
#line 46 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                      () => customer.CustContact

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "<label>Customer Address: </label>\r\n\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(65);
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                     customer.CustAddr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustAddr = __value, customer.CustAddr))));
                __builder2.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustAddr));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Customers.Create.TypeInference.CreateValidationMessage_4(__builder2, 71, 72, 
#nullable restore
#line 55 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
                                      () => customer.CustAddr

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n\r\n    ");
                __builder2.AddMarkupContent(74, "<button type=\"submit\" class=\"btn btn-success btn-block\">\r\n        Create customer\r\n    </button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Customers\Create.razor"
       

    Customer customer = new Customer();

    private IList<Customer> customers;
    private IList<Staff> Staffs;

    protected async override Task OnInitializedAsync()
    {
        customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        Staffs = await _client.GetFromJsonAsync<List<Staff>>($"{Endpoints.StaffEndpoint}");
    }

    private async Task Createcustomer()
    {
        await _client.PostAsJsonAsync(Endpoints.CustomersEndpoint, customer);
        _navManager.NavigateTo("/customers/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
namespace __Blazor.BikeRentalMgmt2.Client.Pages.Customers.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
