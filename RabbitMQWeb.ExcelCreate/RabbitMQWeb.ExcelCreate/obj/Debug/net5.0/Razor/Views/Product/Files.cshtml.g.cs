#pragma checksum "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e851a351cdfd72e1d1c18294907d0ffbdc0eaeb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Files), @"mvc.1.0.view", @"/Views/Product/Files.cshtml")]
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
#line 1 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\_ViewImports.cshtml"
using RabbitMQWeb.ExcelCreate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\_ViewImports.cshtml"
using RabbitMQWeb.ExcelCreate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e851a351cdfd72e1d1c18294907d0ffbdc0eaeb4", @"/Views/Product/Files.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7504ab609e4a87826331d156c04c64d991740fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Files : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserFile>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
  
    ViewData["Title"] = "Files";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n\r\n            var hasStartCreatingExcel = \'");
#nullable restore
#line 12 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
                                    Write(TempData["StartCreatingExcel"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            if (hasStartCreatingExcel) {


                Swal.fire({
                    position: 'top-end',
                    icon: 'success',
                    title: 'Excel oluşturma işlemi başlamıştır. Bittiğinde bildiri alacaksınız.',
                    showConfirmButton: false,
                    timer: 2500

                })
            }

        })
    </script>
");
            }
            );
            WriteLiteral("<h1>Files</h1>\r\n<table class=\" table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>File Name</th>\r\n            <th>Created Date</th>\r\n            <th>File Status</th>\r\n            <th>Download</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 40 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
           Write(item.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
           Write(item.GetCreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
           Write(item.FileStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e851a351cdfd72e1d1c18294907d0ffbdc0eaeb46084", async() => {
                WriteLiteral("Download");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1092, "~/files/", 1092, 8, true);
#nullable restore
#line 48 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
AddHtmlAttributeValue("", 1100, item.FilePath, 1100, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1123, "btn", 1123, 3, true);
            AddHtmlAttributeValue(" ", 1126, "btn-primary", 1127, 12, true);
#nullable restore
#line 48 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
AddHtmlAttributeValue(" ", 1138, item.FileStatus==FileStatus.Creating ? "disabled": "", 1139, 56, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\rhakc\source\repos\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\RabbitMQWeb.ExcelCreate\Views\Product\Files.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserFile>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
