#pragma checksum "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\Home\MovieResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05dac044e3c57a58db5dc20dcfb6b4336fe3aa68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieResult), @"mvc.1.0.view", @"/Views/Home/MovieResult.cshtml")]
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
#line 1 "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\_ViewImports.cshtml"
using DevBuildMovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\_ViewImports.cshtml"
using DevBuildMovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05dac044e3c57a58db5dc20dcfb6b4336fe3aa68", @"/Views/Home/MovieResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b86b01abc631855f4b84ece629d26af3bde5e8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>This movie has been added:</h2>\r\n<p>Title: ");
#nullable restore
#line 4 "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\Home\MovieResult.cshtml"
     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Genre: ");
#nullable restore
#line 5 "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\Home\MovieResult.cshtml"
     Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Year: ");
#nullable restore
#line 6 "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\Home\MovieResult.cshtml"
    Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Actor: ");
#nullable restore
#line 7 "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\Home\MovieResult.cshtml"
     Write(Model.Actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Director: ");
#nullable restore
#line 8 "C:\Users\CCHRISTIAN1\OneDrive - KNEX\Documents\DevBuild\Weeks\Week 1\Labs Repo\DevBuildMovieRegistration\DevBuildMovieRegistration\Views\Home\MovieResult.cshtml"
        Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591