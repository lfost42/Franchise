#pragma checksum "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d9c7dd00d443dad17c28b00fcba1b10f04e687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/_ViewImports.cshtml"
using Franchise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/_ViewImports.cshtml"
using Franchise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d9c7dd00d443dad17c28b00fcba1b10f04e687", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e24a94b52f6bb31faef43ad5d3fc09fca1fa02de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Franchise.Data.Databases.ParserControl>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fragment", "promo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
  
    ViewData["appName"] = "Franchise Analytics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Header -->\n<div id=\"hero-wrapper\">\n    <div id=\"header\" class=\"container\">\n\n        <!-- Logo -->\n\n        <h1 id=\"logo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d9c7dd00d443dad17c28b00fcba1b10f04e6875832", async() => {
                WriteLiteral("\n        <img src=\"/images/brand.png\" width=\"35\" height=\"35\" alt=\"zen icon\" style=\"vertical-align:middle\">\n    Franchise\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h1>

        <!-- Nav -->
        <nav id=""nav"">
            <ul navbar-nav me-auto mb-2 mb-md-0>
                <li class=""nav-item""><a href=""#map"">Map</a></li>
                <li class=""nav-item""><a href=""#statistics"">Statistics</a></li>
                <li class=""break nav-item""><a href=""https://github.com/lfost42/Franchise"">Code</a></li>
                <li class=""nav-item""><a href=""https://lfost42-portfolio.netlify.app/"">About Me</a></li>
            </ul>
        </nav>
    </div>

    <!-- Hero -->
    <section id=""hero"" class=""container"">
        <header>
            <h2>
                Explore the Coverage<br>
                Health of a Franchise
            </h2>
        </header>
        <p>Mapping &bull; Geolocation &bull; Parsing &bull; Statistics</p>
        <ul class=""actions"">
            <li><a href=""#promo"" class=""button"">Get Started!</a></li>
        </ul>
    </section>
</div>

<!-- Map Section -->
<div class=""wrapper"">
    <div class=""container"">
        <div class=""iframe-container");
            WriteLiteral(@""" id=""map"">
            <article id=""content"">
                <iframe class=""responsive-iframe"" height=""425px"" width=""90%"" aria-hidden=""false"" src=""https://www.google.com/maps/d/u/0/embed?mid=1KOCWWtSISOanuMx0WAbfQ9djhId_cIUs&ehbc=2E312F""></iframe>

            </article>
        </div>
        <p>
            <br />
            Our sample data includes 237 Taco Bell locations in Alabama. <br />
            Click the white square in the left corner of the black bar to explore map locations.
        </p>
    </div>
</div>


");
            WriteLiteral(@"<!--<ul class=""actions major gx-3 gy-2"">
    <li>
        <div title=""View all locations in the current dataset on the map"">
            <a href=""#map"" class=""button"" onclick=""allLocations()"">All Locations</a>
        </div>
    </li>

    <li>
        <div title=""View the two locations that are farthest apart in the current dataset"">
            <a href=""#map"" class=""button"" onclick=""distance()"">Distance Results</a>
        </div>
    </li>
</ul>-->
");
            WriteLiteral("\n<!-- Promo Section -->\n<div id=\"promo-wrapper\">\n    <section id=\"promo\" class=\"row\">\n        <ul>\n            <h3>\n");
            WriteLiteral(@"            <li>Explore Data Table</li>
            <li>Determine which locations are farthest apart</li>
            </h3>
        </ul>
        Our demo includes 237 Taco Bell locations.<br />
        Click 'Data Table' to view and search locations.<br />
    </section>

    <ul class=""actions col-12 mt-4"">

");
            WriteLiteral("        <li>\n            <div class=\"col\" title=\"View the current list of locations\">\n                ");
#nullable restore
#line 99 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
           Write(Html.ActionLink("Data Table", "Index", "Locations", null, new { @class = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </li>\n");
            WriteLiteral("\n\n\n");
            WriteLiteral("        <li>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d9c7dd00d443dad17c28b00fcba1b10f04e68710766", async() => {
                WriteLiteral(@"
                <div id=""dvScroll"" title=""Determine which locations in the current data set are farthest apart."">
                    <button type=""submit"" class=""button"">
                        Distance Function
                    </button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Fragment = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </li>\n    </ul>\n\n    <div class=\"distance_position\">\n        <table");
            BeginWriteAttribute("class", " class=\"", 3856, "\"", 3942, 2);
            WriteAttributeValue("", 3864, "tabledistance", 3864, 13, true);
#nullable restore
#line 119 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
WriteAttributeValue(" ", 3877, Model.solution.isPosted ? Html.Raw("show") : Html.Raw("hide"), 3878, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <tr>\n                <td>");
#nullable restore
#line 121 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.solution.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\n                <td>\n                    ");
#nullable restore
#line 123 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(model => model.solution.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n\n            <tr>\n                <td class=\"head\">Location 1: </td>\n                <td>");
#nullable restore
#line 129 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(model => model.solution.Location1.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    (");
#nullable restore
#line 131 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
                Write(Html.DisplayFor(model => model.solution.Location1.GeoPoint.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 131 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.solution.Location1.GeoPoint.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n                </td>\n            </tr>\n\n            <tr>\n                <td class=\"head\">Location 2: </td>\n                <td>");
#nullable restore
#line 137 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(model => model.solution.Location2.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    (");
#nullable restore
#line 139 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
                Write(Html.DisplayFor(model => model.solution.Location2.GeoPoint.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 139 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.solution.Location2.GeoPoint.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n                </td>\n            </tr>\n\n            <tr>\n                <td class=\"head\">");
#nullable restore
#line 144 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
                            Write(Html.DisplayNameFor(model => model.solution.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\n                <td>\n                    ");
#nullable restore
#line 146 "/Users/lynda/Desktop/repo/Franchise/Franchise/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(model => model.solution.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles\n                </td>\n            </tr>\n        </table>\n    </div>\n");
            WriteLiteral(@"</div>


<!-- Statistics Section -->
<div class=""wrapper"">
    <section class=""container"" id=""statistics"">
        <header class=""major"">
            <h2>Statistics</h2>
        </header>

        <div class=""row"">
            <section class=""col-12 col-xs-12 col-sm-12 col-md-4 feature image-center"">
                <div class=""image-wrapper"">
                    <img src=""images/pic03.jpg"" alt=""whisker chart placeholder"" onclick=""statistics()"" />
                </div>
                <p>Placeholder</p>
            </section>
");
            WriteLiteral("        </div>\n        <ul class=\"actions major\">\n            <li><div title=\"Export charts as a png file.\"><a href=\"#statistics\" class=\"button\" onclick=\"exportStatistics()\">Export Charts</a></div></li>\n        </ul>\n    </section>\n</div>\n\n\n<script>\n");
            WriteLiteral("    function statistics() {\n        alert(\"Chart to display live statistics as the datastet is modified\");\n    }\n    function exportStatistics() {\n        alert(\"User may export the charts as a png.\");\n    }</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Franchise.Data.Databases.ParserControl> Html { get; private set; }
    }
}
#pragma warning restore 1591
