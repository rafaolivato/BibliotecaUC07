#pragma checksum "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f147a7d8d6026e724e82d4f6e4a79e8cd9e99d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
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
#line 1 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f147a7d8d6026e724e82d4f6e4a79e8cd9e99d71", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac979cfa6f9c2014e1ebeda333546c494974b6fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Usuários cadastrados no sistema</h1>\n\n    <p class=\"text-danger\">");
#nullable restore
#line 4 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
                      Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n    <table class = \"table\">\n        <thead>\n            <tr>\n                <th scope= \"row\">Nome</th>\n                <th scope= \"row\">Login</th>\n                <th scope= \"row\">Tipo</th>\n            </tr>\n        </thead>\n\n\n    <tbody>\n");
#nullable restore
#line 17 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 20 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 22 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
                 if(u.Tipo==Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\n");
#nullable restore
#line 25 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\n");
#nullable restore
#line 29 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <td>\n\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 782, 2);
            WriteAttributeValue("", 760, "editarUsuario?id=", 760, 17, true);
#nullable restore
#line 33 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
WriteAttributeValue("", 777, u.Id, 777, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 852, 2);
            WriteAttributeValue("", 829, "ExcluirUsuario?id=", 829, 18, true);
#nullable restore
#line 34 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
WriteAttributeValue("", 847, u.Id, 847, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\n\n\n            </tr>\n");
#nullable restore
#line 38 "/home/rafael/Área de trabalho/Projeto_UC07/BibliotecaUC07/Views/Usuarios/ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    </table>\n\n    <a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
