using CadastroProdutosMVC.Models;
using System.Data.Entity;

namespace CadastroProdutosMVC.Dao
{
    public class CadastroProdutosContext: DbContext
    {
        public CadastroProdutosContext():
            base("produtosContext")
        {

        }

        public DbSet<Produto> produto { get; set; }
    }
}