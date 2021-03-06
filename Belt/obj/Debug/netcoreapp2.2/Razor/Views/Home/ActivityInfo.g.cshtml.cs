#pragma checksum "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e37ca6f0fcc24cc9c7fe98d636086fc09cc9e150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ActivityInfo), @"mvc.1.0.view", @"/Views/Home/ActivityInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ActivityInfo.cshtml", typeof(AspNetCore.Views_Home_ActivityInfo))]
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
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/_ViewImports.cshtml"
using Belt;

#line default
#line hidden
#line 2 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/_ViewImports.cshtml"
using Belt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37ca6f0fcc24cc9c7fe98d636086fc09cc9e150", @"/Views/Home/ActivityInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e4a4d40ef26079d3b4684d0bc32675f7e799b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ActivityInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wrapper>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(21, 20, false);
#line 3 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
Write(Model.Activity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(41, 30, true);
            WriteLiteral("</h2>\n\n<h3>Event Coordinator: ");
            EndContext();
            BeginContext(72, 27, false);
#line 5 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
                  Write(Model.Activity.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(99, 38, true);
            WriteLiteral("</h3>\n\n<h2>Description: </h2>\n<br>\n<p>");
            EndContext();
            BeginContext(138, 26, false);
#line 9 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
Write(Model.Activity.Description);

#line default
#line hidden
            EndContext();
            BeginContext(164, 31, true);
            WriteLiteral("</p>\n\n<h4>Participants: </h4>\n\n");
            EndContext();
#line 13 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
  
    foreach (var sub in @Model.Activity.Participants)
    {

#line default
#line hidden
            BeginContext(258, 9, true);
            WriteLiteral("      <p>");
            EndContext();
            BeginContext(268, 13, false);
#line 16 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
    Write(sub.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(281, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 17 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(294, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 20 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
  
  if(@Model.User.UserId == @Model.Activity.Creator.UserId)
  {

#line default
#line hidden
            BeginContext(361, 30, true);
            WriteLiteral("    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 391, "\"", 431, 2);
            WriteAttributeValue("", 398, "Delete/", 398, 7, true);
#line 23 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
WriteAttributeValue("", 405, Model.Activity.ActivityId, 405, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(432, 26, true);
            WriteLiteral(" role=\"button\">Delete</a>\n");
            EndContext();
#line 24 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
  }
  else
  {
    if(@Model.Activity.Participants.Intersect(@Model.User.ActivitiesJoined).Any())
    {

#line default
#line hidden
            BeginContext(562, 32, true);
            WriteLiteral("      <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 594, "\"", 641, 2);
            WriteAttributeValue("", 601, "LeaveActivity/", 601, 14, true);
#line 29 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
WriteAttributeValue("", 615, Model.Activity.ActivityId, 615, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(642, 25, true);
            WriteLiteral(" role=\"button\">Leave</a>\n");
            EndContext();
#line 30 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(688, 32, true);
            WriteLiteral("      <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 720, "\"", 766, 2);
            WriteAttributeValue("", 727, "JoinActivity/", 727, 13, true);
#line 33 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
WriteAttributeValue("", 740, Model.Activity.ActivityId, 740, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(767, 24, true);
            WriteLiteral(" role=\"button\">Join</a>\n");
            EndContext();
#line 34 "/Users/andriiivanytskyi/Desktop/ASP.NET/Belt/Views/Home/ActivityInfo.cshtml"
    }
  }

#line default
#line hidden
            BeginContext(803, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
