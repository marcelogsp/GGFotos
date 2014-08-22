using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGFotos.Dominio.Entidade;

namespace GGFotos.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDBContext _context = new EfDBContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
