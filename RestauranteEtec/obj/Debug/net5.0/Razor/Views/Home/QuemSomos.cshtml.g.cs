#pragma checksum "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42810ec1cd80f9ac680988b5edc6f8bb6fb7bb96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QuemSomos), @"mvc.1.0.view", @"/Views/Home/QuemSomos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42810ec1cd80f9ac680988b5edc6f8bb6fb7bb96", @"/Views/Home/QuemSomos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec6ffb7a6cb3ace4e99614baab6122d53ef1c87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QuemSomos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
  
    ViewData["Title"] = "Quem Somos";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"hero-wrap hero-wrap-2\"");
            BeginWriteAttribute("style", " style=\"", 84, "\"", 150, 4);
            WriteAttributeValue("", 92, "background-image:", 92, 17, true);
            WriteAttributeValue("\r\n", 109, "url(", 111, 6, true);
#nullable restore
#line 5 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 115, Url.Content("~/images/bg_5.jpg"), 115, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 148, ");", 148, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""overlay"">
    </div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-5"">
                <h1 class=""mb-2 bread"">Quem Somos</h1>
                <p class=""breadcrumbs""><span class=""mr-2"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42810ec1cd80f9ac680988b5edc6f8bb6fb7bb964546", async() => {
                WriteLiteral("Home <i class=\"fa fachevron-right\"></i>");
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
            WriteLiteral(@"</span> <span>Quem Somos <i class=""fa fa-chevron-right""></i></span></p>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-no-pt ftco-no-pb"">
    <div class=""container"">
        <div class=""row d-flex"">
            <div class=""col-md-6 d-flex"">
                <div class=""img img-2 w-100 mr-md-2""");
            BeginWriteAttribute("style", " style=\"", 938, "\"", 1004, 4);
            WriteAttributeValue("", 946, "background-image:", 946, 17, true);
            WriteAttributeValue("\r\n", 963, "url(", 965, 6, true);
#nullable restore
#line 22 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 969, Url.Content("~/images/bg_6.jpg"), 969, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1002, ");", 1002, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div class=\"img img-2 w-100 ml-md-2\"");
            BeginWriteAttribute("style", " style=\"", 1066, "\"", 1132, 4);
            WriteAttributeValue("", 1074, "background-image:", 1074, 17, true);
            WriteAttributeValue("\r\n", 1091, "url(", 1093, 6, true);
#nullable restore
#line 24 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 1097, Url.Content("~/images/bg_4.jpg"), 1097, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1130, ");", 1130, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
            </div>
            <div class=""col-md-6 ftco-animate makereservation p-4 p-md-5"">
                <div class=""heading-section ftco-animate mb-5"">
                    <span class=""subheading"">This is our secrets</span>
                    <h2 class=""mb-4"">Perfect Ingredients</h2>
                    <p>
                        Far far away, behind the word mountains, far from the countries Vokalia and
                        Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of
                        the Semantics, a large language ocean.
                    </p>
                    <p><a href=""#"" class=""btn btn-primary"">Learn more</a></p>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-counter img"" id=""section-counter""");
            BeginWriteAttribute("style", " style=\"", 2011, "\"", 2077, 4);
            WriteAttributeValue("", 2019, "background-image:", 2019, 17, true);
            WriteAttributeValue("\r\n", 2036, "url(", 2038, 6, true);
#nullable restore
#line 42 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 2042, Url.Content("~/images/bg_4.jpg"), 2042, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2075, ");", 2075, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""container"">
        <div class=""row d-md-flex align-items-center justify-content-center"">
            <div class=""col-lg-10"">
                <div class=""row d-md-flex align-items-center"">
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""100"">0</strong>
                                <span>Tasty Dishes</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""4000"">0</strong>
                                <span>Dishes Served</span>
  ");
            WriteLiteral(@"                          </div>
                        </div>
                    </div>
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""10"">0</strong>
                                <span>Restaurants</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""10000"">0</strong>
                                <span>Happy Customers</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>");
            WriteLiteral(@"
    </div>
</section>
<section class=""ftco-section ftco-no-pt ftco-no-pb ftco-intro bg-primary"">
    <div class=""container py-5"">
        <div class=""row py-2"">
            <div class=""col-md-12 text-center"">
                <h2>We Make Delicious &amp; Nutritious Food</h2>
                <a href=""#"" class=""btn btn-white btn-outline-white"">Book A Table Now</a>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section testimony-section""");
            BeginWriteAttribute("style", " style=\"", 4605, "\"", 4671, 4);
            WriteAttributeValue("", 4613, "background-image:", 4613, 17, true);
            WriteAttributeValue("\r\n", 4630, "url(", 4632, 6, true);
#nullable restore
#line 95 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 4636, Url.Content("~/images/bg_5.jpg"), 4636, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4669, ");", 4669, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""overlay"">
    </div>
    <div class=""container"">
        <div class=""row justify-content-center mb-3 pb-2"">
            <div class=""col-md-7 text-center heading-section heading-section-white ftco-animate"">
                <span class=""subheading"">Testimony</span>
                <h2 class=""mb-4"">Happy Customer</h2>
            </div>
        </div>
        <div class=""row ftco-animate justify-content-center"">
            <div class=""col-md-7"">
                <div class=""carousel-testimony owl-carousel ftco-owl"">
                    <div class=""item"">
                        <div class=""testimony-wrap text-center"">
                            <div class=""text p-3"">
                                <p class=""mb-4"">
                                    Far far away, behind the word mountains, far from the
                                    countries Vokalia and Consonantia, there live the blind texts.
                                </p>
                                <div ");
            WriteLiteral("class=\"user-img mb-4\"");
            BeginWriteAttribute("style", " style=\"", 5717, "\"", 5786, 4);
            WriteAttributeValue("", 5725, "background-image:", 5725, 17, true);
            WriteAttributeValue("\r\n", 5742, "url(", 5744, 6, true);
#nullable restore
#line 116 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 5748, Url.Content("~/images/person_1.jpg"), 5748, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5785, ")", 5785, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""quote d-flex align-items-center justify-contentcenter"">
                                        <i class=""fa fa-quote-left""></i>
                                    </span>
                                </div>
                                <p class=""name"">John Gustavo</p>
                                <span class=""position"">Customer</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap text-center"">
                            <div class=""text p-3"">
                                <p class=""mb-4"">
                                    Far far away, behind the word mountains, far from the
                                    countries Vokalia and Consonantia, there live the blind texts.
                                </p>
                                <div class=""user-img mb-4""");
            BeginWriteAttribute("style", " style=\"", 6785, "\"", 6854, 4);
            WriteAttributeValue("", 6793, "background-image:", 6793, 17, true);
            WriteAttributeValue("\r\n", 6810, "url(", 6812, 6, true);
#nullable restore
#line 134 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 6816, Url.Content("~/images/person_1.jpg"), 6816, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6853, ")", 6853, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""quote d-flex align-items-center justify-contentcenter"">
                                        <i class=""fa fa-quote-left""></i>
                                    </span>
                                </div>
                                <p class=""name"">John Gustavo</p>
                                <span class=""position"">Customer</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap text-center"">
                            <div class=""text p-3"">
                                <p class=""mb-4"">
                                    Far far away, behind the word mountains, far from the
                                    countries Vokalia and Consonantia, there live the blind texts.
                                </p>
                                <div class=""user-img mb-4""");
            BeginWriteAttribute("style", " style=\"", 7853, "\"", 7922, 4);
            WriteAttributeValue("", 7861, "background-image:", 7861, 17, true);
            WriteAttributeValue("\r\n", 7878, "url(", 7880, 6, true);
#nullable restore
#line 152 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 7884, Url.Content("~/images/person_1.jpg"), 7884, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7921, ")", 7921, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""quote d-flex align-items-center justify-contentcenter"">
                                        <i class=""fa fa-quote-left""></i>
                                    </span>
                                </div>
                                <p class=""name"">John Gustavo</p>
                                <span class=""position"">Customer</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap text-center"">
                            <div class=""text p-3"">
                                <p class=""mb-4"">
                                    Far far away, behind the word mountains, far from the
                                    countries Vokalia and Consonantia, there live the blind texts.
                                </p>
                                <div class=""user-img mb-4""");
            BeginWriteAttribute("style", " style=\"", 8921, "\"", 8990, 4);
            WriteAttributeValue("", 8929, "background-image:", 8929, 17, true);
            WriteAttributeValue("\r\n", 8946, "url(", 8948, 6, true);
#nullable restore
#line 170 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 8952, Url.Content("~/images/person_1.jpg"), 8952, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8989, ")", 8989, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""quote d-flex align-items-center justify-contentcenter"">
                                        <i class=""fa fa-quote-left""></i>
                                    </span>
                                </div>
                                <p class=""name"">John Gustavo</p>
                                <span class=""position"">Customer</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap text-center"">
                            <div class=""text p-3"">
                                <p class=""mb-4"">
                                    Far far away, behind the word mountains, far from the
                                    countries Vokalia and Consonantia, there live the blind texts.
                                </p>
                                <div class=""user-img mb-4""");
            BeginWriteAttribute("style", " style=\"", 9989, "\"", 10058, 4);
            WriteAttributeValue("", 9997, "background-image:", 9997, 17, true);
            WriteAttributeValue("\r\n", 10014, "url(", 10016, 6, true);
#nullable restore
#line 188 "D:\etec\RestauranteEtec\RestauranteEtec\Views\Home\QuemSomos.cshtml"
WriteAttributeValue("", 10020, Url.Content("~/images/person_1.jpg"), 10020, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10057, ")", 10057, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""quote d-flex align-items-center justify-contentcenter"">
                                        <i class=""fa fa-quote-left""></i>
                                    </span>
                                </div>
                                <p class=""name"">John Gustavo</p>
                                <span class=""position"">Customer</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
