#pragma checksum "C:\Users\Danie\OneDrive\Desktop\MadLibs.Solutions\Madlibs\Views\Home\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bd1cb004d4f5ca72154427645f3fefa40b92ad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Form), @"mvc.1.0.view", @"/Views/Home/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Form.cshtml", typeof(AspNetCore.Views_Home_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd1cb004d4f5ca72154427645f3fefa40b92ad2", @"/Views/Home/Form.cshtml")]
    public class Views_Home_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n  ");
            EndContext();
            BeginContext(27, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd1cb004d4f5ca72154427645f3fefa40b92ad22886", async() => {
                BeginContext(33, 184, true);
                WriteLiteral("\r\n    <meta charset=\'utf-8\'>\r\n    <title>Create a Custom Postcard!</title>\r\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\r\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(224, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
            BeginContext(228, 1388, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd1cb004d4f5ca72154427645f3fefa40b92ad24265", async() => {
                BeginContext(234, 1375, true);
                WriteLiteral(@"
    <h1>Fill in your name and your friend's name to create your custom postcard!</h1>
    <form action=""/MadLib"" method=""post"">
      <label for="""">Noun #1</label>
      <input id=""noun1"" name=""noun1"" type=""text"">
      <label for="""">Noun #2</label>
      <input id=""noun2"" name=""noun2"" type=""text"">
      <label for="""">Noun #3</label>
      <input id=""noun3"" name=""noun3"" type=""text"">
      <label for="""">Adverb #1</label>
      <input id=""adverb1"" name=""adverb1"" type=""text"">
      <label for="""">Adverb #2</label>
      <input id=""adverb2"" name=""adverb2"" type=""text"">
      <label for="""">Verb #1</label>
      <input id=""verb1"" name=""verb1"" type=""text"">
      <label for="""">Past tense verb #1</label>
      <input id=""verbpasttense1"" name=""verbpasttense1"" type=""text"">
      <label for="""">Past tense verb #2</label>
      <input id=""verbpasttense2"" name=""verbpasttense2"" type=""text"">
      <label for="""">Adjective #1</label>
      <input id=""adjective1"" name=""adjective1"" type=""text"">
      <label fo");
                WriteLiteral(@"r="""">Adjective #2</label>
      <input id=""adjective2"" name=""adjective2"" type=""text"">
      <label for="""">Adjective #3</label>
      <input id=""adjective3"" name=""adjective3"" type=""text"">
      <label for="""">Adjective #4</label>
      <input id=""adjective4"" name=""adjective4"" type=""text"">
      <button type=""submit"">Go!</button>
    </form>
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1616, 9, true);
            WriteLiteral("\r\n</html>");
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
