#pragma checksum "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Prestamo\EditarPrestamo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283f40d8b9112dbd7aab77d93d8d5a3e8d6b0db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestamo_EditarPrestamo), @"mvc.1.0.view", @"/Views/Prestamo/EditarPrestamo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283f40d8b9112dbd7aab77d93d8d5a3e8d6b0db0", @"/Views/Prestamo/EditarPrestamo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a466f341da27ac1dc3d3660a3cf6337b55cdea51", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestamo_EditarPrestamo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionDeCredito.Models.Prestamo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActualizarPrestamo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/EditarPrestamo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Actualizar prestamo</h1>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283f40d8b9112dbd7aab77d93d8d5a3e8d6b0db04165", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <input type=\"hidden\" class=\"Id\" id=\"Id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 212, "\"", 229, 1);
#nullable restore
#line 7 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Prestamo\EditarPrestamo.cshtml"
WriteAttributeValue("", 220, Model.Id, 220, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                    <label> Monto: </label>\r\n                    <input class=\"form-control\" type=\"number\" id=\"Monto\"");
                BeginWriteAttribute("value", " value=\"", 432, "\"", 452, 1);
#nullable restore
#line 12 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Prestamo\EditarPrestamo.cshtml"
WriteAttributeValue("", 440, Model.Monto, 440, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                    <label> Interes: </label>\r\n                    <input class=\"form-control\" type=\"number\" id=\"Interes\"");
                BeginWriteAttribute("value", " value=\"", 701, "\"", 723, 1);
#nullable restore
#line 18 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Prestamo\EditarPrestamo.cshtml"
WriteAttributeValue("", 709, Model.Interes, 709, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" maxlength=""8"" />
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <label> Plazo: </label>
                    <input class=""form-control"" type=""number"" id=""Plazo""");
                BeginWriteAttribute("value", " value=\"", 1025, "\"", 1045, 1);
#nullable restore
#line 26 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Prestamo\EditarPrestamo.cshtml"
WriteAttributeValue("", 1033, Model.Plazo, 1033, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div><div class=\"col-md-6\">\r\n    <div class=\"form-group\">\r\n        <label> Estado: </label>\r\n        <input class=\"form-control\" type=\"text\" id=\"Estado\"");
                BeginWriteAttribute("value", " value=\"", 1240, "\"", 1261, 1);
#nullable restore
#line 31 "D:\Sistemas\GestionDeCredito\GestionDeCredito\Views\Prestamo\EditarPrestamo.cshtml"
WriteAttributeValue("", 1248, Model.Estado, 1248, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n</div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            \r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n");
                WriteLiteral("            <a class=\"btn btn-success\" id=\"btnEditar\">Actualizar</a>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283f40d8b9112dbd7aab77d93d8d5a3e8d6b0db09017", async() => {
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
                WriteLiteral("\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionDeCredito.Models.Prestamo> Html { get; private set; }
    }
}
#pragma warning restore 1591