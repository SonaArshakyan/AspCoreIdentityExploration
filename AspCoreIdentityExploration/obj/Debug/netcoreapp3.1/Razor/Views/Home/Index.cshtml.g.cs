#pragma checksum "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f350cb1daca0fd6c727f7b670fab3b55d2b4230"
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
#line 1 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\_ViewImports.cshtml"
using AspCoreIdentityExploration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\_ViewImports.cshtml"
using AspCoreIdentityExploration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f350cb1daca0fd6c727f7b670fab3b55d2b4230", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8e16155a43d0ddddcd27f2be169a72cc471620", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
  
    var fullname = User.Identity.IsAuthenticated ?
        User.Claims.First(c => c.Type == "FullName").Value : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
  if (fullname == null) fullname = " ";

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n<div class=\"container\">\r\n    <h1 style=\"color:red\">Claims of ");
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
                               Write(fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n\r\n            <table class=\" table-bordered\" style=\"width:100%\">\r\n");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
                 foreach (var claim in User.Claims)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
                       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
                       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\AspCoreIdentityExploration\AspCoreIdentityExploration\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591