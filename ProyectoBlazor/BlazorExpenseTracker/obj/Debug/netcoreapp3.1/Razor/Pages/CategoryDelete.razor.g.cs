#pragma checksum "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\CategoryDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0eb9183930e513dabef6b258decec659f17c075"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/CategoryDelete/{id:int}")]
    public partial class CategoryDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal");
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "style", "display:block");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-content");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<div class=\"modal-header\">\r\n                <h3>CategoryesDetails</h3>\r\n            </div>\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-body");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\CategoryDelete.razor"
                                  category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\CategoryDelete.razor"
                                                           DeleteCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n\r\n                    \r\n\r\n                    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "container");
                __builder2.AddMarkupContent(25, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(26, "<div class=\"row\">\r\n                            <div class=\"col-4 alert-light\">\r\n                                <h4> <i> Nombre de la Categoria </i></h4>\r\n                            </div>\r\n                        </div>\r\n\r\n                        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "row");
                __builder2.AddMarkupContent(29, "\r\n\r\n                            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-8 text-center form-row ");
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\CategoryDelete.razor"
                                                                               category.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.Name = __value, category.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-4 form-control");
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __Blazor.BlazorExpenseTracker.Pages.CategoryDelete.TypeInference.CreateValidationMessage_0(__builder2, 43, 44, 
#nullable restore
#line 38 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\CategoryDelete.razor"
                                                          ()=> category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "row");
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-8 text-center form-control");
                __builder2.AddMarkupContent(53, "\r\n                                <input type=\"submit\" value=\"Eliminar\">\r\n                                ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "type", "button");
                __builder2.AddAttribute(56, "value", "Cancelar ");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\CategoryDelete.razor"
                                                                                 Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\CategoryDelete.razor"
       

    [Parameter]
    public int id { get; set; }

    Category category = new Category();

    protected async override Task OnInitializedAsync()
    {
        if(id > 0)
            category = await CategoryService.GetCategoryDetails(id);
    }

    protected async Task DeleteCategory()
    {
        await CategoryService.DeleteCategory(id);

        NavigateToCategories();
    }

    public void Cancel()
    {
        NavigateToCategories();
    }

    public void NavigateToCategories()
    {
        NavigationManager.NavigateTo("/categories");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriService CategoryService { get; set; }
    }
}
namespace __Blazor.BlazorExpenseTracker.Pages.CategoryDelete
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
    }
}
#pragma warning restore 1591
