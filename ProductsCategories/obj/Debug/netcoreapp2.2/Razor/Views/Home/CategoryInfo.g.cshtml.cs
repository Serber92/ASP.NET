#pragma checksum "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed9bf584ec4b7402258736bd84a5e6c04282f9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CategoryInfo), @"mvc.1.0.view", @"/Views/Home/CategoryInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CategoryInfo.cshtml", typeof(AspNetCore.Views_Home_CategoryInfo))]
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
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/_ViewImports.cshtml"
using ProductsCategories;

#line default
#line hidden
#line 2 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/_ViewImports.cshtml"
using ProductsCategories.Models;

#line default
#line hidden
#line 4 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/_ViewImports.cshtml"
using AllProductsNamespace.Models;

#line default
#line hidden
#line 5 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/_ViewImports.cshtml"
using AllCategoriesNamespace.Models;

#line default
#line hidden
#line 6 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/_ViewImports.cshtml"
using ProductCategoryWraperNamespace.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed9bf584ec4b7402258736bd84a5e6c04282f9e", @"/Views/Home/CategoryInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22266847eff2d611c63b572adff9139ff874442", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CategoryInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryWraper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProductToCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
  
    ViewData["Title"] = "Category Info";

#line default
#line hidden
            BeginContext(46, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(51, 17, false);
#line 4 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
            BeginContext(104, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(110, 19, false);
#line 8 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(129, 95, true);
            WriteLiteral("</h2>\n\n<hr>\n<div class=\"d-inline\" style=\"width: 48%; float:left\">\n  <h3>Products: </h3>\n  <ul>\n");
            EndContext();
#line 14 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
      
        foreach (var sub in @Model.Category.Products)
        {

#line default
#line hidden
            BeginContext(295, 31, true);
            WriteLiteral("            <li>\n              ");
            EndContext();
            BeginContext(327, 16, false);
#line 18 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
         Write(sub.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(343, 19, true);
            WriteLiteral("\n            </li>\n");
            EndContext();
#line 20 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
        }
    

#line default
#line hidden
            BeginContext(378, 175, true);
            WriteLiteral("  </ul>\n</div>\n<div class=\"d-inline\" style=\"width: 48%; float:right\">\n  <h3>Add Product: </h3>\n  <div class=\"input-group mb-3\">\n  <div class=\"input-group-prepend\">\n  </div>\n  ");
            EndContext();
            BeginContext(553, 361, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ed9bf584ec4b7402258736bd84a5e6c04282f9e6724", async() => {
                BeginContext(615, 54, true);
                WriteLiteral("\n    <select class=\"custom-select\" name=\"CategoryId\">\n");
                EndContext();
#line 31 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
        
        foreach (var product in @Model.Products)
        {

#line default
#line hidden
                BeginContext(737, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(749, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ed9bf584ec4b7402258736bd84a5e6c04282f9e7475", async() => {
                    BeginContext(785, 12, false);
#line 34 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
                                          Write(product.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 34 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
               WriteLiteral(product.ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(806, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 35 "/Users/andriiivanytskyi/Desktop/ASP.NET/ProductsCategories/Views/Home/CategoryInfo.cshtml"
        }
      

#line default
#line hidden
                BeginContext(825, 82, true);
                WriteLiteral("    </select>\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(914, 14, true);
            WriteLiteral("\n</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryWraper> Html { get; private set; }
    }
}
#pragma warning restore 1591
