#pragma checksum "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd779965bfbf0facdd04e772efdc319644ba7931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.RazorPages.Pages.Basket.Pages_Basket_Index), @"mvc.1.0.razor-page", @"/Pages/Basket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Basket/Index.cshtml", typeof(Microsoft.eShopWeb.RazorPages.Pages.Basket.Pages_Basket_Index), @"{handler?}")]
namespace Microsoft.eShopWeb.RazorPages.Pages.Basket
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd779965bfbf0facdd04e772efdc319644ba7931", @"/Pages/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd525c30c450eb686211a73e894e7915b393629", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Basket_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn esh-basket-checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("updatebutton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
  
    ViewData["Title"] = "Basket";

#line default
#line hidden
            BeginContext(81, 198, true);
            WriteLiteral("<section class=\"esh-catalog-hero\">\r\n    <div class=\"container\">\r\n        <img class=\"esh-catalog-title\" src=\"../images/main_banner_text.png\" />\r\n    </div>\r\n</section>\r\n\r\n<div class=\"container\">\r\n\r\n");
            EndContext();
#line 14 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
     if (Model.BasketModel.Items.Any())
    {

#line default
#line hidden
            BeginContext(327, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(335, 3816, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ad102b3c0a4dd7b645fdc1fdd86448", async() => {
                BeginContext(355, 546, true);
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
#line 26 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
                 for (int i=0; i< Model.BasketModel.Items.Count; i++)
                {
                    var item = Model.BasketModel.Items[i];

#line default
#line hidden
                BeginContext(1051, 263, true);
                WriteLiteral(@"                    <article class=""esh-basket-items row"">
                        <div>
                            <section class=""esh-basket-item esh-basket-item--middle col-lg-3 hidden-lg-down"">
                                <img class=""esh-basket-image""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1314, "\"", 1336, 1);
#line 32 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
WriteAttributeValue("", 1320, item.PictureUrl, 1320, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1337, 139, true);
                WriteLiteral(" />\r\n                            </section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-3\">");
                EndContext();
                BeginContext(1477, 16, false);
#line 34 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
                                                                                         Write(item.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(1493, 108, true);
                WriteLiteral("</section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">$ ");
                EndContext();
                BeginContext(1602, 29, false);
#line 35 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
                                                                                           Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(1631, 160, true);
                WriteLiteral("</section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">\r\n                                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1791, "\"", 1823, 1);
#line 37 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
WriteAttributeValue("", 1798, "Items[" + i + "].Key", 1798, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1824, "\"", 1840, 1);
#line 37 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
WriteAttributeValue("", 1832, item.Id, 1832, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1841, 90, true);
                WriteLiteral(" />\r\n                                <input type=\"number\" class=\"esh-basket-input\" min=\"1\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1931, "\"", 1965, 1);
#line 38 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
WriteAttributeValue("", 1938, "Items[" + i + "].Value", 1938, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1966, "\"", 1988, 1);
#line 38 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
WriteAttributeValue("", 1974, item.Quantity, 1974, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1989, 163, true);
                WriteLiteral(" />\r\n                            </section>\r\n                            <section class=\"esh-basket-item esh-basket-item--middle esh-basket-item--mark col-xs-2\">$ ");
                EndContext();
                BeginContext(2153, 60, false);
#line 40 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
                                                                                                                 Write(Math.Round(item.Quantity * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(2213, 153, true);
                WriteLiteral("</section>\r\n                        </div>\r\n                        <div class=\"row\">\r\n\r\n                        </div>\r\n                    </article>\r\n");
                EndContext();
                BeginContext(2510, 586, true);
                WriteLiteral(@"                    <div class=""container"">
                        <article class=""esh-basket-titles esh-basket-titles--clean row"">
                            <section class=""esh-basket-title col-xs-10""></section>
                            <section class=""esh-basket-title col-xs-2"">Total</section>
                        </article>

                        <article class=""esh-basket-items row"">
                            <section class=""esh-basket-item col-xs-10""></section>
                            <section class=""esh-basket-item esh-basket-item--mark col-xs-2"">$ ");
                EndContext();
                BeginContext(3097, 25, false);
#line 58 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
                                                                                         Write(Model.BasketModel.Total());

#line default
#line hidden
                EndContext();
                BeginContext(3122, 268, true);
                WriteLiteral(@"</section>
                        </article>

                        <article class=""esh-basket-items row"">
                            <section class=""esh-basket-item col-xs-7""></section>
                            <section class=""esh-basket-item col-xs-2"">
");
                EndContext();
                BeginContext(3522, 104, true);
                WriteLiteral("                            </section>\r\n                        </article>\r\n                    </div>\r\n");
                EndContext();
#line 68 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(3645, 94, true);
                WriteLiteral("                <section class=\"esh-basket-item col-xs-push-8 col-xs-4\">\r\n                    ");
                EndContext();
                BeginContext(3739, 157, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70bb31c2ce1c408db680dff39180310e", async() => {
                    BeginContext(3877, 10, true);
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3896, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3918, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "497d1f2ea31b442287d2f7e6c326f153", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_5.Value;
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
                BeginContext(4084, 60, true);
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
            BeginContext(4151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(4177, 91, true);
            WriteLiteral("        <div class=\"esh-catalog-items row\">\r\n            Basket is empty.\r\n        </div>\r\n");
            EndContext();
#line 85 "C:\dev\gitper\rlopezda\eshoponweb_local\eshoponweb\src\WebRazorPages\Pages\Basket\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4275, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
