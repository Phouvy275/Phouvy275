#pragma checksum "G:\baiTH\ASP.Net_MVC_Core\Views\Student\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "437ce952767bf183f37e7e051de9111e5fc81157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Info), @"mvc.1.0.view", @"/Views/Student/Info.cshtml")]
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
#line 1 "G:\baiTH\ASP.Net_MVC_Core\Views\_ViewImports.cshtml"
using ASP.Net_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\baiTH\ASP.Net_MVC_Core\Views\_ViewImports.cshtml"
using ASP.Net_MVC_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"437ce952767bf183f37e7e051de9111e5fc81157", @"/Views/Student/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4249edee1c5401150d5a65e7fd6d65bf92b5a3f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.Net_MVC_Core.Models.Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"student_info\">\r\n    <div class=\"student_info_title\">Thông tin Sinh Viên </div>\r\n    <div>Mã Sinh Viên:  ");
#nullable restore
#line 5 "G:\baiTH\ASP.Net_MVC_Core\Views\Student\Info.cshtml"
                   Write(Html.DisplayFor(m => m.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Tên Sinh Viên: ");
#nullable restore
#line 6 "G:\baiTH\ASP.Net_MVC_Core\Views\Student\Info.cshtml"
                   Write(Html.DisplayFor(m => m.name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <div>Ngày sinh: ");
#nullable restore
#line 7 "G:\baiTH\ASP.Net_MVC_Core\Views\Student\Info.cshtml"
               Write(Html.DisplayFor(m => m.birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Địa chỉ: ");
#nullable restore
#line 8 "G:\baiTH\ASP.Net_MVC_Core\Views\Student\Info.cshtml"
             Write(Html.DisplayFor(m => m.address_full));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.Net_MVC_Core.Models.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
