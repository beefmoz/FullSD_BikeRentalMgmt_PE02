#pragma checksum "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096c9d86f538923be11a761dcbe48ff89db3948d"
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
using BikeRentalMgmt2.Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\_Imports.razor"
using BikeRentalMgmt2.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff/edit/{id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit bike</h3>\r\n\r\n");
            __builder.OpenComponent<BikeRentalMgmt2.Client.Pages.Staff.FormComponent>(1);
            __builder.AddAttribute(2, "ButtonText", "Update");
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\Edit.razor"
                                                  EditStaff

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "staff", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BikeRentalMgmt2.Shared.Domain.Staff>(
#nullable restore
#line 7 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\Edit.razor"
                                                                    staff

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Amoz\source\repos\BikeRentalMgmt2\BikeRentalMgmt2\Client\Pages\Staff\Edit.razor"
       
    [Parameter] public int id { get; set; }
    Staff staff = new Staff();

    protected async override Task OnParametersSetAsync()
    {
        staff = await _client.GetFromJsonAsync<Staff>($"{Endpoints.StaffEndpoint}/{id}");
    }

    async Task EditStaff()
    {
        await _client.PutAsJsonAsync($"{Endpoints.StaffEndpoint}/{id}", staff);
        _navManager.NavigateTo("/staffs/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
#pragma warning restore 1591
