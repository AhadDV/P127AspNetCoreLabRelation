#pragma checksum "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec0b49a871eeb7138abdd10fe1022f8910294c9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
#line 2 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec0b49a871eeb7138abdd10fe1022f8910294c9f", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6a150f9969002523a12e0ef9bc6b20aac967c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    <img src=""img/teacher/teacher-details.jpg"" alt=""teacher"">
                </div>
            </div>
            <div class=""col-md-7 col-sm-7 col-xs-12"">
                <div class=""teacher-details-content ml-50"">
                    <h2>");
#nullable restore
#line 33 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 34 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
                   Write(Model.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 36 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
                  Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <ul>
                        <li><span>degree: </span>PHD in Micro Biology</li>
                        <li><span>experience: </span>7 years experience</li>
                        <li><span>hobbies: </span>music, travelling, catching fish</li>
                        <li><span>faculty: </span>Din, Department of Micro Biology</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>stuart@eduhome.com</p>
                    <p><span>make a call : </span>(+125) 5896 548 9874</p>
                    <p><span>skype : </span> stuart.k</p>
                    <ul>
                        <li><a href=""https://www.facebook.com/devitems/?ref=bookmarks""><i class=""zmdi zmdi-facebook""></i></a></li>
                        <li><a href=""http");
            WriteLiteral(@"s://www.pinterest.com/devitemsllc/""><i class=""zmdi zmdi-pinterest""></i></a></li>
                        <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                        <li><a href=""https://twitter.com/devitemsllc""><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
");
#nullable restore
#line 67 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
                         foreach (Skill skill in Model.Skills)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-4\">\r\n                                <div class=\"skill-bar-item\">\r\n                                    <span>");
#nullable restore
#line 71 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
                                     Write(skill.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <div class=\"progress\">\r\n                                        <div data-wow-delay=\"1.2s\" data-wow-duration=\"1.5s\"");
            BeginWriteAttribute("style", " style=\"", 3247, "\"", 3375, 11);
            WriteAttributeValue("", 3255, "width:", 3255, 6, true);
#nullable restore
#line 73 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 3261, skill.Percent, 3261, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3275, "%;", 3275, 2, true);
            WriteAttributeValue(" ", 3277, "visibility:", 3278, 12, true);
            WriteAttributeValue(" ", 3289, "visible;", 3290, 9, true);
            WriteAttributeValue(" ", 3298, "animation-duration:", 3299, 20, true);
            WriteAttributeValue(" ", 3318, "1.5s;", 3319, 6, true);
            WriteAttributeValue(" ", 3324, "animation-delay:", 3325, 17, true);
            WriteAttributeValue(" ", 3341, "1.2s;", 3342, 6, true);
            WriteAttributeValue(" ", 3347, "animation-name:", 3348, 16, true);
            WriteAttributeValue(" ", 3363, "fadeInLeft;", 3364, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
#nullable restore
#line 74 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
                                                              Write(skill.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 79 "C:\Users\HP\source\repos\WebApplication4\WebApplication4\Views\Teacher\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
