#pragma checksum "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc325b13f6cd4387863b42a80268c61b5caa868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PayBill), @"mvc.1.0.view", @"/Views/Patient/PayBill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc325b13f6cd4387863b42a80268c61b5caa868", @"/Views/Patient/PayBill.cshtml")]
    public class Views_Patient_PayBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.ConsultationDetail>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
  Layout = "~/views/Patient/_PatientLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<meta name=\"viewport\" content=\"width=device-width\" />\n<title>PayBill</title>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fc325b13f6cd4387863b42a80268c61b5caa8683001", async() => {
                WriteLiteral("\n\n    <div>\n        <h4>ConsultationDetail</h4>\n        <hr />\n        <dl class=\"row\">\n\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 16 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 19 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayFor(model => model.Doctor_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 22 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayNameFor(model => model.Consultation_Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 25 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayFor(model => model.Consultation_Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 28 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayNameFor(model => model.Consultation_Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 31 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayFor(model => model.Consultation_Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 34 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayNameFor(model => model.Bill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 37 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
           Write(Html.DisplayFor(model => model.Bill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n    <div>\n        Would you like to pay?\n        <br />\n");
#nullable restore
#line 45 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
         using (Html.BeginForm("PayBill", "Patient", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<button formaction=\"PayBill\">Pay Bill</button>");
#nullable restore
#line 47 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n\n\n        |  ");
#nullable restore
#line 53 "C:\CollaberaTraining\FinalPresentationProject\July06\IntegratedClinicManagement-main\Views\Patient\PayBill.cshtml"
      Write(Html.ActionLink("Return to Main Page", "PatientConsole", "Patient"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n");
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
