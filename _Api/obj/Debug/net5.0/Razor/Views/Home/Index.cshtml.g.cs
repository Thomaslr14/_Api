#pragma checksum "C:\Development\Git\_Api\_Api\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "217a7faf1b8d27848a1afde64779e13760027882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"217a7faf1b8d27848a1afde64779e13760027882", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217a7faf1b8d27848a1afde64779e137600278823895", async() => {
                WriteLiteral(@"
<title>W3.CSS Template</title>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
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
      /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
      #map {
        height: 100%;
      }

      /* Optional: Makes the sample page fill the window. */
      html,
      body {
        height: 100%;
  ");
                WriteLiteral("      margin: 0;\r\n        padding: 0;\r\n      }\r\n    </style>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217a7faf1b8d27848a1afde64779e137600278825303", async() => {
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
                WriteLiteral("\r\n\r\n<script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyCkMNthxGt3NRFc-QVIoYc8rDi3QjC3fcw&callback=initMap&libraries=&v=weekly\" \r\nasync></script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217a7faf1b8d27848a1afde64779e137600278827357", async() => {
                WriteLiteral(@"

<!-- Top container -->
<div class=""w3-bar w3-top w3-black w3-large"" style=""z-index:4"">
  <button class=""w3-bar-item w3-button w3-hide-large w3-hover-none w3-hover-text-light-grey"" onclick=""w3_open();""><i class=""fa fa-bars""></i>  Menu</button>
  <span class=""w3-bar-item w3-right"">
    <a");
                BeginWriteAttribute("href", " href=\"", 1666, "\"", 1673, 0);
                EndWriteAttribute();
                WriteLiteral(@">
      Login
    </a>
  </span>
</div>

<!-- Sidebar/menu -->
<nav class=""w3-sidebar w3-collapse w3-white w3-animate-left"" style=""z-index:3;width:200px;"" id=""mySidebar""><br>
  <div class=""w3-container w3-row"">
    <div class=""w3-col s8 w3-bar"">
      <span>Welcome, <strong>User</strong></span><br>
    </div>
  </div>
  <hr>
  <div class=""w3-container"">
    <h5>Dashboard</h5>
  </div>
  <div class=""w3-bar-block"">
    <a href=""#"" class=""w3-bar-item w3-button w3-padding-16 w3-hide-large w3-dark-grey w3-hover-black"" onclick=""w3_close()"" title=""close menu""><i class=""fa fa-remove fa-fw""></i>  Close Menu</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding w3-blue""><i class=""fa fa-users fa-fw""></i>  Overview</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-eye fa-fw""></i>  Infectados</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-eye fa-fw""></i>  Vacinados</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa ");
                WriteLiteral(@"fa-users fa-fw""></i>  Traffic</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-bullseye fa-fw""></i>  Geo</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-diamond fa-fw""></i>  Orders</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-bell fa-fw""></i>  News</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-bank fa-fw""></i>  General</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-history fa-fw""></i>  History</a>
    <a href=""#"" class=""w3-bar-item w3-button w3-padding""><i class=""fa fa-cog fa-fw""></i>  Settings</a><br><br>
  </div>
</nav>


<!-- Overlay effect when opening sidebar on small screens -->
<div class=""w3-overlay w3-hide-large w3-animate-opacity"" onclick=""w3_close()"" style=""cursor:pointer"" title=""close side menu"" id=""myOverlay""></div>

<!-- !PAGE CONTENT! -->
<div class=""w3-main"" style=""margin-left:200px;margin-top:43px;"">

  <!-- Header -->
  <heade");
                WriteLiteral(@"r class=""w3-container"" style=""padding-top:22px"">
    <h5><b><i class=""fa fa-dashboard""></i> My Dashboard</b></h5>
  </header>

  <div class=""w3-row-padding w3-margin-bottom"">
    <div class=""w3-quarter"">
      <div class=""w3-container w3-red w3-padding-16"">
        <div class=""w3-left""><i class=""fa fa-comment w3-xxxlarge""></i></div>
        <div class=""w3-right"">
          <h3>");
#nullable restore
#line 97 "C:\Development\Git\_Api\_Api\Views\Home\Index.cshtml"
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
#line 107 "C:\Development\Git\_Api\_Api\Views\Home\Index.cshtml"
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
#line 117 "C:\Development\Git\_Api\_Api\Views\Home\Index.cshtml"
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

  <div class=""w3-panel"">
    <div class=""w3-row-padding"" style=""margin:0 -16px"">
      <div class=""w3-twothird"" style=""height: 300px;"">
        <h5>Regions</h5>
        <div id=""map""></div>
      </div>
      <div class=""w3-third"" style=""height: 300px;"">
        <h5>Feeds</h5>
        <table class=""w3-table w3-striped w3-white"">
          <tr>
            <td><i class=""fa fa-user w3-text-blue w3-large""></i></td>
            <td>New record, over 90 views.</td>
            <td><i>10 mins</i></td>
          </tr>
          <tr>
            <td><i class=""fa fa-bell w3-text-red w3-large""></i></td>
            <td>Database error.</td>
            <td><i>15 mins</i></td>
          </tr>
          <tr>
            <td><i class=""fa fa-users w3-text-yellow w3-large""></i></td>
            <td>New record, over 40 users.</td>
            <td><i>17 mins</i></td>");
                WriteLiteral(@"
          </tr>
          <tr>
            <td><i class=""fa fa-comment w3-text-red w3-large""></i></td>
            <td>New comments.</td>
            <td><i>25 mins</i></td>
          </tr>
          <tr>
            <td><i class=""fa fa-bookmark w3-text-blue w3-large""></i></td>
            <td>Check transactions.</td>
            <td><i>28 mins</i></td>
          </tr>
          <tr>
            <td><i class=""fa fa-laptop w3-text-red w3-large""></i></td>
            <td>CPU overload.</td>
            <td><i>35 mins</i></td>
          </tr>
          <tr>
            <td><i class=""fa fa-share-alt w3-text-green w3-large""></i></td>
            <td>New shares.</td>
            <td><i>39 mins</i></td>
          </tr>
        </table>
      </div>
    </div>
  </div>
  <hr>

  <!-- Footer -->
  <footer class=""w3-container w3-padding-16 w3-light-grey"">
    <h4>FOOTER</h4>
    <p>Powered by <a href=""https://www.w3schools.com/w3css/default.asp"" target=""_blank"">w3.css</a></p>
  </footer>");
                WriteLiteral(@"

  <!-- End page content -->
</div>

<script>
// Get the Sidebar
var mySidebar = document.getElementById(""mySidebar"");

// Get the DIV with overlay effect
var overlayBg = document.getElementById(""myOverlay"");

// Toggle between showing and hiding the sidebar, and add overlay effect
function w3_open() {
  if (mySidebar.style.display === 'block') {
    mySidebar.style.display = 'none';
    overlayBg.style.display = ""none"";
  } else {
    mySidebar.style.display = 'block';
    overlayBg.style.display = ""block"";
  }
}

// Close the sidebar with the close button
function w3_close() {
  mySidebar.style.display = ""none"";
  overlayBg.style.display = ""none"";
}
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
