﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.CMX;
    using NewLife.CMX.Web;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = "首页";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"jumbotron\"");

WriteLiteral(">\r\n    <p>\r\n        <h1>学无先后达者为师</h1>\r\n    </p>\r\n</div>\r\n<div");

WriteLiteral(" class=\"benefits container\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Home\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Home\Index.cshtml"
     foreach (var chn in Channel.FindAllWithCache())
    {
        var cats = chn.AllCategories;
        if (cats.Count > 0)
        {
            var width = 12 / cats.Count;
            var left = 12 - width * cats.Count;
            var right = left / 2;
            left -= right;

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"row\"");

WriteAttribute("channel", Tuple.Create(" channel=\"", 469), Tuple.Create("\"", 488)
            
            #line 19 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 479), Tuple.Create<System.Object, System.Int32>(chn.Name
            
            #line default
            #line hidden
, 479), false)
);

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\Home\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Home\Index.cshtml"
                 if (left > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 567), Tuple.Create("\"", 587)
, Tuple.Create(Tuple.Create("", 575), Tuple.Create("col-md-", 575), true)
            
            #line 22 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 582), Tuple.Create<System.Object, System.Int32>(left
            
            #line default
            #line hidden
, 582), false)
);

WriteLiteral("></div>\r\n");

            
            #line 23 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 24 "..\..\Views\Home\Index.cshtml"
                 foreach (var cat in chn.Categories)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 713), Tuple.Create("\"", 734)
, Tuple.Create(Tuple.Create("", 721), Tuple.Create("col-md-", 721), true)
            
            #line 26 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 728), Tuple.Create<System.Object, System.Int32>(width
            
            #line default
            #line hidden
, 728), false)
);

WriteLiteral(">\r\n                        <h2>");

            
            #line 27 "..\..\Views\Home\Index.cshtml"
                       Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                        <div");

WriteLiteral(" class=\"widget_list lz_con fixed tab_list show\"");

WriteLiteral(">\r\n                            <ul>\r\n");

            
            #line 30 "..\..\Views\Home\Index.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Home\Index.cshtml"
                                 foreach (var item in cat.GetTitles(1, 5))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>\r\n                                       " +
" [<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1090), Tuple.Create("\"", 1132)
            
            #line 33 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1097), Tuple.Create<System.Object, System.Int32>(this.GetCategoryUrl(item.Category)
            
            #line default
            #line hidden
, 1097), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                                            <i></i>");

            
            #line 34 "..\..\Views\Home\Index.cshtml"
                                              Write(item.CategoryName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </a>]\r\n                                " +
"        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1312), Tuple.Create("\"", 1337)
            
            #line 36 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1319), Tuple.Create<System.Object, System.Int32>(this.GetUrl(item)
            
            #line default
            #line hidden
, 1319), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                                            <i></i>");

            
            #line 37 "..\..\Views\Home\Index.cshtml"
                                              Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </a>\r\n                                 " +
"   </li>\r\n");

            
            #line 40 "..\..\Views\Home\Index.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n              " +
"      </div>\r\n");

            
            #line 44 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 45 "..\..\Views\Home\Index.cshtml"
                 if (right > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1735), Tuple.Create("\"", 1756)
, Tuple.Create(Tuple.Create("", 1743), Tuple.Create("col-md-", 1743), true)
            
            #line 47 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1750), Tuple.Create<System.Object, System.Int32>(right
            
            #line default
            #line hidden
, 1750), false)
);

WriteLiteral("></div>\r\n");

            
            #line 48 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 50 "..\..\Views\Home\Index.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
