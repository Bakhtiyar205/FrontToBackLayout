#pragma checksum "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42d98cb32c6e0639c1adafb5da502fd4581969b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Basket_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Basket/Default.cshtml")]
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
#line 1 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42d98cb32c6e0639c1adafb5da502fd4581969b", @"/Views/Shared/Components/Basket/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81052c4d0d671e0e46db3449fbc1cb187fb05a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Basket_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketDetailVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
  
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
 if (Model.Count() < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"basketelement\" data-count=\"0\">\r\n        <p><i class=\"fa-solid fa-basket-shopping\"></i></p>\r\n        <p>\r\n            No Products in the Card\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"


}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"basket-element\" data-count=\"");
#nullable restore
#line 19 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
                                    Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n        <table class=\"table table-striped\">\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
                 foreach (var basketProduct in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 28 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 31 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
                       Write(basketProduct.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 34 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
                       Write(basketProduct.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 37 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
                       Write(basketProduct.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"
                    count++;

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson8Services,LayoutViewComponent\HomeworkFrontToBack\FrontToBack\FrontToBack\Views\Shared\Components\Basket\Default.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591