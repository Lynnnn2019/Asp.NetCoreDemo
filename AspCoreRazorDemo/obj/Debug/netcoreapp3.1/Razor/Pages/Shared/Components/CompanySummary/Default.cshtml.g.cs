#pragma checksum "D:\repos\C#\Asp.NetCoreDemo\AspCoreRazorDemo\Pages\Shared\Components\CompanySummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee8f88af226f1ae34da7776774bacccfe93d721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspCoreRazorDemo.Pages.Shared.Components.CompanySummary.Pages_Shared_Components_CompanySummary_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/CompanySummary/Default.cshtml")]
namespace AspCoreRazorDemo.Pages.Shared.Components.CompanySummary
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
#line 1 "D:\repos\C#\Asp.NetCoreDemo\AspCoreRazorDemo\Pages\_ViewImports.cshtml"
using AspCoreRazorDemo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee8f88af226f1ae34da7776774bacccfe93d721", @"/Pages/Shared/Components/CompanySummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd610139d47006e5383ea628d70be8f4ee9c2aff", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_CompanySummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspCoreRazorDemo.Models.CompanySummary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"small\">\r\n        <div class=\"row h6\">");
#nullable restore
#line 4 "D:\repos\C#\Asp.NetCoreDemo\AspCoreRazorDemo\Pages\Shared\Components\CompanySummary\Default.cshtml"
                       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">Employee Count:</div>\r\n            <div class=\"col-md-2\">");
#nullable restore
#line 7 "D:\repos\C#\Asp.NetCoreDemo\AspCoreRazorDemo\Pages\Shared\Components\CompanySummary\Default.cshtml"
                             Write(Model.EmployeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">Average Count :</div>\r\n            <div class=\"col-md-2\">");
#nullable restore
#line 11 "D:\repos\C#\Asp.NetCoreDemo\AspCoreRazorDemo\Pages\Shared\Components\CompanySummary\Default.cshtml"
                             Write(Model.AverageDepartmentEmployeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspCoreRazorDemo.Models.CompanySummary> Html { get; private set; }
    }
}
#pragma warning restore 1591
