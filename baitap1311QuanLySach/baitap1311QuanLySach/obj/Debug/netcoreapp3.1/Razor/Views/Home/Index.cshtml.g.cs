#pragma checksum "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85c9bbf599cc3352e7389b2c423f0c464fcb570d"
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
#line 1 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\_ViewImports.cshtml"
using baitap1311QuanLySach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\_ViewImports.cshtml"
using baitap1311QuanLySach.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\_ViewImports.cshtml"
using baitap1311QuanLySach.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c9bbf599cc3352e7389b2c423f0c464fcb570d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdf5e536977b6e00376ee8372831a2a46b8b4bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"text-center\">\r\n        <button class=\"btn btn-dark filter-product-btn\" data-filter=\"all\">All</button>\r\n");
#nullable restore
#line 17 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-dark filter-product-btn\" data-filter=\"");
#nullable restore
#line 19 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
                                                                    Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 19 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
                                                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 20 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"row mt-5\">\r\n");
#nullable restore
#line 24 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
         foreach (var item in Model.Books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 714, "\"", 770, 4);
            WriteAttributeValue("", 722, "col-md-6", 722, 8, true);
            WriteAttributeValue(" ", 730, "pb-4", 731, 5, true);
            WriteAttributeValue(" ", 735, "filter", 736, 7, true);
#nullable restore
#line 26 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 742, item.Category.CategoryName, 743, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card bg-white rounded shadow-sm\">\r\n                    <div class=\"card-body row\">\r\n                        <div class=\"col-7\"><label>");
#nullable restore
#line 29 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
                                             Write(item.NameBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                        <div class=\"col-5\"><label>Số lượng: ");
#nullable restore
#line 30 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
                                                       Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                    </div>\r\n                    <div class=\"card-body row\">\r\n                        <div class=\"col-12\">\r\n                            <span class=\"badge w-100\" style=\"background-color: lawngreen\">");
#nullable restore
#line 34 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
                                                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".filter-product-btn"").click(function () {
                let value = $(this).attr('data-filter');
                if (value == ""all"") {
                    $("".filter"").show('1000');
                }
                else {
                    $("".filter"").not('.' + value).hide('3000');
                    $("".filter"").filter('.' + value).show('3000');
                }
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
