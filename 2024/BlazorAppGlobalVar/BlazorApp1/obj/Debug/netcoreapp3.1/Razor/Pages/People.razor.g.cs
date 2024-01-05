#pragma checksum "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4b4654e5b1cb3c89aca8fce22e46c672a5fa5b4b0b854f0de4f25ad9b6df2ff7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class People : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>People</h3>\n\n");
#nullable restore
#line 7 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 10 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th>First Name</th>\n                <th>Last Name (C)</th>\n                <th>Balance (F)</th>\n                <th>Full Name</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 23 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 26 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
__builder.AddContent(14, forecast.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 27 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
__builder.AddContent(18, forecast.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 28 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
__builder.AddContent(21, forecast.AccountBalance);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 29 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
__builder.AddContent(24, forecast.FullName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 31 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 34 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Administrator\Downloads\BlazorApp1\BlazorApp1\Pages\People.razor"
       
    //private WeatherForecast[] forecasts;
    private PersonModel[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await PeopleService.GetPeopleAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PeopleService PeopleService { get; set; }
    }
}
#pragma warning restore 1591
