#pragma checksum "/Users/andriiivanytskyi/Desktop/ASP.NET/DojoDachi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad45fad7cba53a2bb096454a623de38d82e9f674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/DojoDachi/Views/_ViewImports.cshtml"
using DojoDachi;

#line default
#line hidden
#line 2 "/Users/andriiivanytskyi/Desktop/ASP.NET/DojoDachi/Views/_ViewImports.cshtml"
using DojoDachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad45fad7cba53a2bb096454a623de38d82e9f674", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bce70f5dafba3f05b5d94a87a662fc8c5511826", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/andriiivanytskyi/Desktop/ASP.NET/DojoDachi/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(47, 57, true);
            WriteLiteral("\r\n\r\n<h3 class=\"d-inline\">Happiness: <span id=\"happiness\">");
            EndContext();
            BeginContext(105, 17, false);
#line 7 "/Users/andriiivanytskyi/Desktop/ASP.NET/DojoDachi/Views/Home/Index.cshtml"
                                                Write(ViewBag.happiness);

#line default
#line hidden
            EndContext();
            BeginContext(122, 65, true);
            WriteLiteral("</span></h3>\r\n<h3 class=\"d-inline\">Fullness: <span id=\"fullness\">");
            EndContext();
            BeginContext(188, 16, false);
#line 8 "/Users/andriiivanytskyi/Desktop/ASP.NET/DojoDachi/Views/Home/Index.cshtml"
                                              Write(ViewBag.fullness);

#line default
#line hidden
            EndContext();
            BeginContext(204, 3270, true);
            WriteLiteral(@"</span></h3>
<h3 class=""d-inline"">Energy: <span id=""energy"">50</span></h3>
<h3 class=""d-inline"">Meals: <span id=""meals"">3</span></h3>

<h4 id=""message""></h4>
<div id=""buttons"">
    <button id=""1"" type=""button"" class=""btn btn-primary""> Feed </button>
    <button id=""2"" type=""button"" class=""btn btn-primary""> Play </button>
    <button id=""3"" type=""button"" class=""btn btn-primary""> Work </button>
    <button id=""4"" type=""button"" class=""btn btn-primary""> Sleep </button>
</div>

<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/n");
            WriteLiteral(@"JGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script>
    $(document).ready(function(){
        $(""#1"").click(function(){
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:5000/feed"",
                success: function(result){
                    if ($(""#meals"").text().toString() > 0){
                        $(""#fullness"").html(result);
                        $(""#meals"").html($(""#meals"").text().toString()-1)
                    }
                    else
                    {
                        alert(""Out of meal"");
                    }
                }
            })
        });
        $(""#2"").click(function(){
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:5000/play"",
                success: function(result){
                    if ($(""#energy"").text().toString() > 0){
                      ");
            WriteLiteral(@"  $(""#happiness"").html(result);
                        $(""#energy"").html($(""#energy"").text().toString()-5)
                    }
                    else
                    {
                        alert(""Tired, no energy"");
                    }
                }
            })
        });
        $(""#3"").click(function(){
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:5000/work"",
                data: $(""#meals"").text().toString(),
                datatype: ""JSON"",
                success: function(result){
                    if ($(""#energy"").text().toString() > 0){
                        $(""#meals"").html(result);
                        $(""#energy"").html($(""#energy"").text().toString()-5)
                    }
                    else
                    {
                        alert(""Tired, no energy"");
                    }
                }
            })
        });
        $(""#4"").click(function(){
            $.ajax({
     ");
            WriteLiteral("           type: \"GET\",\r\n                url: \"http://localhost:5000/feed\",\r\n                success: function(result){\r\n        \r\n                }\r\n            })\r\n        });\r\n    })\r\n</script>\r\n");
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
