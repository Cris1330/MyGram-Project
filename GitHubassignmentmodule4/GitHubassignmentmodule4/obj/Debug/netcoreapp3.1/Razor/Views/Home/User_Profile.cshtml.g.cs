#pragma checksum "/Users/cristalzavala/Desktop/New project /GitHubassignmentmodule4/GitHubassignmentmodule4/Views/Home/User_Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e6064ed0c972a3cd0800cdd05ae8d7ea56bd6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User_Profile), @"mvc.1.0.view", @"/Views/Home/User_Profile.cshtml")]
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
#line 1 "/Users/cristalzavala/Desktop/New project /GitHubassignmentmodule4/GitHubassignmentmodule4/Views/_ViewImports.cshtml"
using GitHubassignmentmodule4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cristalzavala/Desktop/New project /GitHubassignmentmodule4/GitHubassignmentmodule4/Views/_ViewImports.cshtml"
using GitHubassignmentmodule4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e6064ed0c972a3cd0800cdd05ae8d7ea56bd6a", @"/Views/Home/User_Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0855b83b6a18fab8468f3c82639624cf209311de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e6064ed0c972a3cd0800cdd05ae8d7ea56bd6a3451", async() => {
                WriteLiteral("\n    <table>\n        <tbody>\n            <tr>\n                <td>\n                    <label");
                BeginWriteAttribute("for", " for=\"", 100, "\"", 106, 0);
                EndWriteAttribute();
                WriteLiteral(">First Name:</label>\n                </td>\n                <td>\n                    <input type=\"text\" id=\"FirstName\" />\n                </td>\n                <td>\n                    <label");
                BeginWriteAttribute("for", " for=\"", 297, "\"", 303, 0);
                EndWriteAttribute();
                WriteLiteral(@">Last Name:</label>
                </td>
                <td>
                    <input type=""text"" id=""LastName"" />
                </td>
            </tr>
            <tr>
                <td>
                    <lable>Gender:</lable>

                </td>
                <td colspan=""3"">
                    <input type=""radio"" id=""MaleGender"" name=""gender"" />
                    <lable for=""MaleGender"">Male</lable>

                    <input type=""radio"" id=""femaleGender"" name=""gender"" />
                    <lable for=""femalGender"">female</lable>

                    <input type=""radio"" id=""NoResponseGender"" name=""gender"" />
                    <lable for=""NoResponseGender"">Prefer not to respond</lable>

                </td>
            </tr>
            <tr> 
                <td colspan=""2"">
                    <label for=""Email"">Email:</label>
                    <input type=""email"" id=""Email"" />

                </td>
        </tr>

          <tr>
              <td>
                  <label for=""");
                WriteLiteral("Country\"> Country of Recidence </label>\n              </td>\n              <td>\n                  <select>\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e6064ed0c972a3cd0800cdd05ae8d7ea56bd6a5522", async() => {
                    WriteLiteral("\n                          Usa\n                      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                  </select>\n              </td>\n          </tr>\n             \n            <tr>\n                <td colspan=\"4\">\n                    <input type=\"submit\" />\n\n                </td>\n            </tr>\n        </tbody>\n    </table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
