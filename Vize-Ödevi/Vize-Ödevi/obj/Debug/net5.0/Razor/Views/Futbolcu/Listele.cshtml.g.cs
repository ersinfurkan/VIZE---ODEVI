#pragma checksum "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2806426401f036e1c087548fa65b6cc312437743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Futbolcu_Listele), @"mvc.1.0.view", @"/Views/Futbolcu/Listele.cshtml")]
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
#line 1 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\_ViewImports.cshtml"
using Vize_Ödevi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\_ViewImports.cshtml"
using Vize_Ödevi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2806426401f036e1c087548fa65b6cc312437743", @"/Views/Futbolcu/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8c03fce15e390496bfad487958561609d4fde2", @"/Views/_ViewImports.cshtml")]
    public class Views_Futbolcu_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vize_Ödevi.Models.Futbolcu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Yeni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
  
    ViewData["Title"] = "Listele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listele</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2806426401f036e1c087548fa65b6cc3124377433731", async() => {
                WriteLiteral("Yeni Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Uyruk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Mevki));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uyruk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mevki));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Boy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.ActionLink("Güncelle", "Guncelle", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.ActionLink("Detay", "Detay", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
           Write(Html.ActionLink("Sil", "Sil", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\FURKAN\source\repos\Vize-Ödevi\Vize-Ödevi\Views\Futbolcu\Listele.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vize_Ödevi.Models.Futbolcu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
