#pragma checksum "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed1ea9691b69209c2b72443faaed30be6398706a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_back_Index), @"mvc.1.0.view", @"/Views/back/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/back/Index.cshtml", typeof(AspNetCore.Views_back_Index))]
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
#line 1 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\_ViewImports.cshtml"
using R_Azure_backoffice;

#line default
#line hidden
#line 2 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\_ViewImports.cshtml"
using R_Azure_backoffice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed1ea9691b69209c2b72443faaed30be6398706a", @"/Views/back/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e6efe410eb5b68e0768db65719c2f5ccda4f168", @"/Views/_ViewImports.cshtml")]
    public class Views_back_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<R_Azure_backoffice.Models.MvcVolModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 13, true);
            WriteLiteral("\r\n<p>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 115, "\"", 153, 1);
#line 8 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
WriteAttributeValue("", 122, Url.Action("AddOrEdit","back"), 122, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(154, 161, true);
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-plus\"></i>Create New</a>\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(316, 43, false);
#line 16 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nom_vol));

#line default
#line hidden
            EndContext();
            BeginContext(359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(415, 47, false);
#line 19 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.aero_depart));

#line default
#line hidden
            EndContext();
            BeginContext(462, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(518, 46, false);
#line 22 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.aero_arriv));

#line default
#line hidden
            EndContext();
            BeginContext(564, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(620, 47, false);
#line 25 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.date_depart));

#line default
#line hidden
            EndContext();
            BeginContext(667, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(723, 46, false);
#line 28 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.date_arriv));

#line default
#line hidden
            EndContext();
            BeginContext(769, 93, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(894, 51, true);
            WriteLiteral("        <tr>\r\n \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(946, 42, false);
#line 38 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nom_vol));

#line default
#line hidden
            EndContext();
            BeginContext(988, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1044, 46, false);
#line 41 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.aero_depart));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1146, 45, false);
#line 44 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.aero_arriv));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1247, 46, false);
#line 47 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.date_depart));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1349, 45, false);
#line 50 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.date_arriv));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1450, 65, false);
#line 53 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1536, 71, false);
#line 54 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1628, 69, false);
#line 55 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Amady\Documents\RAZURE-master\R_Azure_backoffice\Views\back\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1736, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<R_Azure_backoffice.Models.MvcVolModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
