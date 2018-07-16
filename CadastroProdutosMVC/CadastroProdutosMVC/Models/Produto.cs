using System.ComponentModel.DataAnnotations;

namespace CadastroProdutosMVC.Models
{
    public class Produto
    {
        [Key]
        public string IDproduto { get; set; }

        [Required]                              //Será obrigatorio o cadastro do nome do produto
        public string NomeProduto { get; set; }

        public string descricaoProduto { get; set; }

        [Required]
        public double valorUniProduto { get; set; }
        
    }
}