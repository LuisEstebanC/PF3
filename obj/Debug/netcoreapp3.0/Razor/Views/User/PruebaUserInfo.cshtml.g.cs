#pragma checksum "C:\Users\Luis\Desktop\PF3\Views\User\PruebaUserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d20ba01dd978119014b171d7f9d7c3fd55da50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_PruebaUserInfo), @"mvc.1.0.view", @"/Views/User/PruebaUserInfo.cshtml")]
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
#line 1 "C:\Users\Luis\Desktop\PF3\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luis\Desktop\PF3\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d20ba01dd978119014b171d7f9d7c3fd55da50", @"/Views/User/PruebaUserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c801cb8821244cd5d6b509c23a7b601f1bca23", @"/Views/_ViewImports.cshtml")]
    public class Views_User_PruebaUserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Luis\Desktop\PF3\Views\User\PruebaUserInfo.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Luis\Desktop\PF3\Views\User\PruebaUserInfo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Luis\Desktop\PF3\Views\User\PruebaUserInfo.cshtml"
 if(Usuario.getInstancia().UsuarioAuthentication == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Use this page to detail your site\'s privacy policy.</p>\r\n");
#nullable restore
#line 9 "C:\Users\Luis\Desktop\PF3\Views\User\PruebaUserInfo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Luis\Desktop\PF3\Views\User\PruebaUserInfo.cshtml"
 if(Usuario.getInstancia().UsuarioAuthentication == true && Usuario.getInstancia().UsuarioIsAdmin == true ){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Soy Admin</p>\r\n");
#nullable restore
#line 13 "C:\Users\Luis\Desktop\PF3\Views\User\PruebaUserInfo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
