#pragma checksum "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\Pages\Error.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06c02a64d9ac0095d3c1e0237110316715c873ffc82ebee27a002f047c48c022"
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
#line 1 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\test\other\Blazor\BlazorAppGlobalVar\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/error")]
    public partial class Error : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Error.</h1>\n");
            __builder.AddMarkupContent(1, "<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
            __builder.AddMarkupContent(2, "<h3>Development Mode</h3>\n");
            __builder.AddMarkupContent(3, "<p>\n    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.\n</p>\n");
            __builder.AddMarkupContent(4, @"<p><strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
