#pragma checksum "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1162645c7de45410fa11c892959bcb1b96b3f60"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplocalstorage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using BlazorApplocalstorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using BlazorApplocalstorage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "textarea");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor"
                 noteContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => noteContent = __value, noteContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Read: ");
            __builder.AddContent(11, 
#nullable restore
#line 10 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor"
          noteRead

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.AddMarkupContent(13, "<p>Read:</p>\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor"
                  UpdateLocalStorage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor"
                  ReadLocalStorage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\test\other\indexeddb\BlazorApplocalstorage\BlazorApplocalstorage\Pages\Counter.razor"
       
    private int currentCount = 0;
    //DataStorage dataStorage = new DataStorage();
    //private List<DataObject> lst = new List<DataObject>();
    //public MemoryCache cache = MemoryCache.Default;

    const string noteKey = "note";
    string noteContent;
    string noteRead;

    //public void SaveData()
    //{
    //    DataObject data = new DataObject();
    //    CacheItemPolicy itemPolicy = new CacheItemPolicy();
    //    cache.Add(data.Id, data, itemPolicy);
    //}

    public async Task UpdateLocalStorage()
    {
        await localStore.SetItemAsync(noteKey, noteContent);
    }

    public async Task ReadLocalStorage()
    {
        noteRead = await localStore.GetItemAsync<string>(noteKey);
    }

    //private void InsertData()
    //{
    //    DataObject data = new DataObject();
    //    data.Id = currentCount.ToString();
    //    data.Name = "SameName";
    //    dataStorage.SaveData(data);
    //}

    //public void GetAll()
    //{
    //    lst = dataStorage.GetAll();
    //    foreach (var data in lst)
    //    {
    //        Console.WriteLine(data.Name);
    //    }        
    //}

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
    }
}
#pragma warning restore 1591
