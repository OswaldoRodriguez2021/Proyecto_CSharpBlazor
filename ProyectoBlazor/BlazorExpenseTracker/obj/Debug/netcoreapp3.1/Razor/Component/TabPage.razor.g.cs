#pragma checksum "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Component\TabPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d12dc8a7b21d99abbaa48fd1f75213aa79761f0f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorExpenseTracker.Component
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
    public partial class TabPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Component\TabPage.razor"
 if (Parent.ActivePage == this)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 4 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Component\TabPage.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 4 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Component\TabPage.razor"
                 

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Udemy Aprende Blazor desde Cero\Proyecto\BlazorExpenseTracker\Component\TabPage.razor"
       

    [CascadingParameter]
    private TabControl Parent { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Text { get; set; }

    [Parameter]
    public string ImageSourse { get; set; }

    protected override Task OnInitializedAsync()
    {
        if (Parent == null)
            throw new ArgumentException(nameof(Parent), "No se encontro un tabControl ");

        Parent.AddPage(this);

        return base.OnInitializedAsync();

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
