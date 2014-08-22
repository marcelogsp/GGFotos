using GGFotos.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;


namespace GGFotos.Web.HTMLHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao _paginacao, Func<int, string> paginaURL)
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 1; i < _paginacao.TotalPaginas; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaURL(i));
                tag.InnerHtml = i.ToString();
                if (i==_paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                tag.AddCssClass("btn-default");
                resultado.Append(tag);
            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}