#pragma checksum "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Views/Inference/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9335b891e4f81c9239bb9de3a7b75473d6e0e65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inference_Result), @"mvc.1.0.view", @"/Views/Inference/Result.cshtml")]
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
#line 1 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Views/_ViewImports.cshtml"
using AuthLab2_RyanPinkney.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9335b891e4f81c9239bb9de3a7b75473d6e0e65", @"/Views/Inference/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07aef4f92fa6ae76492722e648b335c87d38aaab", @"/Views/_ViewImports.cshtml")]
    public class Views_Inference_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prediction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            WriteLiteral("\n<div class=\"container\"></div>\n    <div class=\"row\">\n        <div class=\"col-1\">\n\n        </div>\n        <div class=\"col text-center\">\n            <h3>Here is the predicted crash severity</h3>\n            <h1>Score: ");
#nullable restore
#line 17 "/Users/ryanpinkney/Documents/GitHub/isgangintex4.0/AuthLab2_RyanPinkney/Views/Inference/Result.cshtml"
                  Write(Model.PredictedValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n\n        </div>\n\n\n    </div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prediction> Html { get; private set; }
    }
}
#pragma warning restore 1591