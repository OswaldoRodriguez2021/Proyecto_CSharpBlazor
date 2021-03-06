#pragma checksum "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c05f9c30df0a37063328084d7656761b8eeeccf4"
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
    public partial class ExpenseHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Historial </h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
    Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 7 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
 if (expenses == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p><em>No se encontraron datos ... </em></p>\r\n");
#nullable restore
#line 10 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
}
else
{ 

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.AddMarkupContent(9, "\r\n\r\n        ");
            __builder.AddMarkupContent(10, @"<div class=""row"">
            <div class=""col-4 alert-light"">
                <h4> <i> Monto </i> </h4>
            </div>
            <div class=""col-4 alert-light"">
                <h4> <i> Nombre de la Categoria </i> </h4>
            </div>
            <div class=""col-4 alert-light"">
                <h4> <i> Fecha </i> </h4>
            </div>
        </div>

");
#nullable restore
#line 27 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
         foreach (var expense in expenses)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row table-hover");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
                                                     () => SelectedExpenseChange(expense.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n            \r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-4 alert-success");
            __builder.AddAttribute(18, "style", 
#nullable restore
#line 31 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
                                                         GetTextColor(expense.id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
                     expense.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            \r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", " col-4 alert-success");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
                     expense.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            \r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-4 alert-success");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.AddContent(32, 
#nullable restore
#line 40 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
                     expense.TransactionDate.ToString("dd-MM-yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 44 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
         }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 48 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Pages\ExpenseHistory.razor"
       

    public IEnumerable<Expense> expenses { get; set; }
    public string Message { get; set; }
    [CascadingParameter] protected Expense SelectedExpense { get; set;}

    protected async Task SelectedExpenseChange(int expenseId)
    {
        var expense = await ExpenseService.GetExpenseDetails(expenseId);
        SelectedExpense.SelectedExpenseChange(expense);

    }

    protected override async Task OnParametersSetAsync()
    {
        try
        {
            expenses = (await ExpenseService.GetAllExpense());

        }
        catch (Exception e)
        {
            Message = "Error inesperado " + e.Message;
        }

    }


    protected string GetTextColor(int expenseId)
    {
        var exp = expenses.FirstOrDefault(e => e.id == expenseId);
        return exp.ExpenseType == ExpenseType.Income ? "color:green" : "color:red";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExpenseService ExpenseService { get; set; }
    }
}
#pragma warning restore 1591
