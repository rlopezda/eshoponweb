#pragma checksum "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96bcee693c220639d71e20ab06209453b6b870d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Detail.cshtml", typeof(AspNetCore.Views_Order_Detail))]
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
#line 1 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#line 1 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#line 3 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#line 4 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#line 5 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96bcee693c220639d71e20ab06209453b6b870d3", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ffe0dcf775aeb111c903b0fbc363dc8cef1f2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "My Order History";

#line default
#line hidden
#line 6 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "Order Detail";

#line default
#line hidden
            BeginContext(165, 666, true);
            WriteLiteral(@"
<div class=""esh-orders_detail"">
    <div class=""container"">
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-3"">Order number</section>
                <section class=""esh-orders_detail-title col-xs-3"">Date</section>
                <section class=""esh-orders_detail-title col-xs-3"">Total</section>
                <section class=""esh-orders_detail-title col-xs-3"">Status</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-3"">");
            EndContext();
            BeginContext(832, 17, false);
#line 21 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderNumber);

#line default
#line hidden
            EndContext();
            BeginContext(849, 77, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-item col-xs-3\">");
            EndContext();
            BeginContext(927, 15, false);
#line 22 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(942, 78, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-item col-xs-3\">$");
            EndContext();
            BeginContext(1021, 11, false);
#line 23 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 78, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-title col-xs-3\">");
            EndContext();
            BeginContext(1111, 12, false);
#line 24 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1123, 58, true);
            WriteLiteral("</section>\r\n            </article>\r\n        </section>\r\n\r\n");
            EndContext();
            BeginContext(1613, 361, true);
            WriteLiteral(@"
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">Shipping Address</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-12"">");
            EndContext();
            BeginContext(1975, 28, false);
#line 44 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.Street);

#line default
#line hidden
            EndContext();
            BeginContext(2003, 163, true);
            WriteLiteral("</section>\r\n            </article>\r\n\r\n            <article class=\"esh-orders_detail-items row\">\r\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2167, 26, false);
#line 48 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.City);

#line default
#line hidden
            EndContext();
            BeginContext(2193, 163, true);
            WriteLiteral("</section>\r\n            </article>\r\n\r\n            <article class=\"esh-orders_detail-items row\">\r\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2357, 29, false);
#line 52 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2386, 289, true);
            WriteLiteral(@"</section>
            </article>
        </section>

        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">ORDER DETAILS</section>
            </article>

");
            EndContext();
#line 61 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
             for (int i = 0; i < Model.OrderItems.Count; i++)
            {
                var item = Model.OrderItems[i];

#line default
#line hidden
            BeginContext(2802, 241, true);
            WriteLiteral("                <article class=\"esh-orders_detail-items esh-orders_detail-items--border row\">\r\n                    <section class=\"esh-orders_detail-item col-md-4 hidden-md-down\">\r\n                        <img class=\"esh-orders_detail-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3043, "\"", 3065, 1);
#line 66 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
WriteAttributeValue("", 3049, item.PictureUrl, 3049, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3066, 135, true);
            WriteLiteral(">\r\n                    </section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-4\">");
            EndContext();
            BeginContext(3202, 16, false);
#line 68 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                               Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3218, 114, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">$ ");
            EndContext();
            BeginContext(3333, 29, false);
#line 69 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                                 Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3362, 112, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">");
            EndContext();
            BeginContext(3475, 10, false);
#line 70 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                               Write(item.Units);

#line default
#line hidden
            EndContext();
            BeginContext(3485, 114, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-2\">$ ");
            EndContext();
            BeginContext(3600, 57, false);
#line 71 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                                 Write(Math.Round(item.Units * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3657, 40, true);
            WriteLiteral("</section>\r\n                </article>\r\n");
            EndContext();
#line 73 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(3712, 612, true);
            WriteLiteral(@"        </section>

        <section class=""esh-orders_detail-section esh-orders_detail-section--right"">
            <article class=""esh-orders_detail-titles esh-basket-titles--clean row"">
                <section class=""esh-orders_detail-title col-xs-9""></section>
                <section class=""esh-orders_detail-title col-xs-2"">TOTAL</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-9""></section>
                <section class=""esh-orders_detail-item esh-orders_detail-item--mark col-xs-2"">$ ");
            EndContext();
            BeginContext(4325, 11, false);
#line 84 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Order\Detail.cshtml"
                                                                                           Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(4336, 76, true);
            WriteLiteral("</section>\r\n            </article>\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
