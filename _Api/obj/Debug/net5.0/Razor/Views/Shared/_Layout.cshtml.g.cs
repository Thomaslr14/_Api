#pragma checksum "C:\DEVELOPMENT\Git\_Api\_Api\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a79b6e0fc5f1d2c8d3c694cb3fc16c628c1a7a3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\DEVELOPMENT\Git\_Api\_Api\Views\_ViewImports.cshtml"
using _Api.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a79b6e0fc5f1d2c8d3c694cb3fc16c628c1a7a3c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06d2d730c3188661109518e49f1ab8f6b264df4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-light-grey"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79b6e0fc5f1d2c8d3c694cb3fc16c628c1a7a3c4237", async() => {
                WriteLiteral("\r\n<title>");
#nullable restore
#line 4 "C:\DEVELOPMENT\Git\_Api\_Api\Views\Shared\_Layout.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Mapeamento Covid-19</title>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<!-- Bootstrap link -->
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootswatch@4.5.2/dist/darkly/bootstrap.min.css"" 
integrity=""sha384-nNK9n28pDUDDgIiIqZ/MiyO3F4/9vsMtReZK39klb/MtkZI3/LtjSjlmyVPS3KdN"" 
crossorigin=""anonymous"">
<style>
html,body,h1,h2,h3,h4,h5 {font-family: ""Raleway"", sans-serif}
</style>

<script>
  window.handleTickerChanged = (symbol, price) => {
    // ... client-side processing/display code ...
    return 'Done!';
  };
</script>
<script src=""https://polyfill.io/v3/polyfill.min.js?features=default""></script>
<style type=""text/css"">
      /* Always set the map height explici");
                WriteLiteral(@"tly to define the size of the div
       * element that contains the map. */
      #map {
        height: 100%;
      }

      /* Optional: Makes the sample page fill the window. */
      html,
      .leftside-div 
      {
        text-align: center;
        margin-left: auto;
        margin-right: 0;
        display: block;
      }
      body {
        height: 100%;
        margin: 0;
        padding: 0;
      }
    </style>
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79b6e0fc5f1d2c8d3c694cb3fc16c628c1a7a3c6247", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<script");
                BeginWriteAttribute("src", " src=\"", 1601, "\"", 1607, 0);
                EndWriteAttribute();
                WriteLiteral(" \r\nasync></script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79b6e0fc5f1d2c8d3c694cb3fc16c628c1a7a3c8318", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"<!-- Top container -->
  <div class=""navbar navbar-expand-lg navbar-dark bg-dark"">
    <div class=""collapse navbar-collapse"" id=""navbarColor01"">
      <a class=""leftside-div"" href=""/Login""><button type=""button"" class=""btn btn-info leftside-div"">Login</button></a>
    </div>
  </div>

<!-- Sidebar/menu -->
<nav class=""w3-sidebar w3-collapse w3-white w3-animate-left"" style=""z-index:3;width:200px;"" id=""mySidebar""><br>
  <hr>
  <div class=""w3-container"">
    <h5>Dashboard</h5>
  </div>
  <div class=""w3-bar-block"">
    <a href=""#"" class=""w3-bar-item w3-button w3-padding-16 w3-hide-large w3-dark-grey w3-hover-black"" onclick=""w3_close()"" title=""close menu""><i class=""fa fa-remove fa-fw""></i>?? Close Menu</a>
    <a href=""/Home"" class=""w3-bar-item w3-button w3-padding w3-blue""><i class=""fa fa-users fa-fw""></i>?? Overview</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-eye fa-fw""></i>  Infectados</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-eye");
                WriteLiteral(@" fa-fw""></i>  Vacinados</a>
    <a href=""/Cadastrar"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-users fa-fw""></i>?? Cadastramento</a><br><br>
  </div>
</nav>


<!-- Overlay effect when opening sidebar on small screens -->
<div class=""w3-overlay w3-hide-large w3-animate-opacity"" onclick=""w3_close()"" style=""cursor:pointer"" title=""close side menu"" id=""myOverlay""></div>

<!-- !PAGE CONTENT! -->
<div class=""w3-main"" style=""margin-left:200px;margin-top:10px;"">

  <!-- Header -->
  <header class=""w3-container"" style=""padding-top:10px"">
    <h3><b><i class=""fa fa-dashboard""></i>  Dashboard</b></h3>
  </header>
  <hr>
  <div class=""w3-row-padding w3-margin-bottom"">
    <div class=""w3-quarter"">
      <div class=""w3-container w3-red w3-padding-16"">
        <div class=""w3-left""><i class=""fa fa-comment w3-xxxlarge""></i></div>
        <div class=""w3-right"">
          <h3>");
#nullable restore
#line 92 "C:\DEVELOPMENT\Git\_Api\_Api\Views\Shared\_Layout.cshtml"
         Write(Model._numberInfectados);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
        </div>
        <div class=""w3-clear""></div>
        <h4>Infectados</h4>
      </div>
    </div>
    <div class=""w3-quarter"">
      <div class=""w3-container w3-blue w3-padding-16"">
        <div class=""w3-left""><i class=""fa fa-eye w3-xxxlarge""></i></div>
        <div class=""w3-right"">
          <h3>");
#nullable restore
#line 102 "C:\DEVELOPMENT\Git\_Api\_Api\Views\Shared\_Layout.cshtml"
         Write(Model._numberVacinados);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
        </div>
        <div class=""w3-clear""></div>
        <h4>Vacinados</h4>
      </div>
    </div>
    <div class=""w3-quarter"">
      <div class=""w3-container w3-orange w3-text-white w3-padding-16"">
        <div class=""w3-left""><i class=""fa fa-share-alt w3-xxxlarge""></i></div>
        <div class=""w3-right"">
          <h3>");
#nullable restore
#line 112 "C:\DEVELOPMENT\Git\_Api\_Api\Views\Shared\_Layout.cshtml"
         Write(Model._totalContabilizados);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
        </div>
        <div class=""w3-clear""></div>
        <h4>Total de Contabilizados</h4>
      </div>
    </div>
  </div>
<hr>

<!-- Footer -->
<footer class=""w3-container w3-padding-16 w3-light-grey"">
    <h4>FOOTER</h4>
    <p>Powered by <a href=""https://www.w3schools.com/w3css/default.asp"" target=""_blank"">w3.css</a></p>
</footer>

  <!-- End page content -->
</div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
