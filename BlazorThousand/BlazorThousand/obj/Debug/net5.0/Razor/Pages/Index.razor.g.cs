#pragma checksum "D:\git\BlazorApp\BlazorThousand\BlazorThousand\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2745da35382e1be51aa38584f004bdfd18bc6965"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorThousand.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using BlazorThousand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\_Imports.razor"
using BlazorThousand.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Thousand Seperator</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 5 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\Pages\Index.razor"
                               KeyboardEventHandler1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\Pages\Index.razor"
                                                             amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => amount = __value, amount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "D:\git\BlazorApp\BlazorThousand\BlazorThousand\Pages\Index.razor"
       
    string KeyPressed = "";
    string KeyPressed1 = "";
    string EventInfo = "";
    string amount = "";
    static int i = 0;

    private void KeyboardEventHandler1(KeyboardEventArgs args)
    {
        KeyPressed = args.Key; //"Key Pressed is " + args.Key;
        EventInfo = "Event Type " + args.Type;
        double number;

        if (KeyPressed == "Backspace")
        {
            if (double.TryParse(amount, out number))
            {
                double db = double.Parse(amount);
                if (db.ToString().Length > 1)
                {
                    db = double.Parse(db.ToString().Remove(db.ToString().Length - 1));
                    amount = String.Format("{0:n}", db);
                    KeyPressed1 = db.ToString();
                }
                else
                {
                    KeyPressed1 = "";
                }
            }
        }
        else
        {
            KeyPressed1 = KeyPressed1 + KeyPressed;
            double db = int.Parse(KeyPressed1);
            amount = String.Format("{0:n}", db);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
