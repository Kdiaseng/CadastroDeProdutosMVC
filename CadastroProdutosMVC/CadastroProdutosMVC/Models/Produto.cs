using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroProdutosMVC.Models
{
    public class Produto
    {
        public string IDproduto { get; set; }
        public string NomeProduto { get; set; }
        public string descricaoProduto { get; set; }

        public double valorUniProduto { get; set; }
        
    }
}