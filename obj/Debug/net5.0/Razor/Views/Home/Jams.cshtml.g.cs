#pragma checksum "C:\MVC\PokedexV\Views\Home\Jams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0436f28ecc7acbd4f1aa509c763afa58ab165e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Jams), @"mvc.1.0.view", @"/Views/Home/Jams.cshtml")]
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
#line 1 "C:\MVC\PokedexV\Views\_ViewImports.cshtml"
using PokedexV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVC\PokedexV\Views\_ViewImports.cshtml"
using PokedexV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0436f28ecc7acbd4f1aa509c763afa58ab165e0", @"/Views/Home/Jams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"034d294aa3d012dd9dc93495574cdc689cd3e533", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Jams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<img class=\'fire\' id=\'fire\'");
            BeginWriteAttribute("src", " src=\'", 27, "\'", 70, 1);
#nullable restore
#line 1 "C:\MVC\PokedexV\Views\Home\Jams.cshtml"
WriteAttributeValue("", 33, Url.Content("~/Images/fireball.gif"), 33, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n<img draggable=\'false\' class=\'char2\'");
            BeginWriteAttribute("src", " src=\'", 112, "\'", 154, 1);
#nullable restore
#line 3 "C:\MVC\PokedexV\Views\Home\Jams.cshtml"
WriteAttributeValue("", 118, Url.Content("~/Images/charJam.gif"), 118, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<img draggable=\'false\' class=\'char2\'");
            BeginWriteAttribute("src", " src=\'", 194, "\'", 240, 1);
#nullable restore
#line 4 "C:\MVC\PokedexV\Views\Home\Jams.cshtml"
WriteAttributeValue("", 200, Url.Content("~/Images/caterpieJam.gif"), 200, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<img draggable=\'false\' class=\'char2\'");
            BeginWriteAttribute("src", " src=\'", 280, "\'", 321, 1);
#nullable restore
#line 5 "C:\MVC\PokedexV\Views\Home\Jams.cshtml"
WriteAttributeValue("", 286, Url.Content("~/Images/squJam.gif"), 286, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<img draggable=\'false\' class=\'char2\'");
            BeginWriteAttribute("src", " src=\'", 361, "\'", 404, 1);
#nullable restore
#line 6 "C:\MVC\PokedexV\Views\Home\Jams.cshtml"
WriteAttributeValue("", 367, Url.Content("~/Images/bulbaJam.gif"), 367, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"
<style>
    .fire {
        visibility: hidden;
        display: flex;
        position: fixed;
        right: 0; margin-top: 15em;
        transform: scaleX(-1);
        }
</style>
<script>
    function thro() {
        document.getElementById('fire').style.visibility = 'visible';
        setTimeout(() => {begone();}, 4500);
    }
    function begone() {
        document.getElementById('fire').style.visibility = 'hidden';
        document.getElementById('fire').src = '");
#nullable restore
#line 25 "C:\MVC\PokedexV\Views\Home\Jams.cshtml"
                                          Write(Url.Content("~/Images/fireball.gif"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    }\r\n</script>");
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
