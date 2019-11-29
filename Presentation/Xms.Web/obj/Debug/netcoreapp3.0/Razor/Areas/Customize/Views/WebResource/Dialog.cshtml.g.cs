#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4266af3b82f35fab51f2a98b21f7affd8a5929bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_WebResource_Dialog), @"mvc.1.0.view", @"/Areas/Customize/Views/WebResource/Dialog.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Customize.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4266af3b82f35fab51f2a98b21f7affd8a5929bc", @"/Areas/Customize/Views/WebResource/Dialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_WebResource_Dialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.WebResourceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("themeLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
  
    Xms.Web.Models.DialogModel dialogModel = ViewData["DialogModel"] as Xms.Web.Models.DialogModel;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- （Modal） -->
<div class=""modal fade"" id=""webResourceModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""webResourceModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" style=""width:650px;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    ×
                </button>
                <h4 class=""modal-title"" id=""webResourceModalLabel"">
                    <span class=""glyphicon glyphicon-th""></span> Web资源
                </h4>
            </div>
            <div class=""modal-body"">

                <div class=""row"">
");
#nullable restore
#line 25 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                     using (Html.BeginRouteForm("Customize", FormMethod.Get, new { @id = "searchForm", @class = "form-horizontal", @role = "form" }))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                   Write(Html.Hidden("CallBack", dialogModel.CallBack));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group col-sm-12\" style=\"height:30px;margin-bottom:0px;\">\r\n\r\n                            <label class=\"col-sm-2 control-label\" for=\"clientip\">");
#nullable restore
#line 31 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                                                            Write(app.T["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            <div class=\"col-sm-10\">\r\n                                <div class=\"input-group\">\r\n                                    ");
#nullable restore
#line 34 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                               Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <span class=""input-group-btn"">
                                        <button class=""btn btn-default btn-sm datagrid-form-search"" type=""submit"">
                                            <span class=""glyphicon glyphicon-search""></span> ");
#nullable restore
#line 37 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                                                                        Write(app.T["search"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </button>\r\n                                    </span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 43 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""datagrid-selecterview mt-2"" id=""datagridselecterview""></div>
                <div class=""table-responsive"" id=""gridview"">
                    <table class=""table table-striped table-hover table-condensed datatable"" id=""datatable"" data-ajax=""true"" data-ajaxcontainer=""gridview"" data-ajaxcallback=""ajaxgrid_reset()"" data-sortby=""");
#nullable restore
#line 47 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                                                                                                                                                                                        Write(Model.SortBy.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sortdirection=\"");
#nullable restore
#line 47 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                                                                                                                                                                                                                                     Write(Model.SortDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-singlemode=\"");
#nullable restore
#line 47 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                                                                                                                                                                                                                                                                            Write(dialogModel.SingleMode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    </table>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4266af3b82f35fab51f2a98b21f7affd8a5929bc10898", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2703, "~/content/js/jquery-ui-1.10.3/themes/base/jquery.ui.all.css?v=", 2703, 62, true);
#nullable restore
#line 50 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
AddHtmlAttributeValue("", 2765, app.PlatformSettings.VersionNumber, 2765, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4266af3b82f35fab51f2a98b21f7affd8a5929bc12570", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2853, "~/content/js/grid/pqgrid.dev.css?v=", 2853, 35, true);
#nullable restore
#line 51 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
AddHtmlAttributeValue("", 2888, app.PlatformSettings.VersionNumber, 2888, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4266af3b82f35fab51f2a98b21f7affd8a5929bc14215", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2991, "~/content/css/theme/", 2991, 20, true);
#nullable restore
#line 52 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
AddHtmlAttributeValue("", 3011, app.Theme, 3011, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3023, ".css", 3023, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 3077, "\"", 3172, 2);
            WriteAttributeValue("", 3083, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.button.js?v=", 3083, 54, true);
#nullable restore
#line 53 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 3137, app.PlatformSettings.VersionNumber, 3137, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 3212, "\"", 3306, 2);
            WriteAttributeValue("", 3218, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.mouse.js?v=", 3218, 53, true);
#nullable restore
#line 54 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 3271, app.PlatformSettings.VersionNumber, 3271, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 3346, "\"", 3447, 2);
            WriteAttributeValue("", 3352, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.autocomplete.js?v=", 3352, 60, true);
#nullable restore
#line 55 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 3412, app.PlatformSettings.VersionNumber, 3412, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 3487, "\"", 3585, 2);
            WriteAttributeValue("", 3493, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.draggable.js?v=", 3493, 57, true);
#nullable restore
#line 56 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 3550, app.PlatformSettings.VersionNumber, 3550, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 3625, "\"", 3723, 2);
            WriteAttributeValue("", 3631, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.resizable.js?v=", 3631, 57, true);
#nullable restore
#line 57 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 3688, app.PlatformSettings.VersionNumber, 3688, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 3763, "\"", 3859, 2);
            WriteAttributeValue("", 3769, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.tooltip.js?v=", 3769, 55, true);
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 3824, app.PlatformSettings.VersionNumber, 3824, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4266af3b82f35fab51f2a98b21f7affd8a5929bc19289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3905, "~/content/js/fetch.js?v=", 3905, 24, true);
#nullable restore
#line 59 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
AddHtmlAttributeValue("", 3929, app.PlatformSettings.VersionNumber, 3929, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4266af3b82f35fab51f2a98b21f7affd8a5929bc20846", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4010, "~/content/js/common/filters.js?v=", 4010, 33, true);
#nullable restore
#line 60 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
AddHtmlAttributeValue("", 4043, app.PlatformSettings.VersionNumber, 4043, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 4118, "\"", 4192, 2);
            WriteAttributeValue("", 4124, "/content/js/grid/pqgrid.dev.js?v=", 4124, 33, true);
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 4157, app.PlatformSettings.VersionNumber, 4157, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 4232, "\"", 4319, 2);
            WriteAttributeValue("", 4238, "/content/js/grid/localize/pq-localize-zh.js?v=", 4238, 46, true);
#nullable restore
#line 62 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 4284, app.PlatformSettings.VersionNumber, 4284, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 4359, "\"", 4427, 2);
            WriteAttributeValue("", 4365, "/content/js/cdatagrid.js?v=", 4365, 27, true);
#nullable restore
#line 63 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 4392, app.PlatformSettings.VersionNumber, 4392, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 4467, "\"", 4544, 2);
            WriteAttributeValue("", 4473, "/content/js/jquery.bootpag.min.js?v=", 4473, 36, true);
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 4509, app.PlatformSettings.VersionNumber, 4509, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 4584, "\"", 4654, 2);
            WriteAttributeValue("", 4590, "/content/js/jquery.form.js?v=", 4590, 29, true);
#nullable restore
#line 65 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 4619, app.PlatformSettings.VersionNumber, 4619, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 4694, "\"", 4756, 2);
            WriteAttributeValue("", 4700, "/content/js/xms.js?v=", 4700, 21, true);
#nullable restore
#line 66 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
WriteAttributeValue("", 4721, app.PlatformSettings.VersionNumber, 4721, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script>\r\n                        var WebResourcesModel = {\r\n                            dialogid: \'#webResourceModal\',\r\n                            dialog: $(\'#webResourceModal\'),\r\n                            callback : ");
#nullable restore
#line 71 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                  Write(dialogModel.CallBack);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                            datatable: $(""#webResourceModal .datatable""),
                            gridview: $(""#webResourceModal #gridview""),
                            searchform: $('#webResourceModal #searchForm'),
                            pagesection: $('#webResourceModal #page-selection'),
                            pageUrl : '");
#nullable restore
#line 76 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                  Write(app.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                            callback : ");
#nullable restore
#line 77 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                  Write(dialogModel.CallBack);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                            inputid : \'");
#nullable restore
#line 78 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                  Write(dialogModel.InputId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                            solutionid:\'");
#nullable restore
#line 79 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                   Write(Model.SolutionId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                            ajaxgrid_reset : function () {
                                WebResourcesModel.pag_init();
                                Xms.Web.DataTable(WebResourcesModel.datatable);
                            },
                            pag_init: function () {
                                WebResourcesModel.pagesection.bootpag({
                                    total: WebResourcesModel.pagesection.attr('data-total')
                                    , maxVisible: 5
                                    , page: WebResourcesModel.pagesection.attr('data-page')
                                    , leaps: false
                                    , prev: '&lsaquo;'
                                    , next: '&rsaquo;'
                                    , firstLastUse: true
                                    , first: '&laquo;'
                                    , last: '&raquo;'
                                }).on(""page"", function (event, /* page number here */ ");
            WriteLiteral(@"num) {
                                    event.preventDefault();
                                    var url = $.setUrlParam(WebResourcesModel.pageUrl, 'page', num);
                                    WebResourcesModel.gridview.ajaxLoad(url, WebResourcesModel.gridview.prop('id'), function (response) {
                                        WebResourcesModel.ajaxgrid_reset();
                                    });
                                    return false;
                                });
                            },
                            dialog_return: function (obj) {
                                if (obj) {
                                    var trindex = $(obj).parents('tr:first').index();
                                    var res = Xms.DataGridCtrl.getRowData('datagridselecterview', trindex-1);

                                } else {
                                    var res = Xms.DataGridCtrl.getSelectedData('datagridselecterview');
                        ");
            WriteLiteral(@"        }
                                console.log(res);
                                var result = new Array();
                                if (!$.isArray(res)) {
                                    res = [res];
                                }
                                if (res && res.length > 0) {
                                    $.each(res, function (i, n) {
                                        var temp = {}
                                        $.extend(temp, n);
                                        temp.id = n.webresourceid;
                                        result.push(temp);
                                    });
                                }

                                var dialog = $(WebResourcesModel.dialogid);
                                if (dialog.data().OpenDialogCallback) {
                                    dialog.data().OpenDialogCallback(result, WebResourcesModel.inputid,WebResourcesModel)
                                } else ");
            WriteLiteral(@"{
                                    WebResourcesModel.callback && WebResourcesModel.callback(result,WebResourcesModel.inputid);
                                }
                                WebResourcesModel.dialog.modal('hide');
                            }
                            , selectedrow: function (id) {

                            }
                            ,CreateRecord: function(){
                                Xms.Web.OpenWindow(ORG_SERVERURL +'/customize/webresource/createwebresource?solutionid=' + (WebResourcesModel.solutionid || $.getUrlParam('solutionid')));
                            }
                        };

                        $(function () {
                            //WebResourcesModel.ajaxgrid_reset();
                           // WebResourcesModel.searchform.ajaxSearch('#'+WebResourcesModel.gridview.prop('id'), WebResourcesModel.ajaxgrid_reset);
                           // WebResourcesModel.datatable.ajaxTable();
                          ");
            WriteLiteral(@"  WebResourcesModel.dialog.modal({
                                backdrop:'static'
                            });
                            $(""#webResourceModal .datatable"").on('hidden.bs.modal', function () {
                                Xms.Web.CloseDialog(WebResourcesModel.dialogid);
                            });
                            console.log('webResourceModal')
                            $(""#webResourceModal"").find('button[name=createBtn]').off('click').on('click', null, function (e) {
                                e.preventDefault();
                                WebResourcesModel.CreateRecord();
                            });
                        });
                    </script>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""pull-left"">
                    <button type=""button"" class=""btn btn-link"" name=""createBtn"">
                        <span class=""glyphicon glyphicon-plus-sign""></span> 新建
");
            WriteLiteral(@"                    </button>
                </div>
                <button type=""button"" class=""btn btn-default""
                        data-dismiss=""modal"">
                    <span class=""glyphicon glyphicon-remove""></span> 关闭
                </button>
                <button type=""button"" class=""btn btn-primary"" onclick=""WebResourcesModel.dialog_return()"">
                    <span class=""glyphicon glyphicon-ok""></span> 确定
                </button>
            </div>
            <script>
                var websourcetypes = [{ label: '脚本', value: 'Script' }, { label: '样式', value: 'Css' }, { label: '网页', value: 'Html' }, { label: '图片', value: 'Picture' }]
                $(function () {

                            var theaders = {
                                'typename':'");
#nullable restore
#line 180 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                       Write(app.T["typename"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                \'name\': \'");
#nullable restore
#line 181 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                    Write(app.T["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                \'description\': \'");
#nullable restore
#line 182 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                           Write(app.T["description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                \'createdon\': \'创建时间\',\r\n                                \'operation\':\'");
#nullable restore
#line 184 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Dialog.cshtml"
                                        Write(app.T["operation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                            }
                            //列数据配置数据
                            var columnConfigs = [
                            //从新配置复选框列的渲染方式，
                                {
                                    title: """", dataIndx: ""recordid"", maxWidth: 48, minWidth: 48, align: ""center"", resizable: false,
                                    type: 'checkBoxSelection', cls: 'ui-state-default', sortable: false, editable: false,
                                    render: function (ui) {
                                        //  console.log(ui)
                                        return '<input type=""checkbox"" value=""' + ui.rowData.webresourceid + '"" name=""recordid"" class="""">'
                                    },
                                    cb: { all: true, header: true }
                                },
                                {
                                    title: """", dataIndx: ""name"", maxWidth: 30, minWidth: 30, align: ""center"", resizable: ");
            WriteLiteral(@"false,
                                        cls: 'ui-state-default', sortable: false, editable: false,
                                    hidden:true,
                                    render: function (ui) {
                                        //  console.log(ui)
                                        return '<input type=""hidden"" value=""' + ui.rowData.webresourceid + '"" name=""componenttypename"" class="""">'
                                    },
                                    cb: { all: true, header: true }
                                },

                                { ""dataIndx"": ""name"", ""title"": theaders.name, editable: false, ""dataType"": ""string"", ""width"": 150, ""isprimaryfield"": false, ""attributetypename"": ""string"" },
                                { ""dataIndx"": ""description"", ""title"": theaders.description, ""dataType"": ""string"", editable: false, ""width"": 150, ""isprimaryfield"": false, ""attributetypename"": ""string"" },
                                {
                     ");
            WriteLiteral(@"               title: ""操作"", editable: false, minWidth: 120,width:120, notHeaderFilter: true, editable: false, sortable: false, render: function (ui) {
                                        var datas = ui.rowData;
                                        var dataIndx = ui.dataIndx;
                                        var column = ui.column;
                                        var recordid = datas[dataIndx];
                                        var html = ''
                                        html=  '<a class=""btn btn-link btn-xs row-item-dblclick"" onclick=""WebResourcesModel.dialog_return(this);""><span class=""glyphicon glyphicon-ok text-success""></span></a>'
                                        return html
                                    }
                                }
                            ];
                            var url = ORG_SERVERURL + '/customize/webresource/index?LoadData=true&';
                            var $form = $('#searchForm');
               ");
            WriteLiteral(@"             var roles_filters = new XmsFilter();
                            var datagridconfig = {
                                scrollModel: { autoFit: true },
                                baseUrl: url,
                                columnConfigs: columnConfigs,//字段配置信息
                                context: $('#gridview'),//底部操作按钮方法触发
                                filters: roles_filters,//post提交时过滤条件
                                searchForm: $form//GET提交时查询的数据
                                , height: 400
                                , rowDblClick: function (even, ui) {
                                    console.log(even, ui);
                                    ui.$tr.find('.row-item-dblclick').trigger('click');
                                }
                    };

                    setTimeout(function () {
                        $('.datagrid-selecterview').xmsDataTable(datagridconfig);

                    },300)

                });
            </script>
  ");
            WriteLiteral("      </div><!-- /.modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div><!-- /.modal -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.WebResourceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591