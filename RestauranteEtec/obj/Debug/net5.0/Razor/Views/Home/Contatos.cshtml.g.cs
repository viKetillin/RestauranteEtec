#pragma checksum "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\Contatos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756468b7017942ad486988d1b130cf9a33a1ce2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contatos), @"mvc.1.0.view", @"/Views/Home/Contatos.cshtml")]
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
#line 1 "D:\etec\RestauranteEtec\RestauranteEtec\Views\_ViewImports.cshtml"
using RestauranteEtec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\etec\RestauranteEtec\RestauranteEtec\Views\_ViewImports.cshtml"
using RestauranteEtec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756468b7017942ad486988d1b130cf9a33a1ce2c", @"/Views/Home/Contatos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec6ffb7a6cb3ace4e99614baab6122d53ef1c87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contatos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\Contatos.cshtml"
  
    ViewData["Title"] = "Contatos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hero-wrap hero-wrap-2"" style=""background-image: url('images/bg_5.jpg');"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-5"">
                <h1 class=""mb-2 bread"">Contact us</h1>
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home <i class=""fa fa-chevron-right""></i></a></span> <span>Contact us <i class=""fa fa-chevron-right""></i></span></p>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section contact-section bg-light"">
    <div class=""container"">
        <div class=""row d-flex contact-info"">
            <div class=""col-md-12"">
                <h2 class=""h4 font-weight-bold"">Contact Information</h2>
            </div>
            <div class=""w-100""></div>
            <div class=""col-md-3 d-flex"">
                <d");
            WriteLiteral(@"iv class=""dbox"">
                    <p><span>Address:</span> 198 West 21th Street, Suite 721 New York NY 10016</p>
                </div>
            </div>
            <div class=""col-md-3 d-flex"">
                <div class=""dbox"">
                    <p><span>Phone:</span> <a href=""tel://1234567920"">+ 1235 2355 98</a></p>
                </div>
            </div>
            <div class=""col-md-3 d-flex"">
                <div class=""dbox"">
                    <p><span>Email:</span> <a href=""mailto:info@yoursite.com"">info@yoursite.com</a></p>
                </div>
            </div>
            <div class=""col-md-3 d-flex"">
                <div class=""dbox"">
                    <p><span>Website</span> <a href=""#"">yoursite.com</a></p>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-no-pt contact-section"">
    <div class=""container"">
        <div class=""row d-flex align-items-stretch no-gutters"">
            <div class=");
            WriteLiteral("\"col-md-6 p-5 order-md-last\">\r\n                <h2 class=\"h4 mb-5 font-weight-bold\">Contact Us</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "756468b7017942ad486988d1b130cf9a33a1ce2c6023", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Your Name"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Your Email"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Subject"">
                    </div>
                    <div class=""form-group"">
                        <textarea");
                BeginWriteAttribute("name", " name=\"", 2798, "\"", 2805, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2806, "\"", 2811, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Message""></textarea>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-3 px-5"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6 d-flex align-items-stretch\">\r\n                <div id=\"map\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
