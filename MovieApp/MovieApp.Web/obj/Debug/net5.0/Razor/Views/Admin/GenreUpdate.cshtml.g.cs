#pragma checksum "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GenreUpdate), @"mvc.1.0.view", @"/Views/Admin/GenreUpdate.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Entity;

#nullable disable
#nullable restore
#line 1 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
 using MovieApp.Web.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf1", @"/Views/Admin/GenreUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9c4c9750a62c96f3118ca566f2e249963db21e77a2c8572246cbe5b427d2e603", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_GenreUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminGenreEditViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("as*-action", new global::Microsoft.AspNetCore.Html.HtmlString("GenreUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Edit Genre</h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf16182", async() => {
                WriteLiteral("\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf16527", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.
#nullable restore
#line 9 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                All

#line default
#line hidden
#nullable disable
                ;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t\t\t<input type=\"hidden\" name=\"GenreId\"");
                BeginWriteAttribute("value", " value=\"", 292, "\"", 314, 1);
                WriteAttributeValue("", 300, 
#nullable restore
#line 11 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                               Model.GenreId

#line default
#line hidden
#nullable disable
                , 300, 14, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf18752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 13 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                    Name

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf110330", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 14 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                    Name

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf111990", async() => {
                    WriteLiteral("  ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 15 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                              Name

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t\t\t</div>\r\n\t\t\t<button type=\"submit\" class=\"btn btn-primary\">sumbit</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-9\">\r\n");
#nullable restore
#line 21 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
    for (int i = 0; i < Model.Movies.Count; i++)
			{

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t<input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 698, "\"", 723, 3);
                WriteAttributeValue("", 705, "Movies[", 705, 7, true);
                WriteAttributeValue("", 712, 
#nullable restore
#line 23 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                       i

#line default
#line hidden
#nullable disable
                , 712, 2, false);
                WriteAttributeValue("", 714, "].MovieId", 714, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 724, "\"", 756, 1);
                WriteAttributeValue("", 732, 
#nullable restore
#line 23 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                                           Model.Movies[i].MovieId

#line default
#line hidden
#nullable disable
                , 732, 24, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t<input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 786, "\"", 812, 3);
                WriteAttributeValue("", 793, "Movies[", 793, 7, true);
                WriteAttributeValue("", 800, 
#nullable restore
#line 24 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                       i

#line default
#line hidden
#nullable disable
                , 800, 2, false);
                WriteAttributeValue("", 802, "].ImageUrl", 802, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 813, "\"", 846, 1);
                WriteAttributeValue("", 821, 
#nullable restore
#line 24 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                                            Model.Movies[i].ImageUrl

#line default
#line hidden
#nullable disable
                , 821, 25, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t<input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 876, "\"", 899, 3);
                WriteAttributeValue("", 883, "Movies[", 883, 7, true);
                WriteAttributeValue("", 890, 
#nullable restore
#line 25 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                       i

#line default
#line hidden
#nullable disable
                , 890, 2, false);
                WriteAttributeValue("", 892, "].Title", 892, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 900, "\"", 930, 1);
                WriteAttributeValue("", 908, 
#nullable restore
#line 25 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                                         Model.Movies[i].Title

#line default
#line hidden
#nullable disable
                , 908, 22, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 26 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"

			}

#line default
#line hidden
#nullable disable

                WriteLiteral(@"			<table class=""table table-striped table-hover table -bordered"">
				<thead>
					<tr>
						<th>Remove</th>
						<th style=""width:15px"">Remove</th>
						<th style=""width:30px"">#</th>
						<th style=""width:100px"">Image</th>
						<th>Title</th>
						<th style=""width:160px""></th>


					</tr>
				</thead>
				<tbody>
");
#nullable restore
#line 42 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
      foreach (var movie in Model.Movies)
					{

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td class=\"form-check-input\"><input type=\"checkbox\" name=\"movieIds\"");
                BeginWriteAttribute("value", " value=\"", 1419, "\"", 1441, 1);
                WriteAttributeValue("", 1427, 
#nullable restore
#line 45 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                                                                   movie.MovieId

#line default
#line hidden
#nullable disable
                , 1427, 14, false);
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n\t\t\t\t\t\t\t<td>");
                Write(
#nullable restore
#line 46 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
            movie.MovieId

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50c71690b975e1f0d59e8d4983d81fa297d7a920127a2de151610f61f4a56bf119096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1506, "~/img/", 1506, 6, true);
                AddHtmlAttributeValue("", 1512, 
#nullable restore
#line 47 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                             movie.ImageUrl

#line default
#line hidden
#nullable disable
                , 1512, 15, false);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
                Write(
#nullable restore
#line 48 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
            movie.Title

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t<a");
                BeginWriteAttribute("href", " href=\"", 1602, "\"", 1642, 2);
                WriteAttributeValue("", 1609, "/admin/movieupdate/", 1609, 19, true);
                WriteAttributeValue("", 1628, 
#nullable restore
#line 50 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"
                                     movie.MovieId

#line default
#line hidden
#nullable disable
                , 1628, 14, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary btn-sm\"> update</a>\r\n\t\t\t\t\t\t\t\t<a href=\"#\" class=\"btn btn-danger btn-sm\"> Delete</a>\r\n\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 55 "C:\Users\Seyfi\source\repos\MovieApp\MovieApp.Web\Views\Admin\GenreUpdate.cshtml"

					}

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminGenreEditViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591