#pragma checksum "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35c210d22ad93018a38e3221976fac13699a57e9"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Charts.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Blazor_Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Blazor_Charts.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
#nullable restore
#line 3 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\Shared\SurveyPrompt.razor"
__builder.AddContent(5, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2127996\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "E:\chromeDownload\C#\VS2022\Create-Blazor-Polar-and-Radar-Charts-in-Just-10-Minutes-main\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591