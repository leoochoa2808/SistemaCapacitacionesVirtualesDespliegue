#pragma checksum "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b8195c450fbd3d85f690e7bbcf72aee42b105b1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8195c450fbd3d85f690e7bbcf72aee42b105b1", @"/Views/Curso/CursoDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af793d79d9bc3b4e120fdb03948f8c89da5218c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_CursoDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Evento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/detalle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inscripcion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PreInscribir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("but"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
            BeginContext(94, 104, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css\">\r\n");
            EndContext();
            BeginContext(198, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8436162d6a4244c38326005ee775994d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(246, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(248, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25104dbcf5824efe8a0766c335c9c79f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(294, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(313, 2668, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea5572a387ef4342aacce7deac09a0a8", async() => {
                BeginContext(319, 294, true);
                WriteLiteral(@"

		<div class=""container"" style=""padding-bottom: 10%; padding-right:10%; padding-left:10%; padding-top:2%;"">						
            <section  class=""col-8 col-12-narrower"">
		<center><div class=""row gtr-50"">
                    <div class=""col-12 col-12-mobilep"">
                        <h2>");
                EndContext();
                BeginContext(614, 50, false);
#line 17 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                       Write(Html.DisplayTextFor(Models => Models.NombreEvento));

#line default
#line hidden
                EndContext();
                BeginContext(664, 526, true);
                WriteLiteral(@"</h2>
				            </div>
                    <div class=""col-12 col-12-mobilep"">
                    <img class=""card-img-top"" src=""https://image.freepik.com/vector-gratis/reunion-junta-scrum-tareas-planificacion-equipo-negocios-conferencia-trabajadores-oficina-diagrama-flujo-trabajo-ilustracion-dibujos-animados_102902-1242.jpg"" alt=""CURSOS_IMG"">
				            </div>
                    <div class=""col-6 col-12-mobilep"">
                        <strong><h5>INVERSION </h5></strong>
                        <p>");
                EndContext();
                BeginContext(1191, 47, false);
#line 24 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.Inversion));

#line default
#line hidden
                EndContext();
                BeginContext(1238, 170, true);
                WriteLiteral("</p>\r\n\t\t\t\t            </div>\r\n                    <div class=\"col-6 col-12-mobilep\">\r\n                        <h5>STOCK DE PARTICIPANTES</h5>\r\n                        <p>");
                EndContext();
                BeginContext(1409, 56, false);
#line 28 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.StockParticipantes));

#line default
#line hidden
                EndContext();
                BeginContext(1465, 164, true);
                WriteLiteral("</p>\r\n\t\t\t\t            </div><br>\r\n                    <div class=\"col-12 col-12-mobilep\">\r\n                        <h5>DESCRIPCION</h5>\r\n                        <p>");
                EndContext();
                BeginContext(1630, 49, false);
#line 32 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(1679, 177, true);
                WriteLiteral("</p>\r\n\t\t\t\t            </div><br><br>\r\n                    <div class=\"col-12 col-12-mobilep\">\r\n                        <h5>HORARIOS DISPONIBLES</h5>\r\n                        <p>");
                EndContext();
                BeginContext(1857, 48, false);
#line 36 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.Frecuencia));

#line default
#line hidden
                EndContext();
                BeginContext(1905, 33, true);
                WriteLiteral("</p>\r\n                        <p>");
                EndContext();
                BeginContext(1939, 48, false);
#line 37 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.HoraInicio));

#line default
#line hidden
                EndContext();
                BeginContext(1987, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1991, 45, false);
#line 37 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                                                          Write(Html.DisplayTextFor(Models => Models.HoraFin));

#line default
#line hidden
                EndContext();
                BeginContext(2036, 33, true);
                WriteLiteral("</p>\r\n                        <p>");
                EndContext();
                BeginContext(2070, 49, false);
#line 38 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                      Write(Html.DisplayTextFor(Models => Models.FechaInicio));

#line default
#line hidden
                EndContext();
                BeginContext(2119, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(2123, 46, false);
#line 38 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                                                           Write(Html.DisplayTextFor(Models => Models.FechaFin));

#line default
#line hidden
                EndContext();
                BeginContext(2169, 125, true);
                WriteLiteral("</p>\r\n\t\t\t\t            </div>    <br><br>\r\n                    <div class=\"bottom-wrap\">\r\n                                    ");
                EndContext();
                BeginContext(2294, 319, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46dee0df3261472ca07ed7709f43efc7", async() => {
                    BeginContext(2594, 15, true);
                    WriteLiteral("Pre inscripción");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idE", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 43 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                           WriteLiteral(idevento);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idE"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idE", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idE"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 44 "D:\sw2 - rama master\Sistema de Capacitaciones Virtuales\Views\Curso\CursoDetalle.cshtml"
                                           WriteLiteral(idu);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idU"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idU", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idU"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2613, 361, true);
                WriteLiteral(@"
    <!-- Modal -->
    
                    </div>
                </div></center>		
                		
			</section>
						
		</div>
        <br><br>          
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>  
");
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
            BeginContext(2981, 2, true);
            WriteLiteral("\r\n");
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
