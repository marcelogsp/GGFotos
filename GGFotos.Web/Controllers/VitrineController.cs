using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGFotos.Dominio.Repositorio;

namespace GGFotos.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio _repositorio;
        public int iProdPerPage = 2;

        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var vProdutos = _repositorio.Produtos
                .OrderBy(p => p.Nome)
                .Skip((pagina - 1) * iProdPerPage)
                .Take(iProdPerPage);
            
            return View(vProdutos);
        }
    }
}