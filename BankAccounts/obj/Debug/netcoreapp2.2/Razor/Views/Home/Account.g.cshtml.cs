#pragma checksum "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a31116e9a60a176893a78f6b37bca371356dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Account), @"mvc.1.0.view", @"/Views/Home/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Account.cshtml", typeof(AspNetCore.Views_Home_Account))]
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
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/_ViewImports.cshtml"
using BankAccounts;

#line default
#line hidden
#line 2 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/_ViewImports.cshtml"
using BankAccounts.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a31116e9a60a176893a78f6b37bca371356dca", @"/Views/Home/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ab2bbabc92c6356fc62571bc80cd8c3b7b2f62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompleteUserNamespace.Models.CompleteUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTransactionProcess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
  
    ViewData["Title"] = "Account";

#line default
#line hidden
            BeginContext(40, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(90, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(96, 17, false);
#line 7 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(113, 17, true);
            WriteLiteral("</h1>\n\n<h3>User: ");
            EndContext();
            BeginContext(131, 26, false);
#line 9 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
     Write(Model.UserItself.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(157, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(159, 25, false);
#line 9 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
                                 Write(Model.UserItself.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(184, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 10 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
  
    int total = 0;
    foreach (var transaction in @Model.UserTransaction)
    {
        total += transaction.Amount;
    }

#line default
#line hidden
            BeginContext(319, 13, true);
            WriteLiteral("<h4>Balance: ");
            EndContext();
            BeginContext(333, 5, false);
#line 17 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
        Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(338, 10, true);
            WriteLiteral("</h4>\n<h4>");
            EndContext();
            BeginContext(349, 32, false);
#line 18 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
Write(ViewBag.TransactionStatusMessage);

#line default
#line hidden
            EndContext();
            BeginContext(381, 135, true);
            WriteLiteral("</h4>\n\n<table class=\"table\">\n<thead>\n    <tr>\n    <th scope=\"col\">Amount</th>\n    <th scope=\"col\">Date</th>\n    </tr>\n</thead>\n<tbody>\n");
            EndContext();
#line 28 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
      
        foreach (var transaction in @Model.UserTransaction)
        {

#line default
#line hidden
            BeginContext(593, 33, true);
            WriteLiteral("            <tr>\n            <td>");
            EndContext();
            BeginContext(627, 18, false);
#line 32 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
           Write(transaction.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(645, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(668, 21, false);
#line 33 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
           Write(transaction.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(689, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 35 "/Users/andriiivanytskyi/Desktop/ASP.NET/BankAccounts/Views/Home/Account.cshtml"
        }
    

#line default
#line hidden
            BeginContext(729, 34, true);
            WriteLiteral("</tbody>\n</table>\n\n<br>\n<br>\n<hr>\n");
            EndContext();
            BeginContext(763, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a31116e9a60a176893a78f6b37bca371356dca7621", async() => {
                BeginContext(826, 214, true);
                WriteLiteral("\n    <div class=\"form-group\">\n        <label>Initiate Transaction</label>\n        <input class=\"form-control\" name=\"TransactionAmount\">\n    </div>\n    <button type=\"submit\" class=\"btn btn-primary\">Proceed</button>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompleteUserNamespace.Models.CompleteUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
