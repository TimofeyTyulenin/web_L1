#pragma checksum "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71b45ff4b487e16fd1e8bc7ed6d457a1d83f2d0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingViewBag), @"mvc.1.0.view", @"/Views/CalcService/PassUsingViewBag.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b45ff4b487e16fd1e8bc7ed6d457a1d83f2d0a", @"/Views/CalcService/PassUsingViewBag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_PassUsingViewBag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml"
  
    ViewBag.Title = "PassUsingViewBag - Backend1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>PassUsingViewBag</h1>\n<b>Rand value first:</b> ");
#nullable restore
#line 5 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml"
                    Write(ViewBag.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n<b>Rand value second:</b> ");
#nullable restore
#line 6 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml"
                     Write(ViewBag.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n\n<b>Add:</b><br/>\n");
#nullable restore
#line 9 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml"
Write(ViewBag.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n\n<b>Dif:</b><br/>\n");
#nullable restore
#line 12 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml"
Write(ViewBag.Dif);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n\n<b>Mult:</b><br/>\n");
#nullable restore
#line 15 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml"
Write(ViewBag.Mult);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n\n<b>Div:</b><br/>\n");
#nullable restore
#line 18 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\931901.eremenko_web1-main\Lab1\Views\CalcService\PassUsingViewBag.cshtml"
Write(ViewBag.Div);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n\n");
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
