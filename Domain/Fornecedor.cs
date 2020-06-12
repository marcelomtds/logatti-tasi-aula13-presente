namespace Domain
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string ContaCorrente { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}