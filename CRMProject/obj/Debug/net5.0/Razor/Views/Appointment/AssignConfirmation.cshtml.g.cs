#pragma checksum "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58e6967abbd219133ddce34e0a216c6209dbcd57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_AssignConfirmation), @"mvc.1.0.view", @"/Views/Appointment/AssignConfirmation.cshtml")]
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
#line 1 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\_ViewImports.cshtml"
using CRMProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\_ViewImports.cshtml"
using CRMProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e6967abbd219133ddce34e0a216c6209dbcd57", @"/Views/Appointment/AssignConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf50f1e0a6bfb237862cff3dab437c7e40ba7ad3", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_AssignConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppointmentUserModel>
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
#line 2 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
  
    ViewData["Title"] = "AssignConfirmation";
    ViewData["SessionUser"] = Model.user.Username;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58e6967abbd219133ddce34e0a216c6209dbcd573930", async() => {
                WriteLiteral(@"
    <!-- Basic Page Info -->
    <meta charset=""utf-8"">
    <title>Assign Confirmation</title>

    <!-- Site favicon -->
    <link rel=""apple-touch-icon"" sizes=""180x180"" href=""vendors/images/apple-touch-icon.png"">
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""vendors/images/favicon-32x32.png"">
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""vendors/images/favicon-16x16.png"">

    <!-- Mobile Specific Metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">

    <!-- Google Font -->
    <link href=""https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700;800&display=swap"" rel=""stylesheet"">
    <!-- CSS -->
    <link rel=""stylesheet"" type=""text/css"" href=""vendors/styles/core.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""vendors/styles/icon-font.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""vendors/styles/style.css"">

    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script as");
                WriteLiteral(@"ync src=""https://www.googletagmanager.com/gtag/js?id=UA-119386393-1""></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'UA-119386393-1');
    </script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58e6967abbd219133ddce34e0a216c6209dbcd576300", async() => {
                WriteLiteral(@"

    <div class=""main-container"">
        <div class=""min-height-200px"" style=""margin-left: -16rem"">
            <div class=""container pd-0"">
                <div class=""page-header"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12"">
                            <div class=""title"">
                                <h4 class=""text-blue h4"" style=""margin-bottom: 2rem;"">Appointment List</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""contact-directory-list"">
                    <ul class=""row"">
");
#nullable restore
#line 55 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                         foreach (var appointment in Model.appointmentList)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li class=""col-xl-4 col-lg-4 col-md-6 col-sm-12"">
                                <div class=""contact-directory-box"">
                                    <div class=""contact-dire-info text-center"">
                                        <div class=""contact-avatar"">
                                            <span style=""padding-top: 1.5rem;"">
                                                <img src=""/deskapp2-master/src/images/appointment.png""");
                BeginWriteAttribute("alt", " alt=\"", 2792, "\"", 2798, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </span>\r\n                                        </div>\r\n                                        <div class=\"contact-name\">\r\n                                            <h4>");
#nullable restore
#line 66 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                           Write(appointment.Customer.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                            <p>");
#nullable restore
#line 67 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                          Write(appointment.Customer.JobTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            <div class=\"work text-success\"><i class=\"ion-android-person\"></i> ");
#nullable restore
#line 68 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                                                                                         Write(appointment.Customer.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div>");
#nullable restore
#line 69 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                            Write(appointment.Customer.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                        </div>\r\n                                        <div class=\"contact-skill\">\r\n                                            <span class=\"badge badge-pill\">");
#nullable restore
#line 72 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                                                      Write(appointment.User.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </div>\r\n                                        <div class=\"profile-sort-desc\">\r\n                                            ");
#nullable restore
#line 75 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                       Write(String.Format("{0:dddd, dd MMM yyyy}", appointment.ScheduledDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"profile-sort-desc\">\r\n                                            ");
#nullable restore
#line 78 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                       Write(String.Format("{0:hh\\:mm}", @appointment.ScheduledTime));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 78 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                                                                                 Write(appointment.PartOfDay);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 80 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                         if (@appointment.Status == 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"profile-sort-desc\">Waiting</div>\r\n");
#nullable restore
#line 83 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                         if (@appointment.Status == 1)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"profile-sort-desc\">Discussed</div>\r\n");
#nullable restore
#line 87 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                         if (@appointment.Status == 2)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"profile-sort-desc\">Cancelled</div>\r\n");
#nullable restore
#line 91 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>
                                    <div class=""view-contact"">
                                        <a href=""#"">View Profile</a>
                                    </div>
                                </div>
                            </li>
");
#nullable restore
#line 99 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Appointment\AssignConfirmation.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>

        <div class=""footer-wrap pd-20 mb-20 card-box"" style=""left: -6.7rem;"">
            DB CRM - &copy; All Rights Reserved.
        </div>

    </div>
    <!-- js -->
    <script src=""vendors/scripts/core.js""></script>
    <script src=""vendors/scripts/script.min.js""></script>
    <script src=""vendors/scripts/process.js""></script>
    <script src=""vendors/scripts/layout-settings.js""></script>
");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppointmentUserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
