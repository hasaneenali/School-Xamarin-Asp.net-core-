#pragma checksum "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e066e18973b81821a7a4a0d596856ec4d401ad3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Results_Index), @"mvc.1.0.view", @"/Views/Results/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Results/Index.cshtml", typeof(AspNetCore.Views_Results_Index))]
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
#line 1 "D:\xamarin forms\School\School\School.Web\Views\_ViewImports.cshtml"
using School.Web;

#line default
#line hidden
#line 2 "D:\xamarin forms\School\School\School.Web\Views\_ViewImports.cshtml"
using School.Web.Models;

#line default
#line hidden
#line 4 "D:\xamarin forms\School\School\School.Web\Views\_ViewImports.cshtml"
using School.Web.ViewModel;

#line default
#line hidden
#line 5 "D:\xamarin forms\School\School\School.Web\Views\_ViewImports.cshtml"
using School.Web.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e066e18973b81821a7a4a0d596856ec4d401ad3c", @"/Views/Results/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9c9d009e72498000e4fb81cda2070ddd3a425b", @"/Views/_ViewImports.cshtml")]
    public class Views_Results_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<School.Web.Data.Entities.Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1ee7a2129d64d33a5af25b24cd855b6", async() => {
                BeginContext(148, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 48, false);
#line 16 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(303, 120, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n               صوره الطالب\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(424, 42, false);
#line 22 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Arabic));

#line default
#line hidden
            EndContext();
            BeginContext(466, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(522, 43, false);
#line 25 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.English));

#line default
#line hidden
            EndContext();
            BeginContext(565, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(621, 41, false);
#line 28 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Maths));

#line default
#line hidden
            EndContext();
            BeginContext(662, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(718, 45, false);
#line 31 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sociology));

#line default
#line hidden
            EndContext();
            BeginContext(763, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(819, 41, false);
#line 34 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(860, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                النتيجه\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1040, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1089, 47, false);
#line 46 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 41, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            EndContext();
#line 50 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
                 if (!string.IsNullOrEmpty(item.Student.ImageUrl))
                {

#line default
#line hidden
            BeginContext(1264, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1288, "\"", 1329, 1);
#line 52 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
WriteAttributeValue("", 1294, Url.Content(item.Student.ImageUrl), 1294, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1330, 109, true);
            WriteLiteral(" alt=\"Image\"\r\n                         style=\"width: 75px; height: 75px; max-width: 100%; height: auto;\" />\r\n");
            EndContext();
#line 54 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1458, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1512, 41, false);
#line 57 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Arabic));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1609, 42, false);
#line 60 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.English));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1707, 40, false);
#line 63 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Maths));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1803, 44, false);
#line 66 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sociology));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(1907, 40, false);
#line 71 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 47, true);
            WriteLiteral("\r\n\r\n\r\n            </td>\r\n\r\n\r\n            <td>\r\n");
            EndContext();
#line 78 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
                 if (item.Total >= 50)

                {

#line default
#line hidden
            BeginContext(2055, 63, true);
            WriteLiteral("                    <label class=\"label-success\">ناجح</label>\r\n");
            EndContext();
#line 82 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"

                }

                else
                {

#line default
#line hidden
            BeginContext(2182, 63, true);
            WriteLiteral("                    <label class=\"label-success\">راسب</label>\r\n");
            EndContext();
#line 88 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2264, 96, true);
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n            <td>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2360, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb67556cd4aa4cb8a15812ae67555302", async() => {
                BeginContext(2405, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2413, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2433, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32bb90c49e544fabe05c7f5c2818318", async() => {
                BeginContext(2481, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2492, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2512, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b94d5391ec44c8bcd339f9e0070101", async() => {
                BeginContext(2559, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2569, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 101 "D:\xamarin forms\School\School\School.Web\Views\Results\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2608, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<School.Web.Data.Entities.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
