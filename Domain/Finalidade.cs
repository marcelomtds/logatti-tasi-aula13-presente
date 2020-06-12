namespace Domain
{
    public class Finalidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Origem { get; set; }
        public override string ToString()
        {
            return Descricao;
        }
    }
}