#pragma checksum "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4624eae1bfcf419fd9803b96fbec6cad3a20d8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/_ViewImports.cshtml"
using CRUDellicious;

#line default
#line hidden
#line 2 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/_ViewImports.cshtml"
using CRUDellicious.Models;

#line default
#line hidden
#line 4 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4624eae1bfcf419fd9803b96fbec6cad3a20d8c7", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e735ea841aab5e09ab4ef1c4d7192f0987d826b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
            BeginContext(37, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(43, 17, false);
#line 5 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(60, 17, true);
            WriteLiteral("</h1>\n\n<h2>Name: ");
            EndContext();
            BeginContext(78, 17, false);
#line 7 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
     Write(ViewBag.Dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(95, 20, true);
            WriteLiteral("</h2>\n<h2>Calories: ");
            EndContext();
            BeginContext(116, 21, false);
#line 8 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
         Write(ViewBag.Dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(137, 21, true);
            WriteLiteral("</h2>\n<h2>Tastiness: ");
            EndContext();
            BeginContext(159, 22, false);
#line 9 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
          Write(ViewBag.Dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(181, 23, true);
            WriteLiteral("</h2>\n<h2>Description: ");
            EndContext();
            BeginContext(205, 24, false);
#line 10 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
            Write(ViewBag.Dish.Description);

#line default
#line hidden
            EndContext();
            BeginContext(229, 33, true);
            WriteLiteral("</h2>\n\n<a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 262, "\"", 292, 2);
            WriteAttributeValue("", 269, "delete/", 269, 7, true);
#line 12 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
WriteAttributeValue("", 276, ViewBag.Dish.Id, 276, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(293, 38, true);
            WriteLiteral(">Delete</a>\n<a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 331, "\"", 359, 2);
            WriteAttributeValue("", 338, "edit/", 338, 5, true);
#line 13 "/Users/andriiivanytskyi/Desktop/ASP.NET/CRUDellicious/Views/Home/Info.cshtml"
WriteAttributeValue("", 343, ViewBag.Dish.Id, 343, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(360, 9, true);
            WriteLiteral(">Edit</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591