﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.CMX;
    using NewLife.CMX.Web;
    
    #line 1 "..\..\Views\Shared\_Header.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Header.cshtml")]
    public partial class _Views_Shared__Header_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Header_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Header.cshtml"
  
    var header = Nav.Root.FindByPath("头部") ?? Nav.Root;

            
            #line default
            #line hidden
WriteLiteral("\r\n<nav");

WriteLiteral(" class=\"navbar navbar-inverse navbar-fixed-top\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(" style=\"width: 970px;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle collapsed\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#navbar\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" aria-controls=\"navbar\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle navigation</span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n            </button>\r\n            <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(" href=\"./\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\_Header.cshtml"
                                         Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"navbar\"");

WriteLiteral(" class=\"collapse navbar-collapse\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\Shared\_Header.cshtml"
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\_Header.cshtml"
                 foreach (var nav in header.Childs)
                {
                    if (nav.Childs.Count == 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" role=\"presentation\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1011), Tuple.Create("\"", 1026)
            
            #line 22 "..\..\Views\Shared\_Header.cshtml"
, Tuple.Create(Tuple.Create("", 1018), Tuple.Create<System.Object, System.Int32>(nav.Url
            
            #line default
            #line hidden
, 1018), false)
);

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Shared\_Header.cshtml"
                                                                             Write(nav.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 23 "..\..\Views\Shared\_Header.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" role=\"presentation\"");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Shared\_Header.cshtml"
                                                                                                                      Write(nav.Name);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span></a>\r\n                            <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(" role=\"menu\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\Shared\_Header.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Shared\_Header.cshtml"
                                 foreach (var item in nav.Childs)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1579), Tuple.Create("\"", 1595)
            
            #line 31 "..\..\Views\Shared\_Header.cshtml"
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(item.Url
            
            #line default
            #line hidden
, 1586), false)
);

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Shared\_Header.cshtml"
                                                                Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 32 "..\..\Views\Shared\_Header.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </li>\r\n");

            
            #line 35 "..\..\Views\Shared\_Header.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" role=\"presentation\"");

WriteLiteral("><a");

WriteLiteral(" href=\"/Admin\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">管理后台</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</nav>");

        }
    }
}
#pragma warning restore 1591
