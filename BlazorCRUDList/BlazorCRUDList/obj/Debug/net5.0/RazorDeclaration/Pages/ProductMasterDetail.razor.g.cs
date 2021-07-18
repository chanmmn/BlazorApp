// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUDList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using BlazorCRUDList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\_Imports.razor"
using BlazorCRUDList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\Pages\ProductMasterDetail.razor"
using BlazorCRUDList.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productmd")]
    public partial class ProductMasterDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\git\BlazorApp\BlazorCRUDList\BlazorCRUDList\Pages\ProductMasterDetail.razor"
       

    private ProductModel[] productModels;
    private List<ProductModel> list = new List<ProductModel>();
    private float unitPrice { get; set; }
    private string productName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        list = new List<ProductModel>()
            {
                new ProductModel{ProductName="Chai", UnitPrice="1" },
                new ProductModel{ProductName="Aniseed Syrup", UnitPrice="2" },
                new ProductModel{ProductName="Chang", UnitPrice = "3"}
            };
    }

    private void PrepareForEdit(ProductModel task)
    {
        productName = task.ProductName;
        unitPrice = float.Parse(task.UnitPrice);
    }

    private void AddProduct()
    {
        ProductModel product = new ProductModel();
        product.ProductName= productName;
        product.UnitPrice = unitPrice.ToString();
        list.Add(product);
    }

    private void SaveProduct()
    {
        var result = from r in list where r.ProductName == productName select r;
        result.First().UnitPrice = unitPrice.ToString();
    }

    private void DeleteProduct()
    {
        ///int pid = int.Parse(txtProductID.Text);
        var result = from r in list where r.ProductName == productName select r;
        list.Remove(result.First());
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
