#pragma checksum "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9ef3ff9c96d36c08b4d1677eaeac5e3d43f375"
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
#nullable restore
#line 3 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ExpenseTracker")]
    public partial class ExpenseTracker : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ExpenseTracker</h3>\r\n\r\n");
            __Blazor.BlazorExpenseTracker.Pages.ExpenseTracker.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#nullable restore
#line 9 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor"
                       expense

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n\r\n    ");
                __builder2.OpenComponent<BlazorExpenseTracker.Component.TabControl>(5);
                __builder2.AddAttribute(6, "TabTitle", (Microsoft.AspNetCore.Components.RenderFragment<BlazorExpenseTracker.Component.TabPage>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n            ");
                    __builder3.OpenElement(8, "img");
                    __builder3.AddAttribute(9, "src", "Images/" + (
#nullable restore
#line 14 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor"
                               context.ImageSourse

#line default
#line hidden
#nullable disable
                    ) + ".png");
                    __builder3.AddAttribute(10, "style", "width:40px; height:40px");
                    __builder3.CloseElement();
                    __builder3.AddContent(11, "  ");
                    __builder3.AddContent(12, 
#nullable restore
#line 14 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor"
                                                                                              context.Text

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(13, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n            \r\n            ");
                    __builder3.OpenComponent<BlazorExpenseTracker.Component.TabPage>(16);
                    __builder3.AddAttribute(17, "Text", "Expense");
                    __builder3.AddAttribute(18, "ImageSourse", "minus");
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(20, "\r\n                ");
                        __builder4.OpenComponent<BlazorExpenseTracker.Pages.ExpenseDetails>(21);
                        __builder4.AddAttribute(22, "ExpenseType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorExpenseTracker.Model.ExpenseType>(
#nullable restore
#line 20 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor"
                                              Model.ExpenseType.Expense

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n\r\n            ");
                    __builder3.OpenComponent<BlazorExpenseTracker.Component.TabPage>(25);
                    __builder3.AddAttribute(26, "Text", "Income");
                    __builder3.AddAttribute(27, "ImageSourse", "Plus");
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "\r\n                ");
                        __builder4.OpenComponent<BlazorExpenseTracker.Pages.ExpenseDetails>(30);
                        __builder4.AddAttribute(31, "ExpenseType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorExpenseTracker.Model.ExpenseType>(
#nullable restore
#line 24 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor"
                                              Model.ExpenseType.Income

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n\r\n    ");
                __builder2.OpenComponent<BlazorExpenseTracker.Pages.ExpenseHistory>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n     \r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseTracker.razor"
       
    public Expense expense;

    protected override Task OnInitializedAsync()
    {
        expense = new Expense();
        expense.OnSelectedExpenseChanged += StateHasChanged;

        return base.OnInitializedAsync();

    }

    public void Dispose()
    {
        expense.OnSelectedExpenseChanged -= StateHasChanged;

    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorExpenseTracker.Pages.ExpenseTracker
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591