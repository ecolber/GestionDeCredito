#pragma checksum "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c95b7445d71545e45641e439d65a19080526f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pago_Index), @"mvc.1.0.view", @"/Views/Pago/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c95b7445d71545e45641e439d65a19080526f8d", @"/Views/Pago/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a466f341da27ac1dc3d3660a3cf6337b55cdea51", @"/Views/_ViewImports.cshtml")]
    public class Views_Pago_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionDeCredito.Models.PrestamoPago>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""display-2"">Lista de Pagos</h1>
<div>
    <table class=""table table-bordered table-hover table-striped"" id=""TablaPagos"">
        <thead>
            <tr>
                <th>
                    Cliente
                </th>
                <th>
                    Monto Pagado
                </th>
                <th>
                    Fecha Pago
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\Index.cshtml"
              
                foreach (var item in Model.Pagos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n");
#nullable restore
#line 25 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\Index.cshtml"
                              
                                var prestamo = Model.Prestamos.Where(a => a.Id == a.Id).FirstOrDefault();
                                var cliente = Model.Clientes.Where(c => c.Id == prestamo.IdCliente).FirstOrDefault();


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 29 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\Index.cshtml"
                                  Write(cliente.Nombre + " " + cliente.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                        </td>\r\n\r\n\r\n                        <td>");
#nullable restore
#line 35 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\Index.cshtml"
                       Write(item.MontoPagado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\Index.cshtml"
                       Write(item.FechaPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Pago\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n        $(\'#TablaPagos\').DataTable();\r\n    });\r\n    </script>\r\n");
            }
            );
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
