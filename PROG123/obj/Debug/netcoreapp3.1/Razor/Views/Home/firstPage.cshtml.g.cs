#pragma checksum "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b808358b1b130cfac021d1f376558b27f328f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_firstPage), @"mvc.1.0.view", @"/Views/Home/firstPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b808358b1b130cfac021d1f376558b27f328f0", @"/Views/Home/firstPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44210dcadf1d9e0ad4e7680409e555499df7622", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_firstPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonModel>
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
#line 1 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b808358b1b130cfac021d1f376558b27f328f03514", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>First Page</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b808358b1b130cfac021d1f376558b27f328f04578", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
     using (Html.BeginForm("secondPage", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label for=\"FName\">First Name:</label>\r\n            <input type=\"text\" name=\"FName\" id=\"FName\"");
                BeginWriteAttribute("value", " value=\"", 500, "\"", 520, 1);
#nullable restore
#line 24 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
WriteAttributeValue("", 508, Model.FName, 508, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("            <br>\r\n");
                WriteLiteral("            <label for=\"LName\">Last Name:</label>\r\n            <input type=\"text\" name=\"LName\" id=\"LName\"");
                BeginWriteAttribute("value", " value=\"", 651, "\"", 671, 1);
#nullable restore
#line 29 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
WriteAttributeValue("", 659, Model.LName, 659, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("            <br>\r\n");
                WriteLiteral("            <label for=\"Email\">Email:</label>\r\n            <input type=\"email\" name=\"Email\" id=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 799, "\"", 819, 1);
#nullable restore
#line 34 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
WriteAttributeValue("", 807, Model.Email, 807, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("            <br>\r\n");
                WriteLiteral("            <label for=\"Phone\">Phone:</label>\r\n            <input type=\"text\" name=\"Phone\" id=\"Phone\"");
                BeginWriteAttribute("value", " value=\"", 946, "\"", 966, 1);
#nullable restore
#line 39 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
WriteAttributeValue("", 954, Model.Phone, 954, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("            <br>\r\n");
                WriteLiteral("            <label for=\"Address\">Address:</label>\r\n            <input type=\"text\" name=\"Address\" id=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 1101, "\"", 1123, 1);
#nullable restore
#line 44 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
WriteAttributeValue("", 1109, Model.Address, 1109, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("            <br>\r\n");
                WriteLiteral("            <label for=\"UserName\">Username:</label>\r\n            <input type=\"text\" name=\"UserName\" id=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 1262, "\"", 1285, 1);
#nullable restore
#line 49 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
WriteAttributeValue("", 1270, Model.UserName, 1270, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("            <br>\r\n");
                WriteLiteral("            <label for=\"Password\">Password:</label>\r\n            <input type=\"password\" name=\"Password\" id=\"Password\"");
                BeginWriteAttribute("value", " value=\"", 1428, "\"", 1451, 1);
#nullable restore
#line 54 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
WriteAttributeValue("", 1436, Model.Password, 1436, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("            <br>\r\n");
                WriteLiteral("            <input type=\"submit\" value=\"Submit\">\r\n");
#nullable restore
#line 59 "C:\Third quarter\PROG 123\PROG123\PROG123\Views\Home\firstPage.cshtml"
    }

#line default
#line hidden
#nullable disable
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