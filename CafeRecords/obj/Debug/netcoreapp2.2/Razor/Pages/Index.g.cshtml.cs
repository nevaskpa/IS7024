#pragma checksum "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44ee446552151425258bedcc21a53157a22559cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CafeRecords.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(CafeRecords.Pages.Pages_Index), null)]
namespace CafeRecords.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\_ViewImports.cshtml"
using CafeRecords;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ee446552151425258bedcc21a53157a22559cb", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a891759bf520865aa1d4b4792fc8fdfd29407a8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    List<OwnerRecord.Owner> cafeOwners = (List<OwnerRecord.Owner>)ViewData["cafeOwners"];
    string ownerName = (string)ViewData["ownerNames"];

#line default
#line hidden
            BeginContext(218, 374, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">List of Cafe Owners</h1>
    <br />

    <table class=""table table-bordered table-striped"">
        <thead class=""table-dark"">
            <tr>
                <th>Account Number</th>
                <th>Legal Name</th>
                <th>Owner Name</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
              
                foreach (OwnerRecord.Owner owner in cafeOwners)
                {

#line default
#line hidden
            BeginContext(692, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(747, 19, false);
#line 26 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                       Write(owner.AccountNumber);

#line default
#line hidden
            EndContext();
            BeginContext(766, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(802, 25, false);
#line 27 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                       Write(owner.DoingBusinessAsName);

#line default
#line hidden
            EndContext();
            BeginContext(827, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 29 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                             if (owner.IsNameNull(owner.OwnerFirstName + owner.OwnerMiddleInitial + owner.OwnerLastName))
                            {

#line default
#line hidden
            BeginContext(1018, 77, true);
            WriteLiteral("                                <span class=\"font-weight-bolder text-danger\">");
            EndContext();
            BeginContext(1096, 9, false);
#line 31 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                                                                        Write(ownerName);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 32 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                            }

                            else
                            {

#line default
#line hidden
            BeginContext(1212, 61, true);
            WriteLiteral("                                <span class=\"text-monospace\">");
            EndContext();
            BeginContext(1274, 20, false);
#line 36 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                                                        Write(owner.OwnerFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1296, 24, false);
#line 36 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                                                                              Write(owner.OwnerMiddleInitial);

#line default
#line hidden
            EndContext();
            BeginContext(1320, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1322, 19, false);
#line 36 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                                                                                                        Write(owner.OwnerLastName);

#line default
#line hidden
            EndContext();
            BeginContext(1341, 10, true);
            WriteLiteral(" </span>\r\n");
            EndContext();
#line 37 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1382, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Parnika\source\repos\nevaskpa\IS7024\CafeRecords\Pages\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1476, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
