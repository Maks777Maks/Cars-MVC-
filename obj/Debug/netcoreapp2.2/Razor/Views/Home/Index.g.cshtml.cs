#pragma checksum "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\ShopCar\ShopCar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55ecc81eeb34e347a71bfae9c4d177200666a228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\ShopCar\ShopCar\Views\_ViewImports.cshtml"
using ShopCar;

#line default
#line hidden
#line 2 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\ShopCar\ShopCar\Views\_ViewImports.cshtml"
using ShopCar.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ecc81eeb34e347a71bfae9c4d177200666a228", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d2a7eea4739e8049c54a57e5db4a454cde14084", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 56, true);
            WriteLiteral("<h1>Cars Availabel</h1>\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\ShopCar\ShopCar\Views\Home\Index.cshtml"
      

        foreach (Car car in Model.CarAvailabel)
        {
            

#line default
#line hidden
            BeginContext(139, 39, false);
#line 8 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\ShopCar\ShopCar\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("AllCars", car));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\ShopCar\ShopCar\Views\Home\Index.cshtml"
                                                    
        }

    

#line default
#line hidden
            BeginContext(200, 6, true);
            WriteLiteral("</div>");
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
