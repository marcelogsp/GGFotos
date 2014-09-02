using GGFotos.Web.HTMLHelpers;
using GGFotos.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web;
using System.Web.Mvc;



namespace GGFotos.UnitTest
{
    [TestClass]
    public class UnitTestGGFotos
    {
        [TestMethod]
        public void Teste_GerarPaginacao()
        {
            // ARRANGE (PREPARAÇÃO DO TESTE)
            HtmlHelper html = null;
            Paginacao objPaginacao = new Paginacao { PaginaAtual = 2, ItensPorPagina = 2, ItensTotal = 3 };
            Func<int, string> paginaUrl = i => "Pagina" + i;

            // ACT (CONSOME O QUE FOI DESENVOLVIDO
            MvcHtmlString objResultado = html.PageLinks(objPaginacao, paginaUrl);

            // ASSERT (TESTE)
            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>", objResultado.ToString());

        }
    }
}
