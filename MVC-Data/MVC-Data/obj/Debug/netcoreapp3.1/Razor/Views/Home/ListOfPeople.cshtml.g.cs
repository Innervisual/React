#pragma checksum "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78393c755f9324fb8f8b6aaebcaf8a5c1cb38533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListOfPeople), @"mvc.1.0.view", @"/Views/Home/ListOfPeople.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78393c755f9324fb8f8b6aaebcaf8a5c1cb38533", @"/Views/Home/ListOfPeople.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2fc2ac1082660396d5339ef01003b5bfbf50342", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ListOfPeople : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Data.Models.Person>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
  

    // ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    table, th, td {
        border: 1px solid black;
    }
</style>

<h1>List of People</h1>

<table style=""width:100%"">
    <tr>
        <th>Name</th>
        <th>City</th>
        <th>Phone number</th>
        <th>Id</th>
    </tr>

");
#nullable restore
#line 22 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
     foreach (var person in ViewBag.LinkableId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 395, "\"", 402, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
                      Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
           Write(person.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
           Write(person.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
           Write(person.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>





<form method=""post"" asp-controller=""Home"" asp-action=""ListOfPeople"">
    <label>Search by name or city </label><br>
    <input type=""text"" name=""searchTerm""><br>
    <br>

    <label>Add person</label><br>
    <input type=""text"" name=""personName"" placeholder=""Name""><br>
    <input type=""text"" name=""personCity"" placeholder=""City""><br>
    <input type=""text"" name=""personPhoneNumber"" placeholder=""Phone Number""><br>
    <input type=""text"" name=""personId"" placeholder=""Id""><br>

    <input type=""submit"" value=""Submit"" />
</form>


");
#nullable restore
#line 54 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
 foreach (var person in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <partial name=\"_partial\" model=\"person\"/> \r\n");
#nullable restore
#line 57 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
Write(Html.Partial("_partial", person));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\jp_mo\OneDrive\Desktop\Lexicon Funktioner\C#\React\Lösning\Solution\MVC-Data\MVC-Data\Views\Home\ListOfPeople.cshtml"
                                     ;

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Data.Models.Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591