#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c515898e07fd084225cbfadfd7627a2f69fa45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Content), @"mvc.1.0.view", @"/Views/Shared/_Content.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76c515898e07fd084225cbfadfd7627a2f69fa45", @"/Views/Shared/_Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0011d9a8909cdacaf42363c4ba3a5683bc0ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("themeLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#myScrollspy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zh-CN\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c515898e07fd084225cbfadfd7627a2f69fa455805", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <meta name=""description"" content=""xms"">
    <meta name=""author"" content=""Xms"">
    <link rel=""icon"" href=""/favicon.ico"">

    <title>");
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
      Write(app.PageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <!-- Bootstrap core CSS -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 494, "\"", 584, 2);
                WriteAttributeValue("", 501, "/content/css/bootstrap3.3.5/bootstrap.min.css?v=", 501, 48, true);
#nullable restore
#line 18 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 549, app.PlatformSettings.VersionNumber, 549, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n\r\n    <!-- Custom styles for this template -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 662, "\"", 740, 2);
                WriteAttributeValue("", 669, "/content/css/font-awesome.min.css?v=", 669, 36, true);
#nullable restore
#line 21 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 705, app.PlatformSettings.VersionNumber, 705, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 770, "\"", 838, 2);
                WriteAttributeValue("", 777, "/content/css/common.css?v=", 777, 26, true);
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 803, app.PlatformSettings.VersionNumber, 803, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 868, "\"", 958, 2);
                WriteAttributeValue("", 875, "/content/js/jquery-toast/jquery.toast.min.css?v=", 875, 48, true);
#nullable restore
#line 23 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 923, app.PlatformSettings.VersionNumber, 923, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76c515898e07fd084225cbfadfd7627a2f69fa458844", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1010, "~/content/css/theme/", 1010, 20, true);
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
AddHtmlAttributeValue("", 1030, app.Theme, 1030, 12, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1042, ".css", 1042, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Bootstrap core JavaScript ================================================== -->\r\n    <!-- Placed at the end of the document so the pages load faster -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1244, "\"", 1313, 2);
                WriteAttributeValue("", 1250, "/content/js/jquery.min.js?v=", 1250, 28, true);
#nullable restore
#line 27 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 1278, app.PlatformSettings.VersionNumber, 1278, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1337, "\"", 1409, 2);
                WriteAttributeValue("", 1343, "/content/js/bootstrap.min.js?v=", 1343, 31, true);
#nullable restore
#line 28 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 1374, app.PlatformSettings.VersionNumber, 1374, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1500, "\"", 1587, 2);
                WriteAttributeValue("", 1506, "/content/js/ie10-viewport-bug-workaround.js?v=", 1506, 46, true);
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 1552, app.PlatformSettings.VersionNumber, 1552, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1611, "\"", 1690, 2);
                WriteAttributeValue("", 1617, "/content/js/jquery.bootstrap.min.js?v=", 1617, 38, true);
#nullable restore
#line 31 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 1655, app.PlatformSettings.VersionNumber, 1655, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1714, "\"", 1778, 2);
                WriteAttributeValue("", 1720, "/content/js/json2.js?v=", 1720, 23, true);
#nullable restore
#line 32 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 1743, app.PlatformSettings.VersionNumber, 1743, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1802, "\"", 1872, 2);
                WriteAttributeValue("", 1808, "/content/js/xms.utility.js?v=", 1808, 29, true);
#nullable restore
#line 33 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 1837, app.PlatformSettings.VersionNumber, 1837, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1896, "\"", 1989, 2);
                WriteAttributeValue("", 1902, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.core.js?v=", 1902, 52, true);
#nullable restore
#line 34 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 1954, app.PlatformSettings.VersionNumber, 1954, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2013, "\"", 2108, 2);
                WriteAttributeValue("", 2019, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.widget.js?v=", 2019, 54, true);
#nullable restore
#line 35 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 2073, app.PlatformSettings.VersionNumber, 2073, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2132, "\"", 2226, 2);
                WriteAttributeValue("", 2138, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.mouse.js?v=", 2138, 53, true);
#nullable restore
#line 36 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 2191, app.PlatformSettings.VersionNumber, 2191, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2250, "\"", 2348, 2);
                WriteAttributeValue("", 2256, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.draggable.js?v=", 2256, 57, true);
#nullable restore
#line 37 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 2313, app.PlatformSettings.VersionNumber, 2313, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2372, "\"", 2460, 2);
                WriteAttributeValue("", 2378, "/content/js/jquery-toast/jquery.toast.min.js?v=", 2378, 47, true);
#nullable restore
#line 38 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 2425, app.PlatformSettings.VersionNumber, 2425, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2484, "\"", 2553, 2);
                WriteAttributeValue("", 2490, "/content/js/xms.jquery.js?v=", 2490, 28, true);
#nullable restore
#line 39 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 2518, app.PlatformSettings.VersionNumber, 2518, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2577, "\"", 2643, 2);
                WriteAttributeValue("", 2583, "/content/js/xms.web.js?v=", 2583, 25, true);
#nullable restore
#line 40 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
WriteAttributeValue("", 2608, app.PlatformSettings.VersionNumber, 2608, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
#nullable restore
#line 41 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
      await Html.RenderPartialAsync("UserContext"); 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        jQuery(function () {
            Xms.Web.Loading();
            if (typeof parent !== 'undefined') {
                if (parent != window) {//判断当前页面是否为子页面
                    $('body').addClass('xms-subpage');
                }
            }
        });
        function changeTheme(body,themename) {
            $(""#themeLink"").attr('href', '/content/css/theme/' + themename+'.css');
        }
    </script>
");
#nullable restore
#line 55 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
      await Html.RenderPartialAsync("CommonLabel"); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
     if (IsSectionDefined("Header"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
   Write(RenderSection("Header"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
                                
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <style>\r\n        body {\r\n            padding-top: 0;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c515898e07fd084225cbfadfd7627a2f69fa4519909", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"" id=""body"">
        <div class=""row"">
            <div class=""shadeBox"" style=""background-color:#000000; opacity:0.5;width:100%;position:absolute;z-index:10;display:none;""></div>
            <div class=""col-md-12"" id=""main"" style=""margin-bottom:80px;"">
");
                WriteLiteral("                <div><br class=\"breadcrumb\" /></div>\r\n                <div id=\"content\"></div>\r\n                <div class=\"page-render-wrap\">\r\n                    <!--main-->\r\n                    ");
#nullable restore
#line 93 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <nav class=""navbar navbar-default navbar-fixed-bottom hide"" role=""navigation"" id=""body-footer"">
                    <div class=""container"">
                        <div class=""navbar-form navbar-right"" id=""body-footer-content"">
                        </div>
                    </div>
                </nav>
            </div>
        </div>
    </div>
    ");
#nullable restore
#line 104 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Shared\_Content.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Xms.Web.Framework.Context.IWebAppContext app { get; private set; }
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