#pragma checksum "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "437308d5ea4c2636a2a77701b4e2bedd7ab79263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Login), @"mvc.1.0.view", @"/Views/Admin/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"437308d5ea4c2636a2a77701b4e2bedd7ab79263", @"/Views/Admin/Login.cshtml")]
    public class Views_Admin_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.AdminViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
  Layout = "~/views/Doctor/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437308d5ea4c2636a2a77701b4e2bedd7ab792633882", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "437308d5ea4c2636a2a77701b4e2bedd7ab792634142", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <style>\n        form {\n            width: 300px;\n        }\n    </style>\n\n\n\n");
#nullable restore
#line 16 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
      

        ViewData["Title"] = "Admin Login";
    

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437308d5ea4c2636a2a77701b4e2bedd7ab792636359", async() => {
                WriteLiteral("\n    <h1 id=\"main\" class=\"alert alert-danger\">Admin Login</h1>\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n");
#nullable restore
#line 26 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
             using (Html.BeginForm("Login", "Admin", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
           Write(Html.LabelFor(m => m.Username, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
           Write(Html.EditorFor(m => m.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
           Write(Html.LabelFor(m => m.EnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
           Write(Html.PasswordFor(m => m.EnteredPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button class=\"btn btn-success\">Login</button>\n");
#nullable restore
#line 33 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n    <section>\n        ");
#nullable restore
#line 37 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
   Write(Html.ActionLink("Register a new account", "Register"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n    <section class=\"alert alert-danger\">\n        ");
#nullable restore
#line 40 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Admin\Login.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n\n");
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
            WriteLiteral("\n\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
