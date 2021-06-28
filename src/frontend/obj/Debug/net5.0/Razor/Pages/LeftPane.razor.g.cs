#pragma checksum "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffca22d6ea09216ce1f1e762445af87e19594fbb"
// <auto-generated/>
#pragma warning disable 1591
namespace frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Azure\ResumeApp\src\frontend\_Imports.razor"
using frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
using ResumeApp.Core.Model;

#line default
#line hidden
#nullable disable
    public partial class LeftPane : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-4 left-co");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "left-side");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "profile-info");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 6 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                       BasicInfo.image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "alt");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                            ");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, 
#nullable restore
#line 7 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                 BasicInfo.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                            ");
            __builder.OpenElement(13, "span");
            __builder.AddContent(14, 
#nullable restore
#line 8 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                   BasicInfo.label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.AddMarkupContent(16, "<h4 class=\"ltitle\">Contact</h4>\r\n                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "contact-box pb0");
            __builder.AddMarkupContent(19, "<div class=\"icon\"><i class=\"fas fa-phone\"></i></div>\r\n                            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "detail");
            __builder.AddContent(22, 
#nullable restore
#line 16 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                 BasicInfo.phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "contact-box pb0");
            __builder.AddMarkupContent(26, "<div class=\"icon\"><i class=\"fas fa-globe-americas\"></i></div>\r\n                            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "detail");
            __builder.AddContent(29, 
#nullable restore
#line 24 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                 BasicInfo.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "contact-box");
            __builder.AddMarkupContent(33, "<div class=\"icon\"><i class=\"fas fa-map-marker-alt\"></i></div>\r\n                            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "detail");
            __builder.AddContent(36, 
#nullable restore
#line 32 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                 BasicInfo.location.city

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, ",");
            __builder.AddContent(38, 
#nullable restore
#line 32 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                                          BasicInfo.location.countryCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.AddMarkupContent(40, "<h4 class=\"ltitle\">Contact</h4>\r\n                        ");
            __builder.OpenElement(41, "ul");
            __builder.AddAttribute(42, "class", "row social-link no-margin");
#nullable restore
#line 37 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                             foreach (var profile in BasicInfo.profiles)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "li");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "href", 
#nullable restore
#line 39 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                              profile.url

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(46, "i");
            __builder.AddAttribute(47, "class", "text-white" + " " + (
#nullable restore
#line 39 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                                                                 profile.icon

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.AddMarkupContent(49, "<h4 class=\"ltitle\">Hobbies</h4>\r\n                        ");
            __builder.OpenElement(50, "ul");
            __builder.AddAttribute(51, "class", "hoby row no-margin");
#nullable restore
#line 44 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                             if(BasicInfo.interests!=null){
                              foreach (var hobby in BasicInfo.interests)
                              {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "li");
            __builder.AddMarkupContent(53, "<i class=\"fas fa-bullseye\"></i><br>");
            __builder.AddContent(54, 
#nullable restore
#line 47 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                                                                        hobby.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 48 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
                              }
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Projects\Azure\ResumeApp\src\frontend\Pages\LeftPane.razor"
      

[Parameter]
public Basics BasicInfo  {get;set;}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
