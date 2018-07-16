using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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