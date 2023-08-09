namespace BakeryStock.Models
{
    public class ProdutoTabela
    {
        public int Id { get; set; }

        public Produto? Produto_ID { get; set; }

        public Tabela? Tabela_ID { get; set; }

        public int? Quantidade { get; set; }
    }
}
