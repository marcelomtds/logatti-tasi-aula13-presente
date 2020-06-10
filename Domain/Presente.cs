namespace Domain
{
    public class Presente
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Tipo Tipo { get; set; }
        public Marca Marca { get; set; }
        public Finalidade Finalidade { get; set; }
        public string Cor { get; set; }
        public decimal Tamanho { get; set; }
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}