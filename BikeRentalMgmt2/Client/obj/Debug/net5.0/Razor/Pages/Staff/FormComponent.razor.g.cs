#pragma checksum "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e72e772df78e1404d0094a642626d688223ece53"
// <auto-generated/>
#pragma warning disable 1591
namespace BikeRentalMgmt2.Client.Pages.Staff
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
#line 2 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                  staff

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
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
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "fieldset");
                __builder2.AddAttribute(9, "disabled", 
#nullable restore
#line 5 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                         Disabled

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label>Staff Name: </label>\r\n\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                         staff.StaffName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.StaffName = __value, staff.StaffName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.StaffName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 11 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                          () => staff.StaffName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label>Staff Contact: </label>\r\n\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                         staff.StaffContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.StaffContact = __value, staff.StaffContact))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.StaffContact));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent.TypeInference.CreateValidationMessage_1(__builder2, 33, 34, 
#nullable restore
#line 20 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                          () => staff.StaffContact

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label>Staff Email: </label>\r\n\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                         staff.StaffEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.StaffEmail = __value, staff.StaffEmail))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.StaffEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent.TypeInference.CreateValidationMessage_2(__builder2, 46, 47, 
#nullable restore
#line 29 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                          () => staff.StaffEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<label>Staff Address: </label>\r\n\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                         staff.StaffAddr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.StaffAddr = __value, staff.StaffAddr))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.StaffAddr));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent.TypeInference.CreateValidationMessage_3(__builder2, 59, 60, 
#nullable restore
#line 38 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                          () => staff.StaffAddr

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "<label>Staff Position: </label>\r\n\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                         staff.StaffPos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.StaffPos = __value, staff.StaffPos))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.StaffPos));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent.TypeInference.CreateValidationMessage_4(__builder2, 72, 73, 
#nullable restore
#line 47 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                          () => staff.StaffPos

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "<label>Staff Branch Location: </label>\r\n\r\n            ");
                __builder2.OpenElement(78, "div");
                __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent.TypeInference.CreateInputSelect_5(__builder2, 79, 80, "form-control", 81, 
#nullable restore
#line 55 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                          staff.StaffBranchID

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.StaffBranchID = __value, staff.StaffBranchID)), 83, () => staff.StaffBranchID, 84, (__builder3) => {
                    __builder3.AddMarkupContent(85, "<option value>-- Select Staff --</option>");
#nullable restore
#line 58 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                     if (Branches != null)
                    {
                        foreach (var branch in Branches)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(86, "option");
                    __builder3.AddAttribute(87, "value", 
#nullable restore
#line 62 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                            branch.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(88, 
#nullable restore
#line 62 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                                        branch.BranchAddr

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 63 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(89, "\r\n                ");
                __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent.TypeInference.CreateValidationMessage_6(__builder2, 90, 91, 
#nullable restore
#line 67 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
                                          () => staff.StaffBranchID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 71 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
     if (!Disabled)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "type", "submit");
                __builder2.AddAttribute(94, "class", "btn btn-success btn-block");
                __builder2.AddContent(95, 
#nullable restore
#line 74 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
             ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 76 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BikeRentalMgmt2.Client.Components.BackToList>(96);
                __builder2.AddAttribute(97, "Target", "staff");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\FormComponent.razor"
       
    [Parameter] public bool Disabled { get; set; } = false;
    [Parameter] public Staff staff { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    private IList<Branch> Branches;

    protected async override Task OnInitializedAsync()
    {
        Branches = await _client.GetFromJsonAsync<List<Branch>>($"{Endpoints.BranchesEndpoint}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
namespace __Blazor.BikeRentalMgmt2.Client.Pages.Staff.FormComponent
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
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
