#pragma checksum "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e815d51303ed7a1cf6e1d5e0ec4f1f4b0109bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Cursos), @"mvc.1.0.view", @"/Views/Curso/Cursos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curso/Cursos.cshtml", typeof(AspNetCore.Views_Curso_Cursos))]
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
#line 1 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\_ViewImports.cshtml"
using Sistema_de_Capacitaciones_Virtuales;

#line default
#line hidden
#line 2 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\_ViewImports.cshtml"
using Sistema_de_Capacitaciones_Virtuales.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e815d51303ed7a1cf6e1d5e0ec4f1f4b0109bde", @"/Views/Curso/Cursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af793d79d9bc3b4e120fdb03948f8c89da5218c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Cursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Evento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JuegoDetalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Juegos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-idU", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carritos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Carritoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-idJ", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-idU", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("but"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(25, 2294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "431576df45724955a1e8aae628234f06", async() => {
                BeginContext(31, 101, true);
                WriteLiteral("\r\n\r\n            <div class=\"col-md-9\" id=\"slider\">\r\n\r\n                <div class=\"row ml-4 pl-4\">\r\n\r\n");
                EndContext();
#line 10 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml"
                     foreach (var e in Model)
                    {

#line default
#line hidden
                BeginContext(202, 176, true);
                WriteLiteral("                    <div class=\"col-md-3\">\r\n                        <figure class=\"card card-product\">\r\n                            <div class=\"img-wrap\"><div class=\"img-wrap\">");
                EndContext();
                BeginContext(378, 404, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1eefee82f14a5387ce99f74d54dacd", async() => {
                    BeginContext(630, 80, true);
                    WriteLiteral("<img id=\"product\"\r\n                                            class=\"img-fluid\"");
                    EndContext();
                    BeginWriteAttribute("src", "\r\n                                            src=\"", 710, "\"", 776, 1);
#line 20 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml"
WriteAttributeValue("", 761, e.NombreEvento, 761, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(777, 1, true);
                    WriteLiteral(">");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idU"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(782, 126, true);
                WriteLiteral("</div>\r\n                                <figcaption class=\"info-wrap\">\r\n                                    <h4 class=\"title\">");
                EndContext();
                BeginContext(909, 27, false);
#line 22 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml"
                                                 Write(e.Categoria.NombreCategoria);

#line default
#line hidden
                EndContext();
                BeginContext(936, 167, true);
                WriteLiteral("</h4>\r\n                                    <p class=\"desc\"\r\n                                        style=\"text-overflow:ellipsis;white-space:nowrap;overflow:hidden;\">");
                EndContext();
                BeginContext(1104, 25, false);
#line 24 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml"
                                                                                                      Write(e.Instructor.PrimerNombre);

#line default
#line hidden
                EndContext();
                BeginContext(1129, 135, true);
                WriteLiteral("</p>\r\n                                    <div class=\"rating-wrap\">\r\n                                        <div class=\"label-rating\">");
                EndContext();
                BeginContext(1265, 13, false);
#line 26 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml"
                                                             Write(e.Descripcion);

#line default
#line hidden
                EndContext();
                BeginContext(1278, 320, true);
                WriteLiteral(@"</div>
                                        <div class=""label-rating"">154 orders
                                        </div>
                                    </div>
                                </figcaption>
                                <div class=""bottom-wrap"">
                                    ");
                EndContext();
                BeginContext(1598, 304, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc6b23385dc4412917e8460df823498", async() => {
                    BeginContext(1883, 15, true);
                    WriteLiteral("Pre inscripción");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idJ", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idJ"] = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idU"] = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1902, 133, true);
                WriteLiteral("\r\n                                    <div class=\"price-wrap h5\">\r\n                                        <span class=\"price-new\">S/");
                EndContext();
                BeginContext(2036, 11, false);
#line 38 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml"
                                                             Write(e.Inversion);

#line default
#line hidden
                EndContext();
                BeginContext(2047, 164, true);
                WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </figure>\r\n                        </div>\r\n");
                EndContext();
#line 43 "C:\Users\josyu\OneDrive\Escritorio\rama_josseyn\Sistema de Capacitaciones Virtuales\Views\Curso\Cursos.cshtml"
                        }

#line default
#line hidden
                BeginContext(2238, 74, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
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
            BeginContext(2319, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591