#pragma checksum "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313cced8830f2949c79b81cfcf0c1432abc4be9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Edit), @"mvc.1.0.view", @"/Views/Flavors/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313cced8830f2949c79b81cfcf0c1432abc4be9d", @"/Views/Flavors/Edit.cshtml")]
    public class Views_Flavors_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PierreSweets.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this flavor: ");
#nullable restore
#line 9 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
Write(Html.HiddenFor(model => model.FlavorId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
Write(Html.LabelFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
Write(Html.EditorFor(model => model.FlavorName, new { @required  = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 20 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 22 "/Users/Wajma/Desktop/Project_Sweets/PierreSweets/Views/Flavors/Edit.cshtml"
Write(Html.ActionLink("Back to flavor", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PierreSweets.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
