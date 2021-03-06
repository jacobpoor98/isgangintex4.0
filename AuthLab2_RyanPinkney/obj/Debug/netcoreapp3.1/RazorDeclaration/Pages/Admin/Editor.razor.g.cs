// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AuthLab2_RyanPinkney.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/_Imports.razor"
using AuthLab2_RyanPinkney.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/edit/{id:long}")]
    public partial class Editor : OwningComponentBase<ICrashRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Editor.razor"
       

    [Parameter]
    public long Id { get; set; }


    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

    public Accident a { get; set; } = new Accident();

    public ICrashRepository repo => Service;

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            a = repo.Accidents.FirstOrDefault(x => x.crash_id == Id);
        }
    }


    public void SaveRecord()
    {
        if (Id == 0)
        {

            var oSingleTimeMax = repo.Accidents.OrderByDescending(u => u.crash_id).FirstOrDefault();

            a.crash_id = oSingleTimeMax.crash_id + 1;


            repo.AddAccident(a);
        }
        else
        {
            repo.EditAccident(a);
        }

        NavManager.NavigateTo("/admin", true);
    }

    [Inject]
    public NavigationManager NavManager { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
