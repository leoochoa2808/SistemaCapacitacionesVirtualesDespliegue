#pragma checksum "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819afa9fd494879fe1d426fabdecfda99c4d4120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_CursoDetalle), @"mvc.1.0.view", @"/Views/Curso/CursoDetalle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curso/CursoDetalle.cshtml", typeof(AspNetCore.Views_Curso_CursoDetalle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819afa9fd494879fe1d426fabdecfda99c4d4120", @"/Views/Curso/CursoDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af793d79d9bc3b4e120fdb03948f8c89da5218c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_CursoDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Evento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inscripcion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PreInscripcionCursos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("but"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
  
    var idevento = TempData["ide"] as int?;
    var idu = TempData["idusu"] as int?;

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(113, 2021, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de15c10aef84018b7f3db3a7b2d3faa", async() => {
                BeginContext(119, 293, true);
                WriteLiteral(@"

		<div class=""container"" style=""padding-bottom: 10%; padding-right:10%; padding-left:10%; padding-top:2%;"">						
            <section  class=""col-8 col-12-narrower"">
		<center><div class=""row gtr-50"">
                    <div class=""col-4 col-12-mobilep"">
                        <h2>");
                EndContext();
                BeginContext(413, 50, false);
#line 14 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                       Write(Html.DisplayTextFor(Models => Models.NombreEvento));

#line default
#line hidden
                EndContext();
                BeginContext(463, 150, true);
                WriteLiteral("</h2>\r\n\t\t\t\t    </div>\r\n                    <div class=\"col-4 col-12-mobilep\">\r\n                        <h5>Inversión</h5>\r\n                        <p>");
                EndContext();
                BeginContext(614, 47, false);
#line 18 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.Inversion));

#line default
#line hidden
                EndContext();
                BeginContext(661, 162, true);
                WriteLiteral("</p>\r\n\t\t\t\t    </div>\r\n                    <div class=\"col-4 col-12-mobilep\">\r\n                        <h5>Stock de participantes</h5>\r\n                        <p>");
                EndContext();
                BeginContext(824, 56, false);
#line 22 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.StockParticipantes));

#line default
#line hidden
                EndContext();
                BeginContext(880, 152, true);
                WriteLiteral("</p>\r\n\t\t\t\t    </div>\r\n                    <div class=\"col-12 col-12-mobilep\">\r\n                        <h5>Descripción</h5>\r\n                        <p>");
                EndContext();
                BeginContext(1033, 49, false);
#line 26 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(1082, 161, true);
                WriteLiteral("</p>\r\n\t\t\t\t    </div>\r\n                    <div class=\"col-12 col-12-mobilep\">\r\n                        <h5>Horarios disponibles</h5>\r\n                        <p>");
                EndContext();
                BeginContext(1244, 48, false);
#line 30 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.Frecuencia));

#line default
#line hidden
                EndContext();
                BeginContext(1292, 33, true);
                WriteLiteral("</p>\r\n                        <p>");
                EndContext();
                BeginContext(1326, 48, false);
#line 31 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.HoraInicio));

#line default
#line hidden
                EndContext();
                BeginContext(1374, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1378, 45, false);
#line 31 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                                                          Write(Html.DisplayTextFor(Models => Models.HoraFin));

#line default
#line hidden
                EndContext();
                BeginContext(1423, 33, true);
                WriteLiteral("</p>\r\n                        <p>");
                EndContext();
                BeginContext(1457, 49, false);
#line 32 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.FechaInicio));

#line default
#line hidden
                EndContext();
                BeginContext(1506, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1510, 46, false);
#line 32 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                                                           Write(Html.DisplayTextFor(Models => Models.FechaFin));

#line default
#line hidden
                EndContext();
                BeginContext(1556, 109, true);
                WriteLiteral("</p>\r\n\t\t\t\t    </div>    \r\n                    <div class=\"bottom-wrap\">\r\n                                    ");
                EndContext();
                BeginContext(1665, 332, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e12bb5fbfb8a4c31b928065c8e921c4c", async() => {
                    BeginContext(1978, 15, true);
                    WriteLiteral("Pre inscripción");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idE", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 37 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                           WriteLiteral(idevento);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idE"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idE", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idE"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 38 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                             WriteLiteral(idu);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idusu"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idusu", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idusu"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1997, 130, true);
                WriteLiteral("\r\n                    </div>\r\n                </div></center>\t\t\t\t\r\n\t\t\t</section>\r\n\t\t\t\t\t\t\r\n\t\t</div>\r\n        <br><br>\r\n          \r\n");
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
            BeginContext(2134, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Evento> Html { get; private set; }
    }
}
#pragma warning restore 1591
