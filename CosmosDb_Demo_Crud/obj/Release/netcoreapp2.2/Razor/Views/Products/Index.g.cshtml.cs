#pragma checksum "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60828889cf08b29b324cd07e72de23d45a0549d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\_ViewImports.cshtml"
using CosmosDb_Demo_Crud;

#line default
#line hidden
#line 2 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\_ViewImports.cshtml"
using CosmosDb_Demo_Crud.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60828889cf08b29b324cd07e72de23d45a0549d3", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5a2206c09e8bab32c2ceb08d4f32bb8f77cd4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModelClass.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(112, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60828889cf08b29b324cd07e72de23d45a0549d33862", async() => {
                BeginContext(135, 10, true);
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
            BeginContext(149, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(242, 45, false);
#line 16 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(287, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(343, 40, false);
#line 19 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(383, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(439, 45, false);
#line 22 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(484, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(540, 47, false);
#line 25 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(587, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(834, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(869, 47, false);
#line 34 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(916, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(972, 47, false);
#line 37 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1154, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1215, 44, false);
#line 47 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1327, 39, false);
#line 50 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1434, 44, false);
#line 53 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1546, 46, false);
#line 56 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1869, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1912, 46, false);
#line 65 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2026, 46, false);
#line 68 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2140, 59, false);
#line 71 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.ObjectId }));

#line default
#line hidden
            EndContext();
            BeginContext(2199, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2224, 65, false);
#line 72 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ObjectId }));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2314, 64, false);
#line 73 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 76 "C:\Learning\SampleApps\CosmosDb_Demo_Crud\CosmosDb_Demo_Crud\Views\Products\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2433, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModelClass.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
