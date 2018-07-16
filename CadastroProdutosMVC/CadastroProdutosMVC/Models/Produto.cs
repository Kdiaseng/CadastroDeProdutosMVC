using System.ComponentModel.DataAnnotations;

namespace CadastroProdutosMVC.Models
{
    public class Produto
    {
        [Key]
        public string IDproduto { get; set; }

        [Required]                              //Será obrigatorio o cadastro do nome do produto
        public string NomeProduto { get; set; }

        public string DescricaoProduto { get; set; }

        [Required]
        public double ValorUniProduto { get; set; }

        [Required]
        public int QuantidadeProduto { get; set; }

    }
}