#pragma checksum "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a2f2e6429bc57153f5a32413a9c2bcfd3c426fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pago_CrearPago), @"mvc.1.0.view", @"/Views/Pago/CrearPago.cshtml")]
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
#line 1 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\_ViewImports.cshtml"
using GestionDeCredito;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\_ViewImports.cshtml"
using GestionDeCredito.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a2f2e6429bc57153f5a32413a9c2bcfd3c426fb", @"/Views/Pago/CrearPago.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a466f341da27ac1dc3d3660a3cf6337b55cdea51", @"/Views/_ViewImports.cshtml")]
    public class Views_Pago_CrearPago : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionDeCredito.Models.PrestamoPago>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarPago", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GuardarPago.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Crear Pago</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a2f2e6429bc57153f5a32413a9c2bcfd3c426fb4131", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 8 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
          
            foreach (var prestamo in Model.Prestamos)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" id=\"IdPrestamo\" name=\"Idprestamo\"");
                BeginWriteAttribute("value", " value=\"", 268, "\"", 288, 1);
#nullable restore
#line 11 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
WriteAttributeValue("", 276, prestamo.Id, 276, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  />\r\n");
#nullable restore
#line 12 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n    <div class=\"row\">  \r\n      \r\n");
#nullable restore
#line 17 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
             foreach (var item in Model.Clientes)
              {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" id=\"IdCliente\" name=\"Idcliente\"");
                BeginWriteAttribute("value", " value=\"", 526, "\"", 542, 1);
#nullable restore
#line 20 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
WriteAttributeValue("", 534, item.Id, 534, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""col-md-6"">
                    <div class=""form-group"">
                        <label> Monto: </label>
                        <input class=""form-control Cliente"" type=""text"" readonly=""true"" id=""IdCliente"" name=""IdCliente""");
                BeginWriteAttribute("value", " value=\"", 802, "\"", 837, 2);
#nullable restore
#line 24 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
WriteAttributeValue("", 810, item.Nombre, 810, 12, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
WriteAttributeValue(" ", 822, item.Apellido, 823, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\CrearPago.cshtml"
            }

        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    </div>
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label> Monto Pagado: </label>
                <input class=""form-control monto"" type=""number"" id=""MontoPagado"" name=""MontoPagado""");
                BeginWriteAttribute("value", " value=\"", 1179, "\"", 1187, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n");
                WriteLiteral("        <a class=\"btn btn-success\" id=\"btnGuardar\">Guardar</a>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a2f2e6429bc57153f5a32413a9c2bcfd3c426fb9165", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionDeCredito.Models.PrestamoPago> Html { get; private set; }
    }
}
#pragma warning restore 1591
