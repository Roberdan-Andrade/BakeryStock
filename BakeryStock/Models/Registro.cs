using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryStock.Models
{
    [Table("Registros")]
    public class Registro
    {
        public int Id { get; set; }

        //Usuario_ID

        //Tabela_ID

        //Item_ID

        public int Quantidade { get; set; }

        // Tipo de modificação (Entrada ou Saida)

        public string? Descrição { get; set; }

        public string? Data { get; set; }
    }
}
