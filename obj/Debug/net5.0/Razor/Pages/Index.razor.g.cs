#pragma checksum "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d5974f22b0cacf5ec9d18cddf6c6e783d1a2f3"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineShopTelerikBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using OnlineShopTelerikBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using OnlineShopTelerikBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
using OnlineShopTelerikBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>All Products:</h2>\r\n<hr>");
#nullable restore
#line 7 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
 foreach (var currProduct in productsService.ProductsList)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
     if (currProduct.UnitInStock == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "k-card");
            __builder.AddAttribute(3, "style", "display: inline-block;padding: 7px;");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "style", "width: 250px;opacity: 0.3");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 12 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                                         $"{currProduct.ImageUrl}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "k-card-body");
            __builder.OpenElement(10, "h4");
            __builder.AddAttribute(11, "class", "k-card-title");
            __builder.AddContent(12, 
#nullable restore
#line 14 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                          currProduct.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "k-card-subtitle");
            __builder.AddContent(16, 
#nullable restore
#line 15 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                             string.Format("{0:0.00}", currProduct.UnitPrice)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " lv.");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "k-card-subtitle");
            __builder.AddContent(21, 
#nullable restore
#line 16 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                              $"{currProduct.UnitInStock}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " left.");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<p style=\"color: red\">Out of Stock</p>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "k-card");
            __builder.AddAttribute(27, "style", "display: inline-block;padding: 7px;");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "style", "width: 250px;");
            __builder.AddAttribute(30, "src", 
#nullable restore
#line 24 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                             $"{currProduct.ImageUrl}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "k-card-body");
            __builder.OpenElement(34, "h4");
            __builder.AddAttribute(35, "class", "k-card-title");
            __builder.AddContent(36, 
#nullable restore
#line 26 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                          currProduct.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "h5");
            __builder.AddAttribute(39, "class", "k-card-subtitle");
            __builder.AddContent(40, 
#nullable restore
#line 27 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                             string.Format("{0:0.00}", currProduct.UnitPrice)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " lv.");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "h5");
            __builder.AddAttribute(44, "class", "k-card-subtitle");
            __builder.AddContent(45, 
#nullable restore
#line 28 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
                                              $"{currProduct.UnitInStock}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(46, " left.");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.AddMarkupContent(48, "<p style=\"color: green;\">In Stock</p>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\xrist\source\repos\OnlineShopTelerikBlazorPro\OnlineShopTelerikBlazor\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, @"<style>
    .k-listview-header,
    .k-listview-content {
        padding: 20px;
    }

    .k-listview-footer {
        border-width: 0;
        padding: 10px 20px;
    }

    .k-listview-content {
        display: grid;
        grid-template-columns: repeat(auto-fill, 180px);
        gap: 30px 20px;
    }

    .k-card {
        border: 0;
        border-radius: 0;
        box-shadow: none;
    }

    .k-card-body {
        padding: 10px 0;
    }

    .k-card .k-card-title {
        padding: 0;
        font-size: 1em;
        font-weight: bold;
        line-height: normal;
    }

    .k-card-subtitle {
        font-size: 0.85em;
    }

    .footer-note {
        text-align: right;
        font-style: italic;
        font-size: 0.85em;
    }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductsService productsService { get; set; }
    }
}
#pragma warning restore 1591
