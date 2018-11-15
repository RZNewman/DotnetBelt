#pragma checksum "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b17b6a3a8eb2203ed2576a30b8fa401638e29d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Events), @"mvc.1.0.view", @"/Views/Home/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Events.cshtml", typeof(AspNetCore.Views_Home_Events))]
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
#line 1 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
using ent.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b17b6a3a8eb2203ed2576a30b8fa401638e29d7", @"/Views/Home/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094a925313146ee5d3088289dfeca764ffdb6588", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 66, true);
            WriteLiteral("<div id=\"wrapper\">\r\n    <h1>Activity Center</h1>\r\n    <h4>Welcome ");
            EndContext();
            BeginContext(86, 22, false);
#line 4 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
           Write(ViewBag.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(108, 684, true);
            WriteLiteral(@"</h4>
    
    <a href=""logout"">Logout</a>
    <div class=""box"">
        <table>
            <tbody>
                <tr>
                    <th>
                        Activity
                    </th>
                    <th>
                        Date / Time
                    </th>
                    <th>
                        Duration
                    </th>
                    <th>
                        Coordinator
                    </th>
                    <th>
                        # People Going
                    </th>
                    <th>
                        Action
                    </th>
                </tr>
");
            EndContext();
#line 30 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                 foreach(Event e in ViewBag.Events){
                    if(e.End>DateTime.Now){

#line default
#line hidden
            BeginContext(891, 98, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 989, "\"", 1013, 2);
            WriteAttributeValue("", 996, "events/", 996, 7, true);
#line 34 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
WriteAttributeValue("", 1003, e.EventId, 1003, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1014, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1016, 7, false);
#line 34 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                                       Write(e.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 107, true);
            WriteLiteral("</a>\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1131, 7, false);
#line 37 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                           Write(e.Start);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 105, true);
            WriteLiteral("\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1244, 11, false);
#line 41 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                           Write(e.Durration);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
#line 42 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                 if(e.Type == Event.TimeType.Days){
                                    

#line default
#line hidden
            BeginContext(1369, 4, true);
            WriteLiteral("Days");
            EndContext();
#line 43 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                                     
                                }
                                else if(e.Type == Event.TimeType.Hours){
                                    

#line default
#line hidden
            BeginContext(1533, 5, true);
            WriteLiteral("Hours");
            EndContext();
#line 46 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                                      
                                }
                                else{
                                

#line default
#line hidden
            BeginContext(1659, 7, true);
            WriteLiteral("Minutes");
            EndContext();
#line 49 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                                    
                                }

#line default
#line hidden
            BeginContext(1710, 173, true);
            WriteLiteral("                                \r\n                            </td>\r\n                            <td>\r\n                                \r\n                                    ");
            EndContext();
            BeginContext(1884, 19, false);
#line 55 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                               Write(e.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1903, 137, true);
            WriteLiteral("\r\n                                \r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2041, 14, false);
#line 59 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                           Write(e.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2055, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 62 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                  
                                    if(e.UserId==ViewBag.User.UserId){

#line default
#line hidden
            BeginContext(2234, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2276, "\"", 2307, 3);
            WriteAttributeValue("", 2283, "events/", 2283, 7, true);
#line 64 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
WriteAttributeValue("", 2290, e.EventId, 2290, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2300, "/delete", 2300, 7, true);
            EndWriteAttribute();
            BeginContext(2308, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 65 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
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
            BeginContext(3388, 46, true);
            WriteLiteral("                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3434, "\"", 3464, 3);
            WriteAttributeValue("", 3441, "events/", 3441, 7, true);
#line 84 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
WriteAttributeValue("", 3448, e.EventId, 3448, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 3458, "/leave", 3458, 6, true);
            EndWriteAttribute();
            BeginContext(3465, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 85 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                        }
                                        else if(conflict){
                                            

#line default
#line hidden
            BeginContext(3630, 8, true);
            WriteLiteral("Conflict");
            EndContext();
#line 87 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                                                 
                                        }
                                        else{

#line default
#line hidden
            BeginContext(3737, 46, true);
            WriteLiteral("                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3783, "\"", 3812, 3);
            WriteAttributeValue("", 3790, "events/", 3790, 7, true);
#line 90 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
WriteAttributeValue("", 3797, e.EventId, 3797, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 3807, "/join", 3807, 5, true);
            EndWriteAttribute();
            BeginContext(3813, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 91 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                                        }
                                    }
                                    
                                

#line default
#line hidden
            BeginContext(3979, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 97 "C:\Users\Rudolf\Documents\C#\ent\Views\Home\Events.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4087, 131, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n      \r\n        \r\n    </div>\r\n    <a href=\"newEvent\">Add New Activity</a>\r\n    \r\n</div>\r\n\r\n");
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