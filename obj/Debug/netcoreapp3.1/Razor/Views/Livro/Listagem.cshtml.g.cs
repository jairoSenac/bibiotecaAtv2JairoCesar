#pragma checksum "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0f678c02c081b625fc1845ea305a86612ed7465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Listagem), @"mvc.1.0.view", @"/Views/Livro/Listagem.cshtml")]
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
#line 1 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0f678c02c081b625fc1845ea305a86612ed7465", @"/Views/Livro/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Autor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Titulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Livros";
    int FiltroPorPag = Int32.Parse(ViewData["livrosPorPagina"].ToString());
    int PaginaAtual = Int32.Parse(ViewData["PaginaAtual"].ToString());
    int NumLivroPorPag = (Model.Count < FiltroPorPag ? Model.Count : FiltroPorPag);
    int NumTotalDePag = 0;
    if(NumLivroPorPag > 0)
    { 
        NumTotalDePag = Model.Count / NumLivroPorPag + (Model.Count % NumLivroPorPag==0 ? 0 : 1); 
    }
    
   

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0f678c02c081b625fc1845ea305a86612ed74655916", async() => {
                WriteLiteral("\r\n            <div class=\"form-group mb-2\">\r\n                <select name=\"TipoFiltro\" class=\"form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0f678c02c081b625fc1845ea305a86612ed74656312", async() => {
                    WriteLiteral("Autor");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0f678c02c081b625fc1845ea305a86612ed74657554", async() => {
                    WriteLiteral("Título");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group mb-2 mx-sm-3"">
                <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
            </div>

            <div>
                <select name=""itensPorPagina"" id=""itensPorPagina"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0f678c02c081b625fc1845ea305a86612ed74659112", async() => {
                    WriteLiteral(" 10 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                   
                </select>
            </div>
            
            <button type=""submit"" class=""btn btn-primary mb-2 ml-2"">Pesquisar</button>
            
            <div id=""SeletorPaginas"">
                <span>Pagina:</span>
");
#nullable restore
#line 40 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                 for (int i = 1; i <= NumTotalDePag; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span><a");
                BeginWriteAttribute("href", " href=\"", 1545, "\"", 1582, 2);
                WriteAttributeValue("", 1552, "/Livro/Listagem?PaginaAtual=", 1552, 28, true);
#nullable restore
#line 42 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
WriteAttributeValue("", 1580, i, 1580, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 42 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(",</a></span>\r\n");
#nullable restore
#line 43 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 51 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
         if (Model.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Titulo</th>
                        <th>Autor</th>
                        <th>Ano</th>
                        <th></th>
                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 65 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                     for(int i = (PaginaAtual-1) * NumLivroPorPag; i < (NumLivroPorPag * PaginaAtual < Model.Count ? NumLivroPorPag * PaginaAtual : Model.Count); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 68 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                           Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                           Write(Model[i].Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                           Write(Model[i].Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 71 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                           Write(Model[i].Ano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2607, "\"", 2640, 2);
            WriteAttributeValue("", 2614, "/Livro/Edicao/", 2614, 14, true);
#nullable restore
#line 72 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
WriteAttributeValue("", 2628, Model[i].Id, 2628, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 74 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 77 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <strong class=\"text-center\">Nenhum registro encontrado</strong>\r\n");
#nullable restore
#line 81 "I:\senac EAD\tec informatica para internet\MODULO B\UC07Documentar_manutençãoEmaplicação_web\ATV2\atv2Uc07JairoCesar\Biblioteca\Views\Livro\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
