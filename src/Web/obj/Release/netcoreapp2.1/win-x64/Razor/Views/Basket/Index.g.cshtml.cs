#pragma checksum "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a9fd52edae849a12042872e2ef5e2613672c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basket/Index.cshtml", typeof(AspNetCore.Views_Basket_Index))]
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
#line 1 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a9fd52edae849a12042872e2ef5e2613672c4e", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ffe0dcf775aeb111c903b0fbc363dc8cef1f2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn esh-basket-checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("updatebutton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("[ Checkout ]"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Basket";

#line default
#line hidden
            BeginContext(108, 198, true);
            WriteLiteral("<section class=\"esh-catalog-hero\">\r\n    <div class=\"container\">\r\n        <img class=\"esh-catalog-title\" src=\"../images/main_banner_text.png\" />\r\n    </div>\r\n</section>\r\n\r\n<div class=\"container\">\r\n\r\n");
            EndContext();
#line 14 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
     if (Model.Items.Any())
    {

#line default
#line hidden
            BeginContext(342, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(350, 3775, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cafd52f57864bf7857091e1690af387", async() => {
                BeginContext(370, 546, true);
                WriteLiteral(@"
            <article class=""esh-basket-titles row"">
                <br />
                <section class=""esh-basket-title col-xs-3"">Product</section>
                <section class=""esh-basket-title col-xs-3 hidden-lg-down""></section>
                <section class=""esh-basket-title col-xs-2"">Price</section>
                <section class=""esh-basket-title col-xs-2"">Quantity</section>
                <section class=""esh-basket-title col-xs-2"">Cost</section>
            </article>
            <div class=""esh-catalog-items row"">
");
                EndContext();
#line 26 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
                 for (int i=0; i< Model.Items.Count; i++)
                {
                    var item = Model.Items[i];

#line default
#line hidden
                BeginContext(1042, 263, true);
                WriteLiteral(@"                    <article class=""esh-basket-items row"">
                        <div>
                            <section class=""esh-basket-item esh-basket-item--middle col-lg-3 hidden-lg-down"">
                                <img class=""esh-basket-image""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1305, "\"", 1327, 1);
#line 32 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1311, item.PictureUrl, 1311, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1328, 139, true);
                WriteLiteral(" />\r\n                            </section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-3\">");
                EndContext();
                BeginContext(1468, 16, false);
#line 34 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
                                                                                         Write(item.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(1484, 108, true);
                WriteLiteral("</section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">$ ");
                EndContext();
                BeginContext(1593, 29, false);
#line 35 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
                                                                                           Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(1622, 160, true);
                WriteLiteral("</section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">\r\n                                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1782, "\"", 1814, 1);
#line 37 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1789, "Items[" + i + "].Key", 1789, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1815, "\"", 1831, 1);
#line 37 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1823, item.Id, 1823, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1832, 90, true);
                WriteLiteral(" />\r\n                                <input type=\"number\" class=\"esh-basket-input\" min=\"1\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1922, "\"", 1956, 1);
#line 38 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1929, "Items[" + i + "].Value", 1929, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1957, "\"", 1979, 1);
#line 38 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1965, item.Quantity, 1965, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1980, 163, true);
                WriteLiteral(" />\r\n                            </section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle esh-basket-item--mark col-xs-2\">$ ");
                EndContext();
                BeginContext(2144, 60, false);
#line 40 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
                                                                                                                 Write(Math.Round(item.Quantity * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(2204, 153, true);
                WriteLiteral("</section>\r\n                        </div>\r\n                        <div class=\"row\">\r\n\r\n                        </div>\r\n                    </article>\r\n");
                EndContext();
                BeginContext(2501, 586, true);
                WriteLiteral(@"                    <div class=""container"">
                        <article class=""esh-basket-titles esh-basket-titles--clean row"">
                            <section class=""esh-basket-title col-xs-10""></section>
                            <section class=""esh-basket-title col-xs-2"">Total</section>
                        </article>

                        <article class=""esh-basket-items row"">
                            <section class=""esh-basket-item col-xs-10""></section>
                            <section class=""esh-basket-item esh-basket-item--mark col-xs-2"">$ ");
                EndContext();
                BeginContext(3088, 13, false);
#line 58 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
                                                                                         Write(Model.Total());

#line default
#line hidden
                EndContext();
                BeginContext(3101, 268, true);
                WriteLiteral(@"</section>
                        </article>

                        <article class=""esh-basket-items row"">
                            <section class=""esh-basket-item col-xs-7""></section>
                            <section class=""esh-basket-item col-xs-2"">
");
                EndContext();
                BeginContext(3501, 104, true);
                WriteLiteral("                            </section>\r\n                        </article>\r\n                    </div>\r\n");
                EndContext();
#line 68 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(3624, 94, true);
                WriteLiteral("                <section class=\"esh-basket-item col-xs-push-8 col-xs-4\">\r\n                    ");
                EndContext();
                BeginContext(3718, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "720839df6d0041dbb9589772866852cd", async() => {
                    BeginContext(3849, 10, true);
                    WriteLiteral("[ Update ]");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3868, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3890, 168, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d4e365c50dd45a29374bbfa85edcc15", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4058, 60, true);
                WriteLiteral("\r\n                </section>\r\n\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(4151, 91, true);
            WriteLiteral("        <div class=\"esh-catalog-items row\">\r\n            Basket is empty.\r\n        </div>\r\n");
            EndContext();
#line 85 "C:\RLGit\demos\eShopOnWeb\src\Web\Views\Basket\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4249, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
