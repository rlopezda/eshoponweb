#pragma checksum "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c449c073e139a5a6e77ec3402b50cc5ea357439e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.RazorPages.Pages.Order.Pages_Order_Index), @"mvc.1.0.razor-page", @"/Pages/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Order/Index.cshtml", typeof(Microsoft.eShopWeb.RazorPages.Pages.Order.Pages_Order_Index), null)]
namespace Microsoft.eShopWeb.RazorPages.Pages.Order
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 2 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.RazorPages;

#line default
#line hidden
#line 2 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.RazorPages.ViewModels;

#line default
#line hidden
#line 3 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c449c073e139a5a6e77ec3402b50cc5ea357439e", @"/Pages/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd525c30c450eb686211a73e894e7915b393629", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Order_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("esh-orders-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
   
    ViewData["Title"] = "My Order History";

#line default
#line hidden
            BeginContext(100, 69, true);
            WriteLiteral("\r\n<div class=\"esh-orders\">\r\n    <div class=\"container\">\r\n        <h1>");
            EndContext();
            BeginContext(170, 17, false);
#line 10 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(187, 438, true);
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
#line 18 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
         if (Model.Orders != null && Model.Orders.Any())
        {
            

#line default
#line hidden
#line 20 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
             foreach (var item in Model.Orders)
            {

#line default
#line hidden
            BeginContext(758, 118, true);
            WriteLiteral("                <article class=\"esh-orders-items row\">\r\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(877, 46, false);
#line 23 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(923, 74, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-4\">");
            EndContext();
            BeginContext(998, 44, false);
#line 24 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 76, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-2\">$ ");
            EndContext();
            BeginContext(1119, 40, false);
#line 25 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 74, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(1234, 41, false);
#line 26 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 100, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-1\">\r\n                        ");
            EndContext();
            BeginContext(1375, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7646e24f7de4cb8b3bd07751184f262", async() => {
                BeginContext(1458, 6, true);
                WriteLiteral("Detail");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
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
            BeginContext(1468, 98, true);
            WriteLiteral("\r\n                    </section>\r\n                    <section class=\"esh-orders-item col-xs-1\">\r\n");
            EndContext();
#line 31 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
                         if (item.Status.ToLower() == "submitted")
                    {

#line default
#line hidden
            BeginContext(1657, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1685, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c86d2d2d3f74f61a7c07ec13ad75a46", async() => {
                BeginContext(1768, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
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
            BeginContext(1778, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1807, 60, true);
            WriteLiteral("                    </section>\r\n                </article>\r\n");
            EndContext();
#line 37 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
            }

#line default
#line hidden
#line 37 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Order\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1893, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
