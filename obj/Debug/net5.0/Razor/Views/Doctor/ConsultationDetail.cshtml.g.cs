#pragma checksum "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24813ca3c3185d860a04b9ab66228d959235c71d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_ConsultationDetail), @"mvc.1.0.view", @"/Views/Doctor/ConsultationDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24813ca3c3185d860a04b9ab66228d959235c71d", @"/Views/Doctor/ConsultationDetail.cshtml")]
    public class Views_Doctor_ConsultationDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.ConsultationDetail>
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
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
  Layout = "~/views/Doctor/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24813ca3c3185d860a04b9ab66228d959235c71d3135", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>ConsultationDetail</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24813ca3c3185d860a04b9ab66228d959235c71d4199", async() => {
                WriteLiteral("\n    <p>\n        <a asp-action=\"Create\">Create New</a>\n    </p>\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 21 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.Patient_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 24 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.Consultation_Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 27 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.Consultation_Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 30 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.Consultation_Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 33 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.Bill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
                WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 43 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayFor(model => model.Patient_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 46 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayFor(model => model.Consultation_Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 49 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayFor(model => model.Consultation_Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 52 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayFor(model => model.Consultation_Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 55 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
               Write(Html.DisplayFor(model => model.Bill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    <a asp-action=\"Edit\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1788, "\"", 1825, 1);
#nullable restore
#line 58 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
WriteAttributeValue("", 1803, Model.Consultation_Id, 1803, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Start Consultation</a> |\n                    <a asp-action=\"Details\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1895, "\"", 1932, 1);
#nullable restore
#line 59 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Doctor\ConsultationDetail.cshtml"
WriteAttributeValue("", 1910, Model.Consultation_Id, 1910, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Details</a>\n                </td>\n            </tr>\n\n        </tbody>\n    </table>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.ConsultationDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
