#pragma checksum "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9218cc5a203a5e1395ef93902c69dc4ae600f8f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_GetEquips), @"mvc.1.0.view", @"/Views/Member/GetEquips.cshtml")]
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
#line 1 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\_ViewImports.cshtml"
using GymManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\_ViewImports.cshtml"
using GymManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9218cc5a203a5e1395ef93902c69dc4ae600f8f8", @"/Views/Member/GetEquips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dfa18f0673f7269bc587c430beea01694c9a3e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_GetEquips : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Equipement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
  
    ViewData["Title"] = "Get All Equipements";
    Layout = "./_LayoutMember.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>All Equipements</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
           Write(Html.DisplayNameFor(model => model.eqname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
           Write(Html.DisplayNameFor(model => model.qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
           Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
         foreach (var equip in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
               Write(Html.DisplayFor(modelItem => equip.eqname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
               Write(Html.DisplayFor(modelItem => equip.qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
               Write(Html.DisplayFor(modelItem => equip.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
               Write(Html.DisplayFor(modelItem => equip.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Prutha\source\repos\GymManagement\GymManagement\Views\Member\GetEquips.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Equipement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
