#pragma checksum "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1784a20fbe630fafd85c30887674a5d43f2a1600"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorExpenseTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using BlazorExpenseTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using BlazorExpenseTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using BlazorExpenseTracker.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\_Imports.razor"
using ChartJs.Blazor.ChartJS.PieChart;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Categories</h3> \r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
     Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
 if (categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<p><em>Loading... Espere que hayan datos en la lista </em></p>\r\n");
#nullable restore
#line 11 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container table");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<div class=\"row\">\r\n            <div class=\"col-12 alert-success\">\r\n                <a href=\"/CategoriesDetails\"> Agregar Nueva Categoria </a>\r\n            </div>\r\n        </div>\r\n\r\n        ");
            __builder.AddMarkupContent(13, "<div class=\"row\">\r\n            <div class=\"col-12 alert-light\">\r\n                <h4 class=\"text-center\">\r\n                    <i> Nombre de la Categoria </i>\r\n                </h4>\r\n            </div>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 31 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
             foreach (var category in categories)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-8 alert-success");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.AddContent(21, 
#nullable restore
#line 34 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
                     category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.AddContent(24, "                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-2 alert-info");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "/CategoriesDetails/" + (
#nullable restore
#line 38 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
                                                 category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.AddMarkupContent(31, "<i>Modificar</i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.AddContent(34, "                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-2 alert-war");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "/Categorydelete/" + (
#nullable restore
#line 44 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
                                              category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.AddMarkupContent(41, "<i>Eliminar</i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 48 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 53 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\Categories.razor"
       

    public IEnumerable<Category> categories { get; set; }
    public string Message { get; set; } = "Listo :)";

    protected async override Task OnInitializedAsync()
    {
        try
        {
            categories = await CategoryService.GetAllCategories();
        }
        catch (Exception ex)
        {
            Message = "Error inesperado  :( " + ex.Message;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
