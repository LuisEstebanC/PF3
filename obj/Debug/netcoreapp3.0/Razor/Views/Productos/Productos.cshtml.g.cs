#pragma checksum "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4c3888adba3cbde40007e0fa8df0ccfa9849fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Productos), @"mvc.1.0.view", @"/Views/Productos/Productos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4c3888adba3cbde40007e0fa8df0ccfa9849fa", @"/Views/Productos/Productos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c801cb8821244cd5d6b509c23a7b601f1bca23", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Productos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Productos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Productos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("collection-item active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"body1 row\">\r\n    <div class=\"grid-productos col s12 m3 l3\">\r\n        <div class=\"collection\">\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4c3888adba3cbde40007e0fa8df0ccfa9849fa4148", async() => {
                WriteLiteral("Todos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("active", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                Database conexionCa = Database.getInstancia();

                Microsoft.Data.Sqlite.SqliteDataReader listado = conexionCa.GetCategorias();

                while (listado.Read())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 484, "\"", 552, 2);
            WriteAttributeValue("", 491, "/Productos/Productos?Categoria_Producto=", 491, 40, true);
#nullable restore
#line 12 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
WriteAttributeValue("", 531, listado.GetString(0), 531, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collection-item\">");
#nullable restore
#line 12 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                                                                                                               Write(listado.GetString(0));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 13 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"grid-productos col s12 m9 l9\">\r\n        <div class=\"Fcontainer\">\r\n\r\n            <div class=\"containerP\">\r\n\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                  
                    Database conexion = Database.getInstancia();

                    try
                    {
                        Console.WriteLine(ViewBag.Categoria);
                        Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetProductoCategorias(ViewBag.Categoria);
                        while (lista.Read())
                        {
                            string imgString = "/images/" + lista.GetString(5);



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card\">\r\n                                <div class=\"head\">\r\n                                    <div class=\"card-image\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1483, "\"", 1499, 1);
#nullable restore
#line 40 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
WriteAttributeValue("", 1489, imgString, 1489, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"price\">\r\n                                    RD$ ");
#nullable restore
#line 44 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                                   Write(lista.GetString(2));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                </div>\r\n                                <div class=\"card-content\">\r\n\r\n                                    <span class=\"card-title\">");
#nullable restore
#line 48 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                                                        Write(lista.GetString(1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    <div class=""cardinfo"">poner un texto que describa el producto.</div>
                                    <div class=""footerCard"">
                                        <a class=""btnComprar  waves-effect waves-yellow"">Comprar ahora</a>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2214, "\"", 2221, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btnCarrito\"><i class=\"small fa fa-shopping-cart teal-text\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 56 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"




                        }


                    }
                    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException e)
                    {
                        Console.WriteLine(e.Message);
                        Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetData();
                        while (lista.Read())
                        {
                            string imgString = "/images/" + lista.GetString(5);




#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card\">\r\n                                <div class=\"head\">\r\n                                    <div class=\"card-image\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3102, "\"", 3118, 1);
#nullable restore
#line 77 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
WriteAttributeValue("", 3108, imgString, 3108, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"price\">\r\n                                    RD$ ");
#nullable restore
#line 81 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                                   Write(lista.GetString(2));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                </div>\r\n                                <div class=\"card-content\">\r\n\r\n                                    <span class=\"card-title\">");
#nullable restore
#line 85 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"
                                                        Write(lista.GetString(1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    <div class=""cardinfo"">poner un texto que describa el producto.</div>
                                    <div class=""footerCard"">
                                        <a class=""btnComprar  waves-effect waves-yellow"">Comprar ahora</a>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 3833, "\"", 3840, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btnCarrito\"><i class=\"small fa fa-shopping-cart teal-text\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 93 "C:\Users\Luis\Desktop\PF3\Views\Productos\Productos.cshtml"



                        }

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n  \r\n\r\n");
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
