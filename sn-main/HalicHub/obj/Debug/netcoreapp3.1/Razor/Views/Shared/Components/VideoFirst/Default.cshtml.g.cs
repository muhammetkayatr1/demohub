#pragma checksum "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea74e93eb1f0cab6bef89f6509d25c63f1a96213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VideoFirst_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VideoFirst/Default.cshtml")]
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
#line 1 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using Halic.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea74e93eb1f0cab6bef89f6509d25c63f1a96213", @"/Views/Shared/Components/VideoFirst/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VideoFirst_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 5 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
 foreach (var item in Model.Videos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"videos__large__item set-bg\" data-setbg=\"/img/");
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
                                                    Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <button type=\"button\" class=\"video-btn play-btn\" data-toggle=\"modal\" data-src=\"https://www.youtube.com/embed/");
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
                                                                                                            Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#myModal\">\n        <i class=\"fa fa-play\"></i>\n        </button>\n        <div class=\"videos__large__item__text\">\n            <h4>\n                ");
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
           Write(item.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h4>\n            <ul>\n                <li>");
#nullable restore
#line 16 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ul>\n        </div>\n</div>\n");
#nullable restore
#line 20 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591