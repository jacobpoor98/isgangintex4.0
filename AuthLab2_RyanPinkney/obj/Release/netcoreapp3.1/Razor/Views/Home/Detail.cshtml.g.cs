#pragma checksum "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ce6492902b879c002ddc61486cae47090cc2b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce6492902b879c002ddc61486cae47090cc2b30", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07aef4f92fa6ae76492722e648b335c87d38aaab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Accident>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!--Link the model for this page-->\n");
            WriteLiteral("<!-- Page Title-->\n<h2 class=\"ml-2\">Details:</h2>\n\n\n<h5 class=\"text-center\">Crash ID: ");
#nullable restore
#line 15 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                             Write(ViewBag.Single.crash_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n\n<div class=\"row\">\n    <div class=\"col-3\">\n        <!-- displays all details related to an incident when \'details\' button is clicked on a record -->\n        <div class=\"text-center\">\n            <p>Date: </p>\n            <p>Route: ");
#nullable restore
#line 23 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                 Write(ViewBag.Single.route);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Milepoint: ");
#nullable restore
#line 24 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                     Write(ViewBag.Single.milepoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Latitude: ");
#nullable restore
#line 25 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                    Write(ViewBag.Single.lat_utm_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Longitude: ");
#nullable restore
#line 26 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                     Write(ViewBag.Single.long_utm_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Main Road: ");
#nullable restore
#line 27 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                     Write(ViewBag.Single.main_road_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>City: ");
#nullable restore
#line 28 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                Write(ViewBag.Single.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>County: ");
#nullable restore
#line 29 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                  Write(ViewBag.Single.county_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Work Zone: ");
#nullable restore
#line 30 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                     Write(ViewBag.Single.work_zone_related_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Pedestrians Involved: ");
#nullable restore
#line 31 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                                Write(ViewBag.Single.pedestrian_involved_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Bicyclist Involved: ");
#nullable restore
#line 32 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                              Write(ViewBag.Single.bicyclist_involved_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Night Conditions: ");
#nullable restore
#line 33 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                            Write(ViewBag.Single.night_dark_condition_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Distracted Driving: ");
#nullable restore
#line 34 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                              Write(ViewBag.Single.distracted_driving_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Drowsy Driving: ");
#nullable restore
#line 35 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                          Write(ViewBag.Single.drowsy_driving_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n        </div>\n\n    </div>\n    <div class=\"col\">\n\n        <div class=\"text-center\">\n            <p>Motorcycle Involved: ");
#nullable restore
#line 44 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                               Write(ViewBag.Single.motorcycle_involved_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Improper Restraint: ");
#nullable restore
#line 45 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                              Write(ViewBag.Single.improper_restraint_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Unrestrained: ");
#nullable restore
#line 46 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                        Write(ViewBag.Single.unrestrained_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>DUI: ");
#nullable restore
#line 47 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
               Write(ViewBag.Single.dui_true);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Related to an Intersection: ");
#nullable restore
#line 48 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                                      Write(ViewBag.Single.intersection_related_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Wild Animal: ");
#nullable restore
#line 49 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                       Write(ViewBag.Single.wild_animal_related_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Domestic Animal: ");
#nullable restore
#line 50 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                           Write(ViewBag.Single.domestic_animal_related_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Rolloever or Overturn: ");
#nullable restore
#line 51 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                                 Write(ViewBag.Single.overturn_rollover_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Commercial Vehicle Involved: ");
#nullable restore
#line 52 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                                       Write(ViewBag.Single.commercial_motor_veh_involved_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Teenage Driver: ");
#nullable restore
#line 53 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                          Write(ViewBag.Single.teenage_driver_involved_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Older Driver: ");
#nullable restore
#line 54 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                        Write(ViewBag.Single.older_driver_involved_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Single Vehicle: ");
#nullable restore
#line 55 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                          Write(ViewBag.Single.single_vehicle_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Roadway Departure: ");
#nullable restore
#line 56 "/Users/jacob.poor98/Documents/GitHub/isgangintex3.0/AuthLab2_RyanPinkney/Views/Home/Detail.cshtml"
                             Write(ViewBag.Single.roadway_departure_True);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n\n        </div>\n\n\n\n    </div>\n\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Accident> Html { get; private set; }
    }
}
#pragma warning restore 1591
