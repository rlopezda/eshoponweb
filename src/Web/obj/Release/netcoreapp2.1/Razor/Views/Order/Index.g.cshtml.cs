#pragma checksum "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfadd2abdf8b8b5d8bfde1f519efb7bd0cf6f111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#line 1 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#line 3 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#line 4 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#line 5 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfadd2abdf8b8b5d8bfde1f519efb7bd0cf6f111", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ffe0dcf775aeb111c903b0fbc363dc8cef1f2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("esh-orders-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "My Order History";

#line default
#line hidden
            BeginContext(130, 69, true);
            WriteLiteral("\r\n<div class=\"esh-orders\">\r\n    <div class=\"container\">\r\n        <h1>");
            EndContext();
            BeginContext(200, 17, false);
#line 9 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(217, 438, true);
            WriteLiteral(@"</h1>
        <article class=""esh-orders-titles row"">
            <section class=""esh-orders-title col-xs-2"">Order number</section>
            <section class=""esh-orders-title col-xs-4"">Date</section>
            <section class=""esh-orders-title col-xs-2"">Total</section>
            <section class=""esh-orders-title col-xs-2"">Status</section>
            <section class=""esh-orders-title col-xs-2""></section>
        </article>
");
            EndContext();
#line 17 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
         if (Model != null && Model.Any())
        {
            

#line default
#line hidden
#line 19 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(767, 118, true);
            WriteLiteral("                <article class=\"esh-orders-items row\">\r\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(886, 46, false);
#line 22 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(932, 74, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-4\">");
            EndContext();
            BeginContext(1007, 44, false);
#line 23 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 76, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-2\">$ ");
            EndContext();
            BeginContext(1128, 40, false);
#line 24 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 74, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(1243, 41, false);
#line 25 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 100, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-1\">\r\n                        ");
            EndContext();
            BeginContext(1384, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b02d24167644cc7a2edd9058e3c6bdc", async() => {
                BeginContext(1492, 6, true);
                WriteLiteral("Detail");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                                                                                                     WriteLiteral(item.OrderNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1502, 98, true);
            WriteLiteral("\r\n                    </section>\r\n                    <section class=\"esh-orders-item col-xs-1\">\r\n");
            EndContext();
#line 30 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                         if (item.Status.ToLower() == "submitted")
                    {

#line default
#line hidden
            BeginContext(1691, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1719, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80407cd620624f5788053a2a8b3c3b31", async() => {
                BeginContext(1827, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                                                                                                         WriteLiteral(item.OrderNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1837, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1866, 60, true);
            WriteLiteral("                    </section>\r\n                </article>\r\n");
            EndContext();
#line 36 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#line 36 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\Web\Views\Order\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1952, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
