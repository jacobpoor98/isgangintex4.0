#pragma checksum "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29aaf15b2afa3cf872466780799404ec8cb9fdbb"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/")]
    public partial class Crashes : OwningComponentBase<ICrashRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-4");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<h5>Search for a record (Crash_ID):</h5>\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "type", "number");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 136 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                          Filter

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                        x => FilterData(Filter)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 141 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                        x => UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Reset All");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        <br>\n        <br>\n\n\n        \n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "href", "admin/crashes/create");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Create New Report");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\n        <br>\n        <br>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-8");
            __builder.AddMarkupContent(36, "\n        ");
            __builder.OpenElement(37, "table");
            __builder.AddAttribute(38, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(39, "\n\n\n            ");
            __builder.AddMarkupContent(40, @"<thead>
                <tr>
                    <th>Crash_ID</th>
                    <th>Date</th>
                    <th>Route</th>
                    <th>Road</th>
                    <th>City</th>
                    <th>County</th>
                    <th>Severity</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\n");
#nullable restore
#line 181 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                 if (AccidentData?.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                     foreach (Accident a in AccidentData)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                        ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\n                            ");
            __builder.OpenElement(46, "th");
#nullable restore
#line 186 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
__builder.AddContent(47, a.crash_id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                            <th></th>\n                            ");
            __builder.OpenElement(49, "th");
#nullable restore
#line 188 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
__builder.AddContent(50, a.route);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n                            ");
            __builder.OpenElement(52, "th");
#nullable restore
#line 189 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
__builder.AddContent(53, a.main_road_name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                            ");
            __builder.OpenElement(55, "th");
#nullable restore
#line 190 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
__builder.AddContent(56, a.city);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n                            ");
            __builder.OpenElement(58, "th");
#nullable restore
#line 191 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
__builder.AddContent(59, a.county_name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                            ");
            __builder.OpenElement(61, "th");
#nullable restore
#line 192 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
__builder.AddContent(62, a.crash_severity_id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n\n\n                            \n                            ");
            __builder.OpenElement(64, "td");
            __builder.AddMarkupContent(65, "\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(66);
            __builder.AddAttribute(67, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(68, "href", 
#nullable restore
#line 197 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                                               GetEditUrl(a.crash_id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(70, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n\n                            \n                            ");
            __builder.OpenElement(73, "td");
            __builder.AddMarkupContent(74, "\n                                ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 202 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                                                  x => RemoveAccident(a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n");
#nullable restore
#line 205 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "row");
            __builder.AddMarkupContent(89, "\n    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-6 text-right");
            __builder.AddMarkupContent(92, "\n        ");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "class", "btn btn-secondary btn-sm");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 213 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                             x => firstPage(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(96, "First");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n");
#nullable restore
#line 214 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
         if (skipCount >= 50)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "            ");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "class", "btn btn-secondary m-l-2 btn-sm");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 216 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                                       x => previousPage(50)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(102, "Previous Page");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n");
#nullable restore
#line 217 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "            ");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "class", "btn btn-secondary m-l-2 btn-sm disabled");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 220 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                                                x => previousPage(50)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(108, "Previous Page");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n");
#nullable restore
#line 221 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "col-6");
            __builder.AddMarkupContent(114, "\n");
#nullable restore
#line 224 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
         if (skipCount >= 249950)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "            ");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "class", "btn btn-secondary m-l-2 btn-sm disabled");
            __builder.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 226 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                                                x => nextPage(50, City)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(119, "Next Page");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\n");
#nullable restore
#line 227 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "            ");
            __builder.OpenElement(122, "button");
            __builder.AddAttribute(123, "class", "btn btn-secondary m-l-2 btn-sm");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 230 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                                       x => nextPage(50, City)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(125, "Next Page");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\n");
#nullable restore
#line 231 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "        ");
            __builder.OpenElement(128, "button");
            __builder.AddAttribute(129, "class", "btn btn-secondary btn-sm");
            __builder.AddAttribute(130, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 232 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
                                                             x => lastPage(249950)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(131, "Last");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\n<br>\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Pages/Admin/Crashes.razor"
       

    [Parameter]
    public int Id { get; set; }

    public ICrashRepository repo => Service;

    public IEnumerable<Accident> AccidentData { get; set; }

    public int Filter { get; set; }

    public string City { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        int p = 50;

        AccidentData = await repo.Accidents
            .Take(p)
            .OrderByDescending(u => u.crash_id)
            .ToListAsync();
    }

    public async Task FilterData(int Filter)
    {
        AccidentData = await repo.Accidents
            .Where(x => x.crash_id == Filter)
            .OrderByDescending(u => u.crash_id)
            .ToListAsync();
    }

    public async Task FilterData2(string City)
    {
        AccidentData = await repo.Accidents
            .Where(x => x.city == City)
            .OrderByDescending(u => u.crash_id)
            .ToListAsync();
    }

    public int skipCount { get; set; }

    public async Task nextPage(int skip, string City)
    {
        if (skipCount >= 50)
        {
            skipCount += skip;
        }
        else
        {
            skipCount = skip;
        }

        AccidentData = await repo.Accidents
            .Skip(skipCount)
            .Take(50)
            .OrderByDescending(u => u.crash_id)
            .ToListAsync();
    }

    public async Task previousPage(int skip)
    {

        if (skipCount >= 50)
        {
            skipCount -= skip;
        }
        else
        {
            skipCount = skip;
        }

        AccidentData = await repo.Accidents
            .Skip(skipCount)
            .Take(50)
            .OrderByDescending(u => u.crash_id)
            .ToListAsync();
    }

    public async Task firstPage(int skip)
    {
        skipCount = skip;
        AccidentData = await repo.Accidents
            .Skip(skipCount)
            .Take(50)
            .OrderByDescending(u => u.crash_id)
            .ToListAsync();
    }

    public async Task lastPage(int skip)
    {
        skipCount = skip;
        AccidentData = await repo.Accidents
            .Skip(skipCount)
            .Take(50)
            .OrderByDescending(u => u.crash_id)
            .ToListAsync();
    }

    public string GetEditUrl(long id) => $"/admin/crashes/edit/{id}";

    public string GetNextUrl(int id) => $"/admin/crashes/{id}";

    public async Task RemoveAccident(Accident a)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete the record?");
        if (confirmed)
        {
            repo.DeleteAccident(a);
            await UpdateData();
        }
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
