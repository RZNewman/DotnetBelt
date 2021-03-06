#pragma checksum "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a344ddf5fa4df0d808dc91077a7727511dbcb243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowEvent), @"mvc.1.0.view", @"/Views/Home/ShowEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowEvent.cshtml", typeof(AspNetCore.Views_Home_ShowEvent))]
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
#line 1 "C:\Users\Rudolf\Documents\C#\ent\Views\_ViewImports.cshtml"
using ent;

#line default
#line hidden
#line 1 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
using ent.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a344ddf5fa4df0d808dc91077a7727511dbcb243", @"/Views/Home/ShowEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094a925313146ee5d3088289dfeca764ffdb6588", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 38, true);
            WriteLiteral("<div id=\"wrapper\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(58, 19, false);
#line 4 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
   Write(ViewBag.Event.Title);

#line default
#line hidden
            EndContext();
            BeginContext(77, 79, true);
            WriteLiteral("\r\n    </h1>\r\n    <a href=\"/\">\r\n        Home\r\n    </a>\r\n    <h3>\r\n        Host: ");
            EndContext();
            BeginContext(157, 31, false);
#line 10 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
         Write(ViewBag.Event.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(188, 62, true);
            WriteLiteral("\r\n    </h3>\r\n    <h3>\r\n        Description\r\n    </h3>\r\n    <p>");
            EndContext();
            BeginContext(251, 25, false);
#line 15 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
  Write(ViewBag.Event.Description);

#line default
#line hidden
            EndContext();
            BeginContext(276, 43, true);
            WriteLiteral("</p>\r\n    <h2>Care to join?</h2>\r\n    <p>\r\n");
            EndContext();
#line 18 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
           
            Event e = ViewBag.Event;
            if(e.UserId==ViewBag.User.UserId){

#line default
#line hidden
            BeginContext(418, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 436, "\"", 468, 3);
            WriteAttributeValue("", 443, "/events/", 443, 8, true);
#line 21 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
WriteAttributeValue("", 451, e.EventId, 451, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 461, "/delete", 461, 7, true);
            EndWriteAttribute();
            BeginContext(469, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 22 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
            }
            else{
                bool conflict = false;
                foreach(Event ev in ViewBag.Attending){
                    if(e.Start>ev.Start){
                        if(!(e.Start>ev.End)){
                            conflict = true;
                            break;
                        }

                    }
                    else {
                        if(!(e.End<ev.Start)){
                            conflict = true;
                            break;
                        }
                    }
                }
                if(ViewBag.Attending.Contains(e)){

#line default
#line hidden
            BeginContext(1117, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1139, "\"", 1170, 3);
            WriteAttributeValue("", 1146, "/events/", 1146, 8, true);
#line 41 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
WriteAttributeValue("", 1154, e.EventId, 1154, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1164, "/leave", 1164, 6, true);
            EndWriteAttribute();
            BeginContext(1171, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 42 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
                }
                else if(conflict){
                    

#line default
#line hidden
            BeginContext(1264, 8, true);
            WriteLiteral("Conflict");
            EndContext();
#line 44 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
                                         
                }
                else{

#line default
#line hidden
            BeginContext(1323, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1345, "\"", 1375, 3);
            WriteAttributeValue("", 1352, "/events/", 1352, 8, true);
#line 47 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
WriteAttributeValue("", 1360, e.EventId, 1360, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1370, "/join", 1370, 5, true);
            EndWriteAttribute();
            BeginContext(1376, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 48 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
                }
            }
            
        

#line default
#line hidden
            BeginContext(1446, 38, true);
            WriteLiteral("    </p>\r\n    <h3>Participants:</h3>\r\n");
            EndContext();
#line 54 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
     foreach(Atendee a in @ViewBag.Event.Guests){

#line default
#line hidden
            BeginContext(1535, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(1547, 16, false);
#line 55 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
      Write(a.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 56 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\ShowEvent.cshtml"
    }

#line default
#line hidden
            BeginContext(1576, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
