#pragma checksum "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5d0a52a89094c12a1e43c08b2c093522f0c1cee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_secondPage), @"mvc.1.0.view", @"/Views/Home/secondPage.cshtml")]
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
#line 1 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\_ViewImports.cshtml"
using PROG123;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\_ViewImports.cshtml"
using PROG123.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5d0a52a89094c12a1e43c08b2c093522f0c1cee", @"/Views/Home/secondPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44210dcadf1d9e0ad4e7680409e555499df7622", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_secondPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5d0a52a89094c12a1e43c08b2c093522f0c1cee3493", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Second Page</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5d0a52a89094c12a1e43c08b2c093522f0c1cee4558", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n<h2>Account Information</h2>\r\n<p>First Name: ");
#nullable restore
#line 23 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
          Write(Model.FName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>Last Name: ");
#nullable restore
#line 24 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
         Write(Model.LName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>Email: ");
#nullable restore
#line 25 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
     Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>Phone: ");
#nullable restore
#line 26 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
     Write(Model.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>Address: ");
#nullable restore
#line 27 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
       Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>Username: ");
#nullable restore
#line 28 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
        Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>Password: ");
#nullable restore
#line 29 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
        Write(Model.Password);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n     <a");
                BeginWriteAttribute("href", " href=\"", 558, "\"", 592, 1);
#nullable restore
#line 31 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
WriteAttributeValue("", 565, Url.Action("index","Home"), 565, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Go to index of homework</a><br></br>\r\n     <a");
                BeginWriteAttribute("href", " href=\"", 639, "\"", 677, 1);
#nullable restore
#line 32 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
WriteAttributeValue("", 646, Url.Action("firstPage","Home"), 646, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Go to firstPage of homework</a><br></br>\r\n     <a");
                BeginWriteAttribute("href", " href=\"", 728, "\"", 767, 1);
#nullable restore
#line 33 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
WriteAttributeValue("", 735, Url.Action("EditPerson","Home"), 735, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Go to Edit Person</a>\r\n     <a");
                BeginWriteAttribute("href", " href=\"", 799, "\"", 840, 1);
#nullable restore
#line 34 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\secondPage.cshtml"
WriteAttributeValue("", 806, Url.Action("DeletePerson","Home"), 806, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> Delete Person</a>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
