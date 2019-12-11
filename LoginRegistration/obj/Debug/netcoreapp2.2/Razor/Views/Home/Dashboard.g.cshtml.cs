#pragma checksum "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1741e1c7ff6cccc586834c8c17cc22eec05f103f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/_ViewImports.cshtml"
using LoginRegistration;

#line default
#line hidden
#line 2 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/_ViewImports.cshtml"
using LoginRegistration.Models;

#line default
#line hidden
#line 4 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/_ViewImports.cshtml"
using WeddingWrapperNamespace.Models;

#line default
#line hidden
#line 5 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/_ViewImports.cshtml"
using IndexViewModelNamespace.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1741e1c7ff6cccc586834c8c17cc22eec05f103f", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c96bb58b84e9847f07d1af38f0dac4f65f19594", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingWrapper>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(42, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(47, 17, false);
#line 4 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
            BeginContext(93, 207, true);
            WriteLiteral("\n<table class=\"table\">\n  <thead>\n    <tr>\n      <th scope=\"col\">Wedding</th>\n      <th scope=\"col\">Date</th>\n      <th scope=\"col\">Guest</th>\n      <th scope=\"col\">Action</th>\n    </tr>\n  </thead>\n  <tbody>\n");
            EndContext();
#line 18 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
        
          foreach (var wedding in @Model.Weddings)
          {

#line default
#line hidden
            BeginContext(372, 50, true);
            WriteLiteral("            <tr>\n            <td>\n              <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 422, "\"", 459, 2);
            WriteAttributeValue("", 429, "WeddingInfo/", 429, 12, true);
#line 23 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 441, wedding.WeddingId, 441, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(462, 23, false);
#line 23 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
                                                  Write(wedding.User1.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(485, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(491, 23, false);
#line 23 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
                                                                               Write(wedding.User2.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(514, 39, true);
            WriteLiteral("</a>\n            </td>\n            <td>");
            EndContext();
            BeginContext(554, 12, false);
#line 25 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
           Write(wedding.Date);

#line default
#line hidden
            EndContext();
            BeginContext(566, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(589, 28, false);
#line 26 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
           Write(wedding.UsersAttending.Count);

#line default
#line hidden
            EndContext();
            BeginContext(617, 23, true);
            WriteLiteral("</td>\n            <td>\n");
            EndContext();
#line 28 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
                
                if(@wedding.User2Id == @Model.User.UserId || @wedding.User1Id == @Model.User.UserId)
                {

#line default
#line hidden
            BeginContext(776, 20, true);
            WriteLiteral("                  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 796, "\"", 842, 2);
            WriteAttributeValue("", 803, "DeleteWeddingProcess/", 803, 21, true);
#line 31 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 824, wedding.WeddingId, 824, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(843, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 32 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
                }
                else
                {
                  if(@wedding.UsersAttending.Intersect(@Model.User.WeddingsAttending).Any())
                  {

#line default
#line hidden
            BeginContext(1025, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1086, 2);
            WriteAttributeValue("", 1054, "GetOutProcess/", 1054, 14, true);
#line 37 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1068, wedding.WeddingId, 1068, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1087, 13, true);
            WriteLiteral(">Get Out</a>\n");
            EndContext();
#line 38 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
                  }
                  else
                  {

#line default
#line hidden
            BeginContext(1163, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1229, 2);
            WriteAttributeValue("", 1192, "JoinWeddingProcess/", 1192, 19, true);
#line 41 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1211, wedding.WeddingId, 1211, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1230, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 42 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
                  }
                  }
              

#line default
#line hidden
            BeginContext(1296, 36, true);
            WriteLiteral("            </td>\n            </tr>\n");
            EndContext();
#line 47 "/Users/andriiivanytskyi/Desktop/ASP.NET/LoginRegistration/Views/Home/Dashboard.cshtml"
          }
      

#line default
#line hidden
            BeginContext(1352, 95, true);
            WriteLiteral("  </tbody>\n</table>\n\n<a class=\"btn btn-primary\" href=\"NewWedding\" role=\"button\">New Wedding</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeddingWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591