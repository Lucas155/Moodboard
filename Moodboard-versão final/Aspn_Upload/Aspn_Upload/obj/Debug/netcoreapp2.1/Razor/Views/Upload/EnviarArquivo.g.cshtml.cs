#pragma checksum "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4a9527d1ffcf3c48c6cc41286634fcf8d42278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_EnviarArquivo), @"mvc.1.0.view", @"/Views/Upload/EnviarArquivo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload/EnviarArquivo.cshtml", typeof(AspNetCore.Views_Upload_EnviarArquivo))]
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
#line 1 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\_ViewImports.cshtml"
using Aspn_Upload;

#line default
#line hidden
#line 2 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\_ViewImports.cshtml"
using Aspn_Upload.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4a9527d1ffcf3c48c6cc41286634fcf8d42278", @"/Views/Upload/EnviarArquivo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19b1dad8d498acdaba35a0e745297af9f48e30c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_EnviarArquivo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 86, true);
            WriteLiteral("\r\n\r\n    <hr />\r\n<div class=\"jumbotron jumbotron-fluid\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 9 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml"
         if (ViewData["Error"] != null)
        {

#line default
#line hidden
            BeginContext(179, 34, true);
            WriteLiteral("            <h2 class=\"display-4\">");
            EndContext();
            BeginContext(214, 16, false);
#line 11 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml"
                             Write(ViewData["Erro"]);

#line default
#line hidden
            EndContext();
            BeginContext(230, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 12 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml"
        }

#line default
#line hidden
            BeginContext(248, 41, true);
            WriteLiteral("    </div>\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 15 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml"
         if (ViewData["Resultado"] != null)
        {

#line default
#line hidden
            BeginContext(345, 34, true);
            WriteLiteral("            <h2 class=\"display-4\">");
            EndContext();
            BeginContext(380, 21, false);
#line 17 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml"
                             Write(ViewData["Resultado"]);

#line default
#line hidden
            EndContext();
            BeginContext(401, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 18 "C:\Users\lucas\source\repos\Moodboard-versão funcionando sem upload\Aspn_Upload\Aspn_Upload\Views\Upload\EnviarArquivo.cshtml"
        }

#line default
#line hidden
            BeginContext(419, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
