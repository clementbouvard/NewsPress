#pragma checksum "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ada1244fbc096201ca44f7c12ed4c452b24f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_AuthorFilter), @"mvc.1.0.view", @"/Views/Article/AuthorFilter.cshtml")]
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
#line 1 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\_ViewImports.cshtml"
using NewsPress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\_ViewImports.cshtml"
using NewsPress.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
using NewsPress.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ada1244fbc096201ca44f7c12ed4c452b24f3c", @"/Views/Article/AuthorFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bea36c8872c92b847efc29ce4356015901bf30f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_AuthorFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThemeFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuthorFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
  
    ViewData["Title"] = "Author Filter";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""parentleft"">
    <div class=""dropdown"">
        <button class=""btn btn-dark"" style=""margin:5px"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Filter by theme
        </button>
        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ada1244fbc096201ca44f7c12ed4c452b24f3c6454", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n");
#nullable restore
#line 17 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                     foreach (var theme in ViewBag.themeList)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input name=\"AreChecked\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 837, "\"", 854, 1);
#nullable restore
#line 20 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
WriteAttributeValue("", 845, theme.Id, 845, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 20 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                                                                 Write(theme.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 21 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <button value=\"ThemeFilter\" type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""dropdown"">
        <button class=""btn btn-dark"" style=""margin:5px"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Filter by author
        </button>
        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ada1244fbc096201ca44f7c12ed4c452b24f3c10052", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n");
#nullable restore
#line 35 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                     foreach (var author in ViewBag.authorList)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input name=\"AreChecked\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1677, "\"", 1695, 1);
#nullable restore
#line 38 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
WriteAttributeValue("", 1685, author.Id, 1685, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 38 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                                                                  Write(author.FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                                                                                    Write(author.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 39 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <button value=\"AuthorFilter\" type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
 foreach (var article in ViewBag.FilterArticle)
{
    if (SignInManager.IsSignedIn(User) && (article.AuthorId == UserManager.GetUserAsync(User).Result.Id || UserManager.GetUserAsync(User).Result.admin == true))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a style=\"color: inherit; text-decoration: none;\"");
            BeginWriteAttribute("href", " href=\"", 2230, "\"", 2265, 2);
            WriteAttributeValue("", 2237, "/Article/Details/", 2237, 17, true);
#nullable restore
#line 53 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
WriteAttributeValue("", 2254, article.Id, 2254, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"parentspace\">\r\n                <div class=\"parentspace\">\r\n                    <div style=\"margin-right:10px\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49ada1244fbc096201ca44f7c12ed4c452b24f3c14770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2463, "~/Images/", 2463, 9, true);
#nullable restore
#line 57 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
AddHtmlAttributeValue("", 2472, article.PictureName, 2472, 20, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n");
#nullable restore
#line 60 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                         if (article.status == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h2> <i>Draft : ");
#nullable restore
#line 62 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                       Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h2>\r\n");
#nullable restore
#line 63 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                        }
                        else if (article.status == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h2> ");
#nullable restore
#line 66 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                            Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 67 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h2><i>Archived : ");
#nullable restore
#line 70 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                         Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h2>\r\n");
#nullable restore
#line 71 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n");
#nullable restore
#line 73 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                             if (article.Text.Length < 100)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                           Write(article.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                             ;
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                           Write(article.Text.Substring(0, 100));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                                               ;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ...\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    <p>");
#nullable restore
#line 86 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                   Write(article.WrittenDate.ToString("dd MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 86 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                                             Write(article.WrittenDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n        </a>\r\n");
#nullable restore
#line 91 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
    }
    else if (article.status == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a style=\"color: inherit; text-decoration: none;\"");
            BeginWriteAttribute("href", " href=\"", 3839, "\"", 3874, 2);
            WriteAttributeValue("", 3846, "/Article/Details/", 3846, 17, true);
#nullable restore
#line 94 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
WriteAttributeValue("", 3863, article.Id, 3863, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"parentspace\">\r\n                <div class=\"parentspace\">\r\n                    <div style=\"margin-right:10px\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49ada1244fbc096201ca44f7c12ed4c452b24f3c21862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4072, "~/Images/", 4072, 9, true);
#nullable restore
#line 98 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
AddHtmlAttributeValue("", 4081, article.PictureName, 4081, 20, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <h2> ");
#nullable restore
#line 101 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                        Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>\r\n\r\n");
#nullable restore
#line 104 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                             if (article.Text.Length < 100)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                           Write(article.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                             ;
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                           Write(article.Text.Substring(0, 100));

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                                               ;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ...\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    <p>");
#nullable restore
#line 117 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                   Write(article.WrittenDate.ToString("dd MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 117 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
                                                             Write(article.WrittenDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n        </a>\r\n");
#nullable restore
#line 122 "C:\Users\dwans\Documents\GitHub\NewsPress\NewsPress\NewsPress\Views\Article\AuthorFilter.cshtml"
    }


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Author> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Author> SignInManager { get; private set; }
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