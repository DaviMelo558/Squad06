#pragma checksum "C:\Users\Davi\Desktop\Squad06\SaudeLivre\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29f908d7f5637619bf9060d524e4877a07379b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Davi\Desktop\Squad06\SaudeLivre\Views\_ViewImports.cshtml"
using SaudeLivre;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davi\Desktop\Squad06\SaudeLivre\Views\_ViewImports.cshtml"
using SaudeLivre.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29f908d7f5637619bf9060d524e4877a07379b7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45074e686d8027c857990dd5e2ad9b97132cf551", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Davi\Desktop\Squad06\SaudeLivre\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-sm-12 mt-5 rounded text-white"">
        <div class=""card"">
            <img
                class=""card-img-top""
                src=""./img/Saude.png""
                alt=""Card image cap""
            />
            <div class=""card-body bg-dark"">
                <h5 class=""card-title"">Livre Sa??de</h5>
                <h4>Curso de Etiqueta</h4>
                <p class=""card-text"">
                    Aprenda mais sobre o tratamento verbal de pessoas LGBTQIA+ e
                    fa??a seus pacientes sentirem-se mais confort??veis com seu
                    atendimento.
                </p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29f908d7f5637619bf9060d524e4877a07379b75155", async() => {
                WriteLiteral("Inscreva-se\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
    </div>

    <div
        id=""carouselExampleControls""
        class=""carousel slide""
        data-ride=""carousel""
    >
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img
                    class=""d-block mw-100""
                    src=""https://guiadoestudante.abril.com.br/wp-content/uploads/sites/4/2020/09/LGBT.png""
                    alt=""First slide""
                />
            </div>
            <div class=""carousel-item"">
                <img
                    class=""d-block mw-100""
                    src=""https://www.ipam.pt/hs-fs/hubfs/dia-mulher.jpg?width=1200&name=dia-mulher.jpg""
                    alt=""Second slide""
                />
            </div>
            <div class=""carousel-item"">
                <img
                    class=""d-block mw-100 mx-auto""
                    src=""https://s3.amazonaws.com/kulturehub-blob/uploads/2021/06/Pride-Mon");
            WriteLiteral(@"th-.1.-1024x576.jpg""
                    alt=""Third slide""
                />
            </div>
        </div>
        <a
            class=""carousel-control-prev""
            href=""#carouselExampleControls""
            role=""button""
            data-slide=""prev""
        >
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a
            class=""carousel-control-next""
            href=""#carouselExampleControls""
            role=""button""
            data-slide=""next""
        >
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>

<section class=""container"">
    <img src=""./img/peoples_fig.png""");
            BeginWriteAttribute("alt", " alt=\"", 2784, "\"", 2790, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block mw-100 mx-auto my-5""/>
    <h2>O que significa essa sigla: LGBTQIA+?</h2>
    <p class=""big""></p>
    <h3>O significado da sigla LGBTQIA+</h3>
    <ul>
        <li class=""big"">
            L??sbicas: mulheres que se identificam com o seu g??nero e sentem
            atra????o pelo mesmo sexo;
        </li>
        <li class=""big"">
            Gays: homens que se identificam com o seu g??nero e sentem atra????o
            pelo mesmo sexo;
        </li>
        <li class=""big"">
            Bissexuais: homens e mulheres que sentem atra????o sexual ou afetiva
            por ambos os sexos. Essa orienta????o sexual ?? confundida erroneamente
            com ???indecis??o???;
        </li>
        <li class=""big"">
            Transsexuais, travestis e transg??neros: esses termos se referem aos
            indiv??duos que n??o se identificam com o g??nero biol??gico. Por
            exemplo, quando uma pessoa atribu??da ao g??nero masculino no
            nascimento por raz??es biol??gicas n??o se ident");
            WriteLiteral(@"ifica com ele, mas,
            sim, com o g??nero feminino;
        </li>
        <li class=""big"">
            Queer: pessoas que transitam entre os g??neros feminino e masculino.
            O termo ???queer??? pertence ?? l??ngua inglesa e por muito tempo foi
            utilizado de modo pejorativo. O movimento se apropriou dele para
            conceder um significativo positivo a ele;
        </li>
        <li class=""big"">
            Interssexuais: indiv??duos que possuem caracter??sticas femininas e
            masculinas;
        </li>
        <li class=""big"">
            Assexuais: pessoas que n??o sentem atra????o sexual por outras,
            independentemente do seu g??nero.
        </li>
        <li class=""big"">
            + O s??mbolo de ???mais??? no final da sigla aparece para incluir outras
            identidades de g??nero e orienta????es sexuais que n??o se encaixam no
            padr??o cis-heteronormativo, mas que n??o aparecem em destaque antes
            do s??mbolo.
        </li>
  ");
            WriteLiteral(@"  </ul>
    <p>
        Al??m dessas letras, que s??o as mais comuns, atualmente, h?? algumas
        correntes que indicam para uma sigla completa. ?? composta por:
        LGBTQQICAAPF2K+ (L??sbicas,Gays, Bissexuais, Transg??neros, Queer,
        Questionando, Intersexuais, Curioso, Assexuais, Aliados, Pansexuais,
        Polissexuais, Familiares, 2-esp??ritos e Kink).
    </p>

    <div>
        <img src=""./img/lgbtqia.png""");
            BeginWriteAttribute("alt", " alt=\"", 5272, "\"", 5278, 0);
            EndWriteAttribute();
            WriteLiteral(@"  class=""d-block mw-100 mx-auto""/>
		<br><br>
        Fonte:
		<br>
        <a
            href=""https://capricho.abril.com.br/comportamento/voce-sabe-o-que-significa-a-sigla-lgbtqi/""
            >https://capricho.abril.com.br/comportamento/voce-sabe-o-que-significa-a-sigla-lgbtqi/</a
        >
        <a
            href=""https://www.stoodi.com.br/blog/atualidades/movimento-lgbt-o-que-e/""
            >https://www.stoodi.com.br/blog/atualidades/movimento-lgbt-o-que-e/</a
        >
        <a
            href=""https://www.fundacred.org.br/site/2019/11/25/o-movimento-lgbtqia-os-significados-e-as-lutas-da-diversidade/""
            >https://www.fundacred.org.br/site/2019/11/25/o-movimento-lgbtqia-os-significados-e-as-lutas-da-diversidade/</a
        >
    </div>
</section>

<section class=""container"">
    <img src=""./img/flags2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6139, "\"", 6145, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block mw-100 mx-auto""/>
    <h2>Sa??de mental de pessoas LGBT</h2>
    <p class=""big"">
        Os cuidados com a sa??de mental de pessoas LGBT, ?? outro aspecto de suma
        import??ncia. Sofrer viol??ncia ou ser discriminado por conta da sua
        orienta????o sexual ?? um trauma que muitas carregam. As pessoas LGBT
        passam por epis??dios violentos que podem desencadear depress??o,
        ansiedade, fobia social, agorafobia, estresse p??s-traum??tico, entre
        outros. Da mesma forma, presenciar recorrentes atos violentos ou somente
        ter a consci??ncia de que eles s??o comuns e podem torn??-lo uma v??tima
        abala o estado psicol??gico de pessoas LGBT. Elas podem come??ar a
        levantar questionamentos acerca de suas identidades e prop??sito no
        mundo, os quais eventualmente podem instigar o desenvolvimento de
        transtornos mentais. A repress??o da sexualidade, assim como a repress??o
        emocional, ?? prejudicial para a sa??de da mente e a qualidade da viv??");
            WriteLiteral(@"ncia
        di??ria. Ela denota a repress??o de uma parte intr??nseca da condi????o
        humana e pode causar uma s??rie de consequ??ncias emocionais
        desagrad??veis, como ins??nia, ansiedade, ang??stia e culpa. Neste
        contexto, a import??ncia do movimento LGBTQIA+ destaca-se pela
        possibilidade de oferecer acompanhamento psicol??gico para tratar
        quest??es emocionais associadas ?? orienta????o sexual, sexualidade e
        identidade de g??nero, bem como na oferta de espa??os seguros para pessoas
        LGBT. Essas iniciativas incentivam o autocuidado e combatem transtornos
        mentais debilitantes.

        <br><br>    
        <img src=""./img/flags.png""");
            BeginWriteAttribute("alt", " alt=\"", 7865, "\"", 7871, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block mw-100 mx-auto""/>
        <br><br>
        Fonte:
        <br>
        <a
            href=""https://capricho.abril.com.br/comportamento/voce-sabe-o-que-significa-a-sigla-lgbtqi/""
            >https://capricho.abril.com.br/comportamento/voce-sabe-o-que-significa-a-sigla-lgbtqi/</a
        >
        <a
            href=""https://www.stoodi.com.br/blog/atualidades/movimento-lgbt-o-que-e/""
            >https://www.stoodi.com.br/blog/atualidades/movimento-lgbt-o-que-e/</a
        >
        <a
            href=""https://www.fundacred.org.br/site/2019/11/25/o-movimento-lgbtqia-os-significados-e-as-lutas-da-diversidade/""
            >https://www.fundacred.org.br/site/2019/11/25/o-movimento-lgbtqia-os-significados-e-as-lutas-da-diversidade/</a
        >
    </p>
</section>

<section class=""container"">
    <img src=""./img/""");
            BeginWriteAttribute("alt", " alt=\"", 8731, "\"", 8737, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block mw-100 mx-auto""/>
    <h2>O que ?? ser uma pessoa assexual?</h2>
    <p class=""big"">
        Uma pessoa assexual experimenta pouca ou nenhuma atra????o sexual. Mas
        isso n??o significa que ela n??o pratique sexo, beije e abrace em nenhuma
        circunst??ncia. Ela pode ter atra????o rom??ntica por outro indiv??duo, bem
        como gostar de toques e ter o desejo de estar em um relacionamento
        afetivo. Hoje, a assexualidade ?? compreendida como um amplo espectro que
        re??ne diversos n??veis de aus??ncia de atra????o sexual e rom??ntica. A
        atra????o rom??ntica ?? diferente da atra????o sexual. A primeira diz respeito
        ao desejo de ter um relacionamento amoroso e praticar atos rom??nticos
        enquanto a segunda est?? ligada ?? vontade de ter contato sexual com
        outra(s) pessoa(s). As pessoas assexuais vivenciam diferentes graus de
        ambos os tipos de atra????o, por isso, n??o se pode afirmar que todas s??o
        iguais. Para exemplificar, confira algumas ");
            WriteLiteral(@"orienta????es sexuais que se
        encontram sob o espectro da assexualidade abaixo. Demissexual: pessoa
        sente atra????o sexual somente ap??s desenvolver um v??nculo afetivo com
        outra pessoa; Assexual estrito: pessoa que n??o sente atra????o sexual em
        nenhum momento; Grayssexual: pessoa que sente atra????o sexual somente em
        determinadas circunst??ncias; Frayssexual: pessoa que sente atra????o
        sexual apenas quando n??o h?? um v??nculo afetivo formado; Cupiossexual:
        pessoa que n??o sente atra????o sexual por outros, mas tem desejo sexual e
        vontade de ter uma vida sexual ativa; Assexual flu??do: pessoa que ora se
        sente como um demissexual, ora se sente como um grayssexual. Em outras
        palavras, ?? algu??m cujos desejos sexuais flutuam ocasionalmente. 
        <br /><br />
        Fonte:
        <br />
        <a
            href=""https://istoe.com.br/confira-tudo-o-que-voce-precisa-saber-sobre-assexualidade/""
            >https://istoe.com.br/confi");
            WriteLiteral(@"ra-tudo-o-que-voce-precisa-saber-sobre-assexualidade/</a
        >
        <a
            href=""https://vogue.globo.com/atualidades/noticia/2020/11/o-que-e-assexualidade-os-mitos-e-verdades-sobre-ser-assexuado.html""
            >https://vogue.globo.com/atualidades/noticia/2020/11/o-que-e-assexualidade-os-mitos-e-verdades-sobre-ser-assexuado.html</a
        > <br>
        <a href=""https://www.tuasaude.com/assexualidade/""
            >https://www.tuasaude.com/assexualidade/</a
        >
    </p>
</section>

<h2 style=""text-align: center; text-transform: uppercase;"">Bandeiras</h2>
<section class=""container d-flex flex-wrap flags py-0"">
    <div class=""item"">
        <img src=""./img/bandeiras/bandeira_lgbt.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11517, "\"", 11523, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3> lgbt</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_intersexo.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11663, "\"", 11669, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>intersexo</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_queergender.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11815, "\"", 11821, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>queergender</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_assexual.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11966, "\"", 11972, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>assexual</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_bi.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12108, "\"", 12114, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>bisexual</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_lesbica.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12255, "\"", 12261, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>lesbica</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_nao-binaria.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12405, "\"", 12411, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>n??o-binaria</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_pansexual.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12557, "\"", 12563, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>pansexual</h3>\r\n    </div>\r\n    <div class=\"item\">\r\n        <img src=\"./img/bandeiras/bandeira_trans.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12703, "\"", 12709, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive\">\r\n        <h3>trans</h3>\r\n    </div>\r\n</section>\r\n");
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
