using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGFotos.Dominio.Repositorio;

namespace GGFotos.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositorio;

        // GET: Produtos
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var vProdutos = _repositorio.Produtos;
            return View(vProdutos);
        }
    }
}