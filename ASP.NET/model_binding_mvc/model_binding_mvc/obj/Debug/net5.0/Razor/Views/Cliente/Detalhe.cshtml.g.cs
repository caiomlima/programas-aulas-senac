#pragma checksum "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8011493a694b1c6549c580ddd7ecee7789a95ab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Detalhe), @"mvc.1.0.view", @"/Views/Cliente/Detalhe.cshtml")]
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
#line 1 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\_ViewImports.cshtml"
using model_binding_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\_ViewImports.cshtml"
using model_binding_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8011493a694b1c6549c580ddd7ecee7789a95ab3", @"/Views/Cliente/Detalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8088ee37ffea20c65da269fff1eb0059a06e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Detalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<model_binding_mvc.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
  
    ViewData["Title"] = "Detalhe do Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhe do Cliente ");
#nullable restore
#line 7 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
                  Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<hr>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
Write(Html.LabelFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
Write(Html.TextBoxFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
Write(Html.TextBoxFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
Write(Html.ActionLink("Retornar", "Index", "Cliente"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Cliente\Detalhe.cshtml"
  
    Html.RenderPartial("_RodapeView");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<model_binding_mvc.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
