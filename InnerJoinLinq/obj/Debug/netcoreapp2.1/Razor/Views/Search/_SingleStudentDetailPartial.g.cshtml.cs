#pragma checksum "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_SingleStudentDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff215c2c6e67a94a77b30efc8236a26e2224784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search__SingleStudentDetailPartial), @"mvc.1.0.view", @"/Views/Search/_SingleStudentDetailPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/_SingleStudentDetailPartial.cshtml", typeof(AspNetCore.Views_Search__SingleStudentDetailPartial))]
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
#line 1 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\_ViewImports.cshtml"
using InnerJoinLinq;

#line default
#line hidden
#line 2 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\_ViewImports.cshtml"
using InnerJoinLinq.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff215c2c6e67a94a77b30efc8236a26e2224784", @"/Views/Search/_SingleStudentDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd4382e1b78410f0a8afd16ec9ceddb975532163", @"/Views/_ViewImports.cshtml")]
    public class Views_Search__SingleStudentDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InnerJoinLinq.Models.SearchData.SearchListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(182, 214, true);
            WriteLiteral("\r\n<table class=\"table table-bordered table-responsive table hover\">\r\n    <tr>\r\n        <th>Student Id</th>\r\n        <th>Student Name</th>\r\n        <th>Student Age</th>\r\n        <th>Student Class</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_SingleStudentDetailPartial.cshtml"
     foreach (var data in Model)
    {

#line default
#line hidden
            BeginContext(437, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(468, 14, false);
#line 16 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_SingleStudentDetailPartial.cshtml"
           Write(data.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(482, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(506, 16, false);
#line 17 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_SingleStudentDetailPartial.cshtml"
           Write(data.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(522, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(546, 15, false);
#line 18 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_SingleStudentDetailPartial.cshtml"
           Write(data.StudentAge);

#line default
#line hidden
            EndContext();
            BeginContext(561, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(585, 17, false);
#line 19 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_SingleStudentDetailPartial.cshtml"
           Write(data.StudentClass);

#line default
#line hidden
            EndContext();
            BeginContext(602, 26, true);
            WriteLiteral("</td>\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_SingleStudentDetailPartial.cshtml"

    }

#line default
#line hidden
            BeginContext(637, 12, true);
            WriteLiteral("\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InnerJoinLinq.Models.SearchData.SearchListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
