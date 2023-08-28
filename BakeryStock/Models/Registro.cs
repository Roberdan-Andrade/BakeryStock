using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryStock.Models
{
    [Table("Registros")]
    public class Registro
    {
        public int Id { get; set; }

        //Usuario_ID

        public Produto? Produto_ID { get; set; }

        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Campo \" {0} \" é obrigatorio")]
        public TipoModificacao Tipo { get; set; }

        [Required(ErrorMessage = "Campo \" {0} \" é obrigatorio")]
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        public DateTime? Data { get; set; }
    }

    public enum TipoModificacao {Saida, Entrada, Outro}
}
