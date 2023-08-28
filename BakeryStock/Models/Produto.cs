using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryStock.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo \" {0} \" é obrigatorio")]
        public string? Nome { get; set; }

        public int? Quantidade { get; set; }

        public int? QuantidadeAviso { get; set; }

        public DateTime? Validade { get; set; }

        public string? Fornecedor { get; set; }

        [Display(Name = "Valor de compra")]
        public float? Preço { get; set; }
    }
}
