#pragma checksum "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44692a7da16bcdbfe2eeffd76d9299e740b6dcb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inscripcion_CursosInscritos), @"mvc.1.0.view", @"/Views/Inscripcion/CursosInscritos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inscripcion/CursosInscritos.cshtml", typeof(AspNetCore.Views_Inscripcion_CursosInscritos))]
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
#line 1 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\_ViewImports.cshtml"
using Sistema_de_Capacitaciones_Virtuales;

#line default
#line hidden
#line 2 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\_ViewImports.cshtml"
using Sistema_de_Capacitaciones_Virtuales.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44692a7da16bcdbfe2eeffd76d9299e740b6dcb5", @"/Views/Inscripcion/CursosInscritos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af793d79d9bc3b4e120fdb03948f8c89da5218c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Inscripcion_CursosInscritos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pago>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelarPreinscripcion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inscripcion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Curso/Cursos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Carritos/Pagar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
  
    var idusu = TempData["idusu"] as int?;

#line default
#line hidden
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 4941, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1cc1060efa643769cc40aec6756a39b", async() => {
                BeginContext(80, 235, true);
                WriteLiteral("\r\n\r\n            \r\n            <div class=\"container col-md-9\" style=\"padding-top: 50px;\" id=\"slider\">\r\n                <center><h1 style=\" font-size: 35px\">Cursos Inscritos</h1></center>\r\n                <div class=\"row ml-4 pl-4\">\r\n\r\n");
                EndContext();
#line 14 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                     foreach (var p in Model)
                    {
                        

#line default
#line hidden
                BeginContext(411, 272, true);
                WriteLiteral(@"                        <div class=""col-3 col-12-mobilep"" style=""font-weight:
                            lighter; text-align:justified;""><br>
                            <div class=""price-wrap"" id=""tag"">Evento</div>
                            <div class=""price-wrap"">");
                EndContext();
                BeginContext(684, 21, false);
#line 20 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                                               Write(p.Evento.NombreEvento);

#line default
#line hidden
                EndContext();
                BeginContext(705, 315, true);
                WriteLiteral(@"</div>
                        </div>
                        <div class=""col-3 col-12-mobilep"" style=""font-weight:
                            lighter; text-align:justified;""><br>
                            <div class=""price-wrap"" id=""tag"">Categoria</div>
                            <div class=""price-wrap"">");
                EndContext();
                BeginContext(1021, 34, false);
#line 25 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                                               Write(p.Evento.Categoria.NombreCategoria);

#line default
#line hidden
                EndContext();
                BeginContext(1055, 319, true);
                WriteLiteral(@"</div>
                        </div>
                        <div class=""col-3 col-12-mobilep"" style=""font-weight:
                            lighter; text-align:justified;""><br>
                            <div class=""price-wrap"" id=""tag"">Inversion</div>
                            <div class=""price-wrap"">S/. ");
                EndContext();
                BeginContext(1375, 18, false);
#line 30 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                                                   Write(p.Evento.Inversion);

#line default
#line hidden
                EndContext();
                BeginContext(1393, 144, true);
                WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"col-3 col-12-mobilep\"><br><br>\r\n                            <center>");
                EndContext();
                BeginContext(1537, 244, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2fba99112664bfb95855253786ff6bf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 36 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                                      WriteLiteral(p.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1781, 43, true);
                WriteLiteral("</center>\r\n                        </div>\r\n");
                EndContext();
#line 62 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                                 
                        }

#line default
#line hidden
                BeginContext(3467, 147, true);
                WriteLiteral("                         <div class=\"row col-md-12\">\r\n                        <div class=\"col-md-3 p-2 mt-4\">\r\n                            <center>");
                EndContext();
                BeginContext(3614, 246, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ebecb3bb2147bd9442b3221c35f3f4", async() => {
                    BeginContext(3716, 140, true);
                    WriteLiteral("<i id=\"carrito\"\r\n                                        class=\"fa fa-arrow-left\"></i> Seguir\r\n                                    comprando");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3860, 136, true);
                WriteLiteral("</center>\r\n                        </div>\r\n                        <div class=\"col-md-3 p-2 mt-4\">\r\n                            <center>");
                EndContext();
                BeginContext(3996, 247, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb642173627a4855b4573b42b48b5dd2", async() => {
                    BeginContext(4100, 139, true);
                    WriteLiteral("<i id=\"carrito\"\r\n                                        class=\"fa fa-check-square-o\"></i>\r\n                                        Comprar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4243, 274, true);
                WriteLiteral(@"</center>
                        </div>
                        <div class=""col-md-3 p-2 mt-4"" style=""font-weight:
                            lighter; text-align:center;"">
                            <div><h5>Total estimado</h5></div>
                        </div>
");
                EndContext();
#line 81 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                          
                        if(TempData["Monto"]!=null)
                        {

#line default
#line hidden
                BeginContext(4625, 159, true);
                WriteLiteral("                        <div class=\"col-md-3 p-2 mt-4\" style=\"font-weight:\r\n                            lighter; text-align:center;\" class=\"price-wrap\"><h5>S/.");
                EndContext();
                BeginContext(4785, 17, false);
#line 85 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                                                                              Write(TempData["Monto"]);

#line default
#line hidden
                EndContext();
                BeginContext(4802, 39, true);
                WriteLiteral("</h5>\r\n                        </div>\r\n");
                EndContext();
#line 87 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Inscripcion\CursosInscritos.cshtml"
                        }
                        

#line default
#line hidden
                BeginContext(4895, 113, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n\r\n            </div>\r\n                    +\r\n            \r\n\r\n");
                EndContext();
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
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pago>> Html { get; private set; }
    }
}
#pragma warning restore 1591
