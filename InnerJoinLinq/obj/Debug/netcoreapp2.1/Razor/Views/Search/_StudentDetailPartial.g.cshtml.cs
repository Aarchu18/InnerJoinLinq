#pragma checksum "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b25bf483a6a352d2a5b5d12591bc9f2745d1e86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search__StudentDetailPartial), @"mvc.1.0.view", @"/Views/Search/_StudentDetailPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/_StudentDetailPartial.cshtml", typeof(AspNetCore.Views_Search__StudentDetailPartial))]
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
#line 2 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml"
using InnerJoinLinq.Models.SearchData;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b25bf483a6a352d2a5b5d12591bc9f2745d1e86", @"/Views/Search/_StudentDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd4382e1b78410f0a8afd16ec9ceddb975532163", @"/Views/_ViewImports.cshtml")]
    public class Views_Search__StudentDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SearchListModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 56, true);
            WriteLiteral("\r\n\r\n\r\n    <h2>Student Details</h2>\r\n\r\n    <html>\r\n\r\n    ");
            EndContext();
            BeginContext(129, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab3023b65205400990876f8bbc9b4694", async() => {
                BeginContext(135, 105, true);
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"student details\" />\r\n        <title>student Detail</title>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 10, true);
            WriteLiteral("\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(257, 615, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f34c92c7384ac2b74fc52de709fee5", async() => {
                BeginContext(263, 264, true);
                WriteLiteral(@"
        <table class=""table table-bordered table-responsive table hover"">
            <tr>
                <th>StudentId</th>
                <th>StudentName</th>
                <th>StudentAge</th>
                <th>StudentClass</th>
            </tr>
");
                EndContext();
#line 25 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml"
             foreach (var studentData in Model)
        {



#line default
#line hidden
                BeginContext(591, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(630, 21, false);
#line 30 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml"
               Write(studentData.StudentId);

#line default
#line hidden
                EndContext();
                BeginContext(651, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(679, 23, false);
#line 31 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml"
               Write(studentData.StudentName);

#line default
#line hidden
                EndContext();
                BeginContext(702, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(730, 22, false);
#line 32 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml"
               Write(studentData.StudentAge);

#line default
#line hidden
                EndContext();
                BeginContext(752, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(780, 24, false);
#line 33 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml"
               Write(studentData.StudentClass);

#line default
#line hidden
                EndContext();
                BeginContext(804, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 35 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\InnerJoinLinq\InnerJoinLinq\Views\Search\_StudentDetailPartial.cshtml"
        }

#line default
#line hidden
                BeginContext(841, 24, true);
                WriteLiteral("\r\n        </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(872, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SearchListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591