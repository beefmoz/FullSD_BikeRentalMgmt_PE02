#pragma checksum "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb59b3199855940878e4f2cf383bde10b579efb7"
// <auto-generated/>
#pragma warning disable 1591
namespace BikeRentalMgmt2.Client.Pages.Branches
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
    public partial class FormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                  branch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                          OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label>Branch Address: </label>\r\n\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                     branch.BranchAddr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BranchAddr = __value, branch.BranchAddr))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BranchAddr));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Branches.FormComponent.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 11 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                      () => branch.BranchAddr

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>Branch Contact: </label>\r\n\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                     branch.BranchContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BranchContact = __value, branch.BranchContact))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BranchContact));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Branches.FormComponent.TypeInference.CreateValidationMessage_1(__builder2, 31, 32, 
#nullable restore
#line 20 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                      () => branch.BranchContact

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "<label>Branch Manager: </label>\r\n\r\n        ");
                __builder2.OpenElement(37, "div");
                __Blazor.BikeRentalMgmt2.Client.Pages.Branches.FormComponent.TypeInference.CreateInputSelect_2(__builder2, 38, 39, "form-control", 40, 
#nullable restore
#line 28 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                      branch.ManagerID

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.ManagerID = __value, branch.ManagerID)), 42, () => branch.ManagerID, 43, (__builder3) => {
                    __builder3.AddMarkupContent(44, "<option value>-- Select Manager --</option>");
#nullable restore
#line 31 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                 if (Staffs != null)
                {
                    foreach (var staff in Staffs)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(45, "option");
                    __builder3.AddAttribute(46, "value", 
#nullable restore
#line 35 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                        staff.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(47, 
#nullable restore
#line 35 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                                   staff.StaffName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 36 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                    }
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(48, "\r\n            ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Branches.FormComponent.TypeInference.CreateValidationMessage_3(__builder2, 49, 50, 
#nullable restore
#line 40 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
                                      () => branch.ManagerID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n    ");
                __builder2.AddMarkupContent(52, "<button type=\"submit\" class=\"btn btn-success btn-block\">\r\n        Create branch\r\n    </button>\r\n    ");
                __builder2.OpenComponent<BikeRentalMgmt2.Client.Components.BackToList>(53);
                __builder2.AddAttribute(54, "Target", "branches");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Branches\FormComponent.razor"
       
    [Parameter] public bool Disabled { get; set; } = false;
    [Parameter] public Branch branch { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    private IList<Staff> Staffs;

    protected async override Task OnInitializedAsync()
    {
        Staffs = await _client.GetFromJsonAsync<List<Staff>>($"{Endpoints.StaffEndpoint}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
namespace __Blazor.BikeRentalMgmt2.Client.Pages.Branches.FormComponent
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
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
