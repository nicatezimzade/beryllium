#pragma checksum "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a661cbfdf7b461343eddd7eb3211c1b3bc176cf6"
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
#line 1 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\_ViewImports.cshtml"
using Beryllium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\_ViewImports.cshtml"
using Beryllium.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\_ViewImports.cshtml"
using Beryllium.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a661cbfdf7b461343eddd7eb3211c1b3bc176cf6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eedcaa8ef8dd5d87cc3e9dfb4d3ab0abe394821", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"gtco-container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"owl-carousel owl-carousel-fullwidth\">\r\n");
#nullable restore
#line 9 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                 foreach (Slider item in Model.sliders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\r\n                        <a href=\"#\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 377, "\"", 395, 1);
#nullable restore
#line 13 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 383, item.ImgSrc, 383, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 396, "\"", 414, 1);
#nullable restore
#line 13 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 402, item.ImgTag, 402, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"slider-copy\">\r\n                                <h2>");
#nullable restore
#line 15 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                               Write(item.ImgName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 19 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral(@"
<div class=""gtco-section"">
    <div class=""gtco-container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2 gtco-heading text-center"">
                <h2>Work</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.</p>
            </div>
        </div>
        <div class=""row"">

            <div class=""col-md-12"">
                <div class=""owl-carousel owl-carousel-carousel"">

");
#nullable restore
#line 41 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                     foreach (Work item in Model.works)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"gtco-item\">\r\n                                <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 1497, "\"", 1516, 1);
#nullable restore
#line 45 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 1503, item.WorkImg, 1503, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1517, "\"", 1523, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"></a>\r\n                                <h2><a href=\"#\">");
#nullable restore
#line 46 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                           Write(item.WorkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                <p class=\"role\">");
#nullable restore
#line 47 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                           Write(item.WorkPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 50 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n<div class=\"gtco-section\">\r\n    <div class=\"gtco-container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 gtco-news\">\r\n                <h2>News</h2>\r\n                <ul>\r\n");
#nullable restore
#line 67 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                     foreach (Post item in  Model.posts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <a href=\"#\">\r\n                                <span class=\"post-date\">");
#nullable restore
#line 71 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                                   Write(item.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h3>");
#nullable restore
#line 72 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                               Write(item.PostTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 73 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                              Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 76 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <p><a href=\"/News/Index\" class=\"btn btn-sm btn-special\">More News</a></p>\r\n            </div>\r\n            <div class=\"col-md-5 col-md-push-1 gtco-testimonials\">\r\n                <h2>Testimonials</h2>\r\n");
#nullable restore
#line 82 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                 foreach (Testimonial item in Model.testimonials)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <blockquote>\r\n                        <p>");
#nullable restore
#line 85 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"author\"><cite>");
#nullable restore
#line 86 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                           Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</cite></p>\r\n                    </blockquote>\r\n");
#nullable restore
#line 88 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n<div class=\"gtco-section gto-features\">\r\n    <div class=\"gtco-container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 100 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
             foreach (Feature item in Model.features)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"feature-left\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 3428, "\"", 3451, 2);
#nullable restore
#line 104 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 3436, item.Icon, 3436, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3446, "icon", 3447, 5, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        <div class=\"copy\">\r\n                            <h3>");
#nullable restore
#line 106 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 107 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                          Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><a href=\"#\" class=\"gtco-more\">");
#nullable restore
#line 108 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                                        Write(item.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 112 "C:\Nicat\codeacademy\backend\Beryllium\Beryllium\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591