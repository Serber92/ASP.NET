#pragma checksum "/Users/andriiivanytskyi/Desktop/ASP.NET/portfolio/Views/first/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d0ebb43e8c6b8c10a6ed8bb3e91681184e4c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_first_index), @"mvc.1.0.view", @"/Views/first/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/first/index.cshtml", typeof(AspNetCore.Views_first_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d0ebb43e8c6b8c10a6ed8bb3e91681184e4c02", @"/Views/first/index.cshtml")]
    public class Views_first_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!doctype html>\n<html lang=\"en\">\n  ");
            EndContext();
            BeginContext(35, 437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85d0ebb43e8c6b8c10a6ed8bb3e91681184e4c022855", async() => {
                BeginContext(41, 424, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
  
    <title>Main</title>
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(472, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(475, 11531, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85d0ebb43e8c6b8c10a6ed8bb3e91681184e4c024454", async() => {
                BeginContext(481, 11518, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-secondary"">
      <a class=""navbar-brand"" href=""#"">Portfolio</a>
      <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
      </button>

      <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
        <ul class=""navbar-nav mr-auto"">
          <li class=""nav-item active"">
            <a class=""nav-link"" href=""http://localhost:5000"">Main <span class=""sr-only"">(current)</span></a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""http://localhost:5000/projects"">Projects</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""http://localhost:5000/contact"">Contact</a>
          </li>
    </nav>

    <div class=""span3 well"">
        <img src=""data:image/png;base64,iVBORw0KGgoA");
                WriteLiteral(@"AAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAkFBMVEX///8AAAD7+/v+/v79/f38/PwBAQH39/fv7+/09PTs7OzOzs7b29vg4ODR0dF9fX0lJSW1tbV8fHyMjIw1NTXd3d2kpKQYGBiTk5PCwsKDg4OamppRUVFEREQuLi5mZmZdXV1ycnIeHh4+Pj6ysrJNTU1XV1eIiIgUFBSfn59DQ0NtbW3GxsYODg4qKioXFxd0ZZ8TAAAbfklEQVR4nO1dB5fjqg4mLnHPxGljpzp9Min7///dsw3Cptmkzc7e8zjn7vgmAvSBQEISDkKqYqofHqFtILmH9mE2TbP1waweXkH74uYaaPH/WeTB4h9MyxQeBFqR5B5aFQ9azbXTYjobf2za1QN8Y3EP9qtpTYEWtdDe0zWWWcvAH5uGYcIDqWCQJmxCggye1mqiNRW0Nk/b2PU9tBybWFZNW7+X+wCqaAWmZYPxEECezVJmQXJ/GcBnZpt2jecO5PXlAB9iWkUrdK3HJqrKL5vB1q7vYfNfAPiQiD4PsHEr0xZRHdrfOINPrcH/i+hdAE38/W8C+BI1QWlLjU+NoV8hoi9dg4LGfw1A7Rl8+xok5mil8X8Y4NvXICX5RQBfKqK0ubtrvkYPvn0NPg7wHzHV/gWAT67BvyuiP7gGica/v+ZvVxOEFrujLPuHAf6ciFpE4/8CgC811WpsFt+AW/G/Y6qJbL4EoMxvoCiVEfXeNfgOgEVx/HGvF6S7yWw4nU4/BmX5yB+PyWkSp0EQ9CLfa+z6VSL6OoDYL+v04uS8WG66nfby2V9u5+tZnPZcysMvnkFkeOksYxAQlN2u+CDC3Q5O8dih4v1igObTAN10umBxVTDED4QHWparYRoVM2q9FmCpLuyHAbq77KvDMd0wccJDRYL/bObTNHolQHz2hfjNfQDzby6rumCquW+fym59TjfnHUZJenoCoI01vvlITeRNrs2CqFHU034dDGezySSl2+6DK+lRgBZyk24Trs/RfnVeD47D");
                WriteLiteral(@"JGeTlNMsGU4H6/V5lS1GGxapMEzVd7dVEniwXz+6F95bExmzq5yjTTY8xaHrek6j5jcNx3P9XjxJpoe+OKXCw2e2a7V6Xgow/SNO3HUxjKvVY9JApdJUQ7R7txefVstrE9K8DMIfA+iv+P4/D5NeWU1pnTSeJsgHYZpko6apzHr5yP0AwPTK9n8dpD5iaR87LhVfGNEla9i8svB+gKzG1zAnBqwoZRe64F5zokf2Z4ctjM6cGvcCxBq/9YwHNd3vOsDPxK1J2YtO9JYz3c6PcbzuM0NJkV6QkHbQAJCcgLUBhnSTzzvrT5z3negLqt5xxAAkXX+Ag0LnTIB93qYuwF5deAp87z7RG+FRsq1ufV2ABqPx29fgpaaJ154m08951fIy4hZj8Te4z/Gg6EWomVYAl702pl/kVTO9Pd1kPqcV0hhpAazri3aAQSWgA0cX4JNeNeRvoc9s6qPeqFojCLh7GcBxBTBGzwC8w+mEoj7M4Kr8xDlTJk7tABtFVFiDfnWEC7UBPulVQyHdtw+Y1kYnuhgnmgBNKUdCTWcLAL99bYBPBl+KnY0AXFe0Kd1XYy0Rlee1iTWpdOyVyujlazCmAI91pgMqTQFq927K89pEgJMXAbxHRE8U4IyhLWexLFdqDyu7lue1iQDDBwA+pyZMNKQAdxxtNbkj3o8mjG3dodgA0IFNevRTImqaAwowFQdjArvNQAFQNAGbD7xHmMLnNhn94AtCKwowkDG9ht0mfQlAquqDlwJsMNWcPQD8jOS0I7LbXH2rtes2gJa5ZM2Ix9YgZF3TqwLqzGtqyHQ7S18OsFDPuJyRAPDOGbTpPpqpaKtmqJefMk078fwo7PV6wSXI/+2F48inGxwPMKK+qa0jZ9qiu01xXGwBSDS+EqDlQlOeHKCTnJM4DcLI9/1o7NcB5iWMk8Hq8D26CfGar9toscprjumokIfKPDzYKoAGXqmFGb7hAHLC057XRr0WFzlA7w/L+MKpADpJhy8yb/HXahb7DgzKhX6+VswK");
                WriteLiteral(@"7tq7knPGpBEgo/FlNhCKCGNrOcDKbQNlgABgAA4BjUBNp3sYlnE2Kn3EkFGfCSilYylFlM1rkxt5Z8KZ4liNrgKv0F6PfqMRxyj+2Zg144kYMk1pJOAyGiI1wLrGlwOMSP8neS8WmvMAO/gbk5qy+oGaHarEetcG0DLB0uq6QKvSUA0AyXruLOU1cynucdyDONuOMLlC4ZGuh/SrtBVgzuaAVB4+AdAn/acKgDltsGC4/iTiXDsZlGW5OJzX68FHEdhfn/PttQpX0DGgkUiwLVrO5cBduc23pH2pDlofuImRGmBe3HGRlpAkyXA4nBAHFVHJReX+dFeEajjlaXu+H8az40EE2rmOtQAiNCWVZq0zKFMTReNuFzdxabRk6E052pyNoi6ZwW6AP+EPpjbdA5xenDEI+74mwMrxgGwlQJNofCnAfGcru903m2p1dwjhbUenJWBoJbZo8c2uDpAYMlpBMNBVO6SiVea1lRUs4rqImwDmamGyzrJsNUjiwrJxoyAZUYBLdjAUtmhSD77oA7QtME9HSEXLRLmFcwjRaH1bdE5WAHdgmBNUNAzYBXdR+2liWAE8a0cYGHXdk9OyUW7xoLXGnZ4aAEZLiqfDlXKXMbSOSyu65U7JuIER3+bZDklHZwVAVuPzAEGjeZayZtDhAbIPO60D764alWy1HkyTU9wb+w7ushEgQnvSo/8AQNBoK6SsGSoBYhNgrQVwJrRSluV+dbrwsVeBTRidSdNKkgM0EMnjuiDlLjriWWMfFloiSn0k0syw2zBA1dFKZNMl8dSReh5UAG0PV+3zhnlV8ySMPQNwrbkGlQDJw2bmN8zDmhCHKjaV/jhwSw5VNW0kFS4oWaAjonYtaq8UiE4nMZRsBqTyUAWw3E1tsaYFZ4NQCbA6qy5nF9fzXNfvpZNTcpwOZ6mLJDNIrQMA6LBGrRxg8bCMlH7RKya5ytnk89pqNZ1+OTRbWwGwko8FHgQwzGgRASInN2Hj0CgM16L41Pzen9bzJZuiwCENkRwg");
                WriteLiteral(@"NRcCKZsWnUd+Bkt1n9c8qgCaJjnCT2FWVI5fAOjEkIN6xgHW6A/AIIaMOw7SyXR12NZywuhUQjoS73QKyWAc5WwqAcLQBAqAFvYYdTsfbQBJu05SS+8qg+S9KwA8wzGA8GK5UV56cbKnU9klEURJdIkMx6jBfcvXLLs5lAC/DKVftAxzdW42B1Dh+N1Vh79yVvp+FUP6AMcHZZoeV9JanVDGZl51SmhCk+taCbB88HD/mdrxO62kuFVE/dqOIuiWWYOfBfkbWmkqBWhQh1ByF8B8Ey7736k925ns9C8X0VjuXsN/4gaAedcRrTSSO36JQ7NL4sS6AMGUipAKoIFDB6GGm38o0ZmVfh+0uCx2lBYp3IYZac6TAiQaXxBu4l1QAoTIgdW+Bs81gPtk8sECzP/bBg0AS+Ma0xqiiJYPE9JBKtNQqrw2Yq+skXJ7wlb3V+saNA4U4HJS+v2ymqwSpLlKVUbaq6OHyvEL+mIqMaJUeW0mdnXTrBWJcGPf7RzRIqQp2xzAiYFX3EXiBe8ktgKgZflwqFatV4Poi75gFJh8XltlM5KTU6gCaJA9eh7HaXrpFd4LPhKFyxzg7H3iDjLm4m6T/1m4TD36eqS8x29MshTYJIMBbun8JMuzyWh8piZx8ThygMUYVOlJ9fLntt1n54/hbHaa7OI0WAHABI5A7g0AHs5MYKMbB8ElL0ExXr7nOI6RFyfv8oBJBgqABpGnrtKPLPt42Wnaf3NenYq15oJJAjC2oz5UWpvI6k0/O7VtRyjXzW052l4xyUTKvSWcL2SZnEJNF7c5VQE0sZqVhCSkZ7xNBADDK3w1xYLo7UTnt4i4/MBXAUSIVFo0AmTmPsCN7pQAizFQ+S6Eb0YeAOzRr2Z0pRmTjqySMHB7uYiW7W4wyZfuDFJX8LjhEAvWYPtUjmwAmFLaHd328r/eSgqQa3fS4Lr/ILShBKApndhzucl1fdUMFuX03efiv0Ipu13SGdxRplPEauZdM8Dyj99gFIAY5O3ybBKNzw0N");
                WriteLiteral(@"wobyVnWsLmmR5ZTnej8KgzQuYzPD4+Cc7bdwlMWs0TU4o8wGiDc9mPxqaZk2RZeg+pD37ivy2pCPGclEDSrIiRiXIcXqd9hdlFqnX5EA0KT5Cf3pepXNF9vlbfP59XWF8pUgdfDFBq8ZnCFrbGKNz31Mo6v5dqecwbYDb7E0ijYGAHAKAG++CDAnAd9r7V4ebs4UaAUz2DLKDZlspnzcB4qoQSHSrAPQ4iJQHsiNQRT9GgBuPRlAkwagjky7Nf4ENusmM7F1P10WIBdCrGqSffKiBChIpuH54+ASF5fRzvPtsg8n+hMBSG2buaEAWBh44FUgxR/3LmmaloZhECpyJbDwgIREsnmQDM2+nPLOmAFYGxrkJqtVdpgvvrejW+WeEMvGKG3RyvxeV5IjiB1ZipN0kgwOMqPwpD6pnYhKCWVbhQjQwEKNs6BkM+huJP13JBt9Up6+ikS8LjnfqK9YWYh3ngrNxUrXfUps+FhrBksfDfhYZWsQcYdYlTs+l4KijjMCklkTQIMcERqaOyhDKLBPzZAAkGh8puYF9zJSAURMvw0cFYYWcvtAMmkGeOGb49vNFbQCIJxncyHhALJ5bVCT2GwrpR5UABROCMXFjOgP0KYNgZqi62HbwHW+fDlA2/aJkTHghVKe10biXYlSTXw3n5s2cNElb298rQ5QLfc4E3bC+NIle5/Us+0s8Ric+XYthGpRbtinyYrfCUZeZXXXGOluRovDaj1NZqddGozzw6vh4+4W2IWCacdtAGu0eJy+s/PgOBwms7wMsDvgonTobfEYHLh22RAi1ISoWSwYefAwgRwNsZjEkO6UR9YLzMrGbQWI7e+cdpoGkcc1G4FYqRx6xFuylbXLA6RGHvFjSvbfAISeRs1Ypol+j+j9loWnARC5tF94Jzf1CTp4na2V3s0DOamZ7TMIFmK3I76fgtS0ia90z9utQIIP8t0diF3m6ACs3F+i25C4heZyhx5GWBAsLdQKkEQ+c86Iq060RS0Ha/wbkjNNkrG+AOBK");
                WriteLiteral(@"4qmVuA3hEolrSzQUDob/8RQAIemgbwgZ3bSJqmZMZIthhJ17bNZdPTnT9NoOlpyzHkDqvkOy/Y3kDLhygCYg3Dg2N4NsXhuuSSKHX0IvVc1zpzJcRb8Bmz4y0ARokvX/jWS0ZEmzaXI19y1JeLjxSRtsXhupucKcbeUAyWGvlL+eDCDNDsYi+qEJ0Mbee3AJ8rRhR8wiq7tvyRyOLK7dckr5l5ss8KJdNXh+TngQYmkaCdrXAE61AWLR79J7TlzXeG0PVc3N8fAs2HYVb29ZQpxDfeC9dIgjW5ZOacDt6yaORIARqeNIaYmSPqicf2R45gybfAiRfAxZRkPBTK/2X2LKr5EI0ED+Hwow0QcIfpyVnJYIxh+V62iBa59ZgHV9IZrpCW+mV3NvkcNqJrF6IP26ADi7A6BD3P0pkscmiN9B4TrySDRkKjPr2P+zaZJ/w0UukwS85hxJCdDYwwxO7gCY66hyVDaeYvmf8EKL5M1BPrTMrOMA0vsFxOqUe9U8nE6Eb1xyALcPASz2N6Jb5LQx5oq9yEVJIjotgoiaHPcWNjpB9ajchtuS5Et0bTlbekLw7wEIvrlQRTvG7e6kAGmia2AKAMvdlMlrA3M5knJEau5pOEgJMNeW+gDzI2dZaaHUUB7mKpEBpCZPJ+IVAxvltpkYgq+eQWrK+xxAbwkiWq4JfYBg6F0kGzhJ8vvqUBNQVMEkontzOYDSvLYZYdFtAAhGUoTUAMGrogPQueEqI0H9UFoDOw4WMseDTXQJbH211cFqfFwzIY45F6lEFNGLDgFiAI7q7hWSQK8DkOYJp0oNZZFB7UtVsEH2jg8eIKvxLaa3T0/9eiTwGhU3MSqA7q02gwXSrS5AkNG5qVTBIIhXjyMpH3pkTFMNgDQRbunx55BaTYhsVDozB7ghAK+nmsbXAUgT4hvfKZLAwhABlqcZ2B3bZpC4e6vLOfLoEtFOswpgmQ1LPOtfVc6aBsAIMmePTQCx84e/O8LabH2eTRlAinBhSXqhQ0NUSsIA");
                WriteLiteral(@"7EJwZEYzgZSGUW0GIUTwpxEg5BYEmAcGoNWhNpsk7Qu3VRvpKZ6euWIGcU0SkT9SgF9kBrtFQja9XZkb0oxRIAFYXfzl5I8f2zHuIJU4HmK1S1bIazNxCgJ4HpUpzeSlWFMASNLJi7ySYleIyW5T/Jv4CNkqgH51U1qwEjnhqRLRBKPgAJf0xKgB4/MmNUkoLpMCBHGm/kQMcENE9CsitIPatto5p54coDerXgeZtABExNofigDhBttamdeG6gDhIlmmXIM1hOfSfxkBwOKFMYQ26zB37+e7HqKFXNsK6jfdhXx4vmvL7QMMDiDNxLhIjKgaQFrhhFk7qEU0l21iKGdFm+V90QLg0q/RroF3OpWjj1kc+kX2RnE/NiMLtUNmpgVgPivYqFkJ0SXiU+jcHMHNCmNQn0E6Igf1qzpNwyRH4H3+QQRrcFQHaKMd9xJXodS+2WkAJJZZxk2IRe2FIUXSCNCEzW2vdC+XngoyLViblSJ6czmD0J3Wp0lAWn3QD3UAls4myCasn/7hFoficMyNSJX6/q1agyWti5nvVyI6ckRab3jl8UjCjVN+VhTL/1C2sucBwon9rDeDVWJL35H1AjUdzPRmDNwvPKm95KSrL2bCBIDrqBUgER7sx91a3KluQSQlVAA0cRO11QtePVfWC61J/OIgolKAeCtzg+O+msnq5FGUTQIJQu0A0bqstXRYgBBlOTC0lVBK8trcT8yI9PYZ56AFpgtXs5oW2U44WQtZKcukZyHlm9RE+xIrl77HnurALRRKu5bntY06YF82MM1sGHuz2elEvonS+HRcr1bn9XCXkjs+2gBNYjD3a6c6G04VXYWbVZHXdoAIr1JE8yr1t7bMDT2vWt3Wb6FV58733fqpDt69QpKhRAd8rbdqesgBMWnKTERwHalYg5oARab1AZo0F23j1pvbEx6GcjbleW1wg2OtdCQVNZcVQPQwwFYRZZo71hFi2gnh4dNRsCkDSBWiKsKLa26piNrvA8jOyrEUSIwQN9eD3fly");
                WriteLiteral(@"D0Cb7iKOpBeoSVP1ddfgkyJakByxCnZpc4Xnvdwy5C5GBcDi4xsemlTKCAXY1dlFXzGDQDvA5r1DaTMyg1enaQYZjU9qJrjmQAkQHP84FxD2K913WWgCFC6U4vT6kQG0A7CQggaA8re3BLjmVzvAcvverz6Os91lHEW+S1+7RkdPAVA129UvJhBK14+ioMjMHeDtewE6gCbGzxpEVPGrZOBmCaTe1xKg4iLPZvk9LzLAZrv0EgRB8fJA/vVJTcXxcjhhLwjS3Wn4Uaa0j/hU1jlRYjuwqg5NAMtvhLw2G3z2a2kAlAHY+CtH+Ivr56a/HG2/F/v5ISsMmuJ1WMX7sIpfK8lLlh3229Gyv9n8uV4VjdQ6OOArkfRySt9Qv2OSTxqiokTPlL6k5qXeXdtL5h4tDe1miAHY9eWC1gjQRh5xX89aAQq4lA9atO0k+N141evhFStJBpDZytbEP+/IAJYDPK/8nMzYC7haAWq/dbAsWwPVLxFdHgRIb9YmKoCFqXbZTZL1fPQpkce7uNde0tf+opSq6nqRGDUQAZr4Y94nMyfD5ptSNVFYMhZVDH7Uu6ST4WB1yPe+fsNuIRmDxvLnNlrMV+vhJL30xj7okQ9ae6cDEJ+AeYD0zSwZkgHcs6ZaTRiKqyXROAwvxU2v40e+Ya7ynXK5+WoG1C1+S28xz1b5BvsxnE3iHFGuaVyPPf2UplrlidWZQYvR+HWmIVU7rmpSNbFtNNVqkwuoHVw81/XyUjhMffxIPim+NDhVr7CQoj6dwVQHoPpXyahp7YszyNNKGEHM7gzQYUboWRgCJho/D4Wbi6v12tMA2PirZPAmhMXfOE0oUuqcMhxS4rtFWgDZECL7cQRt4dhEdZr4ueMSDzBc0hnce1oA68tYNOkhRaX0EFCA3zLad5zoRYBJhwIcgI/pCYA0TbRThOwqEW10G77yRM/SWigcVQDjRmNbS0TLCtVLVultlr+1BpFDrgwV/4wiPYB1jS9whGvS+yBURB8H+MwMmijuUx46");
                WriteLiteral(@"U7vhwCsByGh8vuaJNYbn6G+swXyHWVSDvAmanE4iwJZfJYO8DAzw/DjAJ3ZRFNUT44tfJNMCCPoV+7xN9uOqJj0Ll7GJvwLQp+9uKIwp+eUA9QwajMaXD82h2sF26J50yme8apTWq+PDR8N7RLQS9Kaatbc8LSIV7XvWYMS8tB//0ts9IqrIaxNq1ofxZN8P8CE1kf/bW3Wqja5zUARAG2dQDyBN5StnchlLaF++Bk1k7BY1VdX5DtrYfBxgdV2HdDci7yF4m4jmJZxWY1rv8qEZJBq/uaY7r41nZxsb2gDvn0Hkn0adOsA54HtsDcp/lUysyV5Hu82actWeWYP+7sD01Fn1qBv8ERFVvL1FclRG40V9XAtfm9EO8A41UXwQTeC1ZNBRkfXXtOO2ApT/Kpli7nfXuqgWwxs7YszjseBL/hgkG9B7pOxjKdN3iCgl0Rya2g/jANLsNDZ42vtF1A1nGdtu8SaesXQw7ppBRuNrnST9Kc9IvtGd47Bq5h6A5efRZXj45Aeus76o34X3RoDFN25SFyXg6HOOX/6MEJuqKt1x6RuVo/R0YCJLpLkshdv4PzyDpKY12XIcQVlMTykfTKM/1EFdjKbjueFuth5JW+mfy8X9CEDlAeneoclLb/3JsMbweDucP5JdGoZR8StexCvqR9hNnEzXGfdunVrl/bBnFDy0zspdM2ji7++piYqEvHONRWW84brp5+W2+bzyXwmj8znY+aRrHcNcG2D7r5Iph8ZIP9gU2fbIiorkcxDDm/NfDpDX+No1Mcl4t1qqudcIM3VG2az8hQeJWn3FGmR/lew+gLChOFE6zepphzqR0KJc54PkEhmygUOvUhNsCPEhgGSMHD89fWw7mmWZDScX12G6vudw/MA8PAGwrrwL9R1PjqvifW31cNr1a9O/LRfZINnFl3G1hT94+hfYbLUxXgCQdS8XxSneGJmXMgro1L+VndRUIvprZlAyjLyi1w2+tNL+bYDaxyUZwPesQeWvkv08wBerCQbgHcro");
                WriteLiteral(@"rQHQ+wG2s6n6VbL3Avw5EeXz2t4sok0B0HcBrGv8vzqD71mD9u8F+Bo18doZvMOr9m+K6FNr8M0iar4C4G9UExRgqS6EvLb/zhrkf5XsP6cmbHVemz7A36wmGvPa/soafLGIKpKG/jtq4mcAvnwNtgrPawH+7jX42wC+aw2yGv8/uAZVv0r2j57oxbFtyWv7Z001RV7bf+BELx/bxwD+alONZ/ORmv+Emvg1AN+lJp4B+E+oibcC/A2mGgVo1j/+Z9VEwxqU57X9d9agIq/tv7MGFXlt/76pVjVHvrkD4C9cgxpsvgPgb7BkOIA2P7ESK5YKt61PK5BYFYnV1rUldv0Am4QQTlPCgwWB6tqDQCuSKGltjebu6bqVlhCaqgezeniC5F20pg5tw8d6jLycFt1P20jyP2CYwtXkf04zAAAAAElFTkSuQmCC"" name=""aboutme"" width=""140"" height=""140"" class=""img-circle"">
        <h3>???? ??????</h3>
        <em>Description</em>
    </div>
    

  
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86");
                WriteLiteral("dIHNDz0W1\" crossorigin=\"anonymous\"></script>\n    <script src=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js\" integrity=\"sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM\" crossorigin=\"anonymous\"></script>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12006, 9, true);
            WriteLiteral("\n</html>\n");
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
