#pragma checksum "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803929f90c86dfc9a2d79c164d40a80666e90eb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Liste), @"mvc.1.0.view", @"/Views/Home/Liste.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803929f90c86dfc9a2d79c164d40a80666e90eb7", @"/Views/Home/Liste.cshtml")]
    #nullable restore
    public class Views_Home_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<myLayout.Models.Tuto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
  
    ViewBag.Title = "Liste";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 class=\"titre\">Liste des tutos</h3>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>tutoriel</th>\r\n        <th>lien</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
           Write(item.Titre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
           Write(Html.ActionLink(item.Lien, "afficher tuto", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
            DefineSection("Menu", async() => {
                WriteLiteral("\r\n    <ul>\r\n        <li>");
#nullable restore
#line 23 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
       Write(Html.ActionLink("Accueil", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        <li class=\"selectionne\">");
#nullable restore
#line 24 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
                           Write(Html.ActionLink("Liste des tutoriels", "Liste"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 25 "C:\Users\fanti\OneDrive\Bureau\Projet .Net Vincent\Revision_Dotnet_J1\myLayout\myLayout\Views\Home\Liste.cshtml"
       Write(Html.ActionLink("Forum", "Forum"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n    </ul>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<myLayout.Models.Tuto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591