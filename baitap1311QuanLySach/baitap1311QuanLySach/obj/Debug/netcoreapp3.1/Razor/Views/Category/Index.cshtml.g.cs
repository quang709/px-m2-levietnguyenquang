#pragma checksum "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09765716278401684d5d7b2f54a1e8134cd7505d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09765716278401684d5d7b2f54a1e8134cd7505d", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdf5e536977b6e00376ee8372831a2a46b8b4bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        Category Name
                    </th>
                    <th>
                        Description
                    </th>
                    <th>
                        Số lượng sản phẩm
                    </th>
                 
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"
                 foreach (var category in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 33 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"
                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td width=\"40%\">\r\n                            ");
#nullable restore
#line 36 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"
                       Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td width=\"10%\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"
                       Write(category.Books.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                      \r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 47 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"


    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Không tồn tại thể loại trong database</p>\r\n");
#nullable restore
#line 53 "C:\Users\admin\source\repos\baitap1311QuanLySach\baitap1311QuanLySach\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
