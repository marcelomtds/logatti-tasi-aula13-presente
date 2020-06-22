using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using Connection;
using Domain;

namespace Persistence
{
    public class PresentePersistence
    {
        StringBuilder sb;
        SQLServer connection;
        public void Create(Presente presente)
        {
            sb = new StringBuilder();
            sb.Append("INSERT INTO PRESENTE (descricao, id_tipo, id_marca, id_finalidade, cor, tamanho, preco, id_fornecedor) ");
            sb.Append($"VALUES ('{presente.Descricao}', {presente.Tipo.Id}, {presente.Marca.Id}, {presente.Finalidade.Id}, '{presente.Cor}', '{presente.Tamanho.ToString(CultureInfo.CreateSpecificCulture("en-US"))}', {presente.Preco.ToString(CultureInfo.CreateSpecificCulture("en-US"))}, {presente.Fornecedor.Id});");
            using (connection = new SQLServer())
            {
                connection.ExecuteCommand(sb.ToString());
            }
        }
        public List<Presente> FindAll()
        {
            using (connection = new SQLServer())
            {
                var sql = "SELECT " +
                             "p.id AS id_presente, " +
                             "p.descricao AS descricao_presente, " +
                             "t.id AS id_tipo, " +
                             "t.descricao AS descricao_tipo, " +
                             "m.id AS id_marca, " +
                             "m.descricao AS descricao_marca, " +
                             "f.id AS id_finalidade, " +
                             "f.descricao AS descricao_finalidade, " +
                             "f.origem AS origem_finalidade, " +
                             "p.cor AS cor_presente, " +
                             "p.tamanho AS tamanho_presente, " +
                             "p.preco AS preco_presente, " +
                             "fo.id AS id_fornecedor, " +
                             "fo.nome AS nome_fornecedor, " +
                             "fo.telefone AS telefone_fornecedor, " +
                             "fo.cidade AS cidade_fornecedor, " +
                             "fo.estado AS estado_fornecedor, " +
                             "fo.logradouro AS logradouro_fornecedor, " +
                             "fo.numero AS numero_fornecedor, " +
                             "fo.cnpj AS cnpj_fornecedor, " +
                             "fo.email AS email_fornecedor, " +
                             "fo.conta_corrente AS conta_corrente_fornecedor, " +
                             "fo.agencia AS agencia_fornecedor, " +
                             "fo.banco AS banco_fornecedor " +
                          "FROM presente AS p " +
                          "INNER JOIN tipo AS t ON t.id = p.id_tipo " +
                          "INNER JOIN marca AS m ON m.id = p.id_marca " +
                          "INNER JOIN finalidade AS f ON f.id = p.id_finalidade " +
                          "INNER JOIN fornecedor AS fo ON fo.id = p.id_fornecedor " +
                          "ORDER BY p.descricao ASC;";
                return PreparateList(connection.ExecuteCommandWithReturn(sql));
            }
        }
        private List<Presente> PreparateList(SqlDataReader reader)
        {
            List<Presente> presentes = new List<Presente>();
            while (reader.Read())
            {
                Tipo tipo = new Tipo()
                {
                    Id = int.Parse(reader["id_tipo"].ToString()),
                    Descricao = reader["descricao_tipo"].ToString()
                };
                Marca marca = new Marca()
                {
                    Id = int.Parse(reader["id_marca"].ToString()),
                    Descricao = reader["descricao_marca"].ToString()
                };
                Finalidade finalidade = new Finalidade()
                {
                    Id = int.Parse(reader["id_finalidade"].ToString()),
                    Descricao = reader["descricao_finalidade"].ToString(),
                    Origem = reader["origem_finalidade"].ToString()
                };
                Fornecedor fornecedor = new Fornecedor()
                {
                    Id = int.Parse(reader["id_fornecedor"].ToString()),
                    Nome = reader["nome_fornecedor"].ToString(),
                    Telefone = reader["telefone_fornecedor"].ToString(),
                    Cidade = reader["cidade_fornecedor"].ToString(),
                    Estado = reader["estado_fornecedor"].ToString(),
                    Logradouro = reader["logradouro_fornecedor"].ToString(),
                    Numero = reader["numero_fornecedor"].ToString(),
                    Cnpj = reader["cnpj_fornecedor"].ToString(),
                    Email = reader["email_fornecedor"].ToString(),
                    ContaCorrente = reader["nome_fornecedor"].ToString(),
                    Agencia = reader["agencia_fornecedor"].ToString(),
                    Banco = reader["banco_fornecedor"].ToString()
                };
                Presente presente = new Presente()
                {
                    Id = int.Parse(reader["id_presente"].ToString()),
                    Descricao = reader["descricao_presente"].ToString(),
                    Tipo = tipo,
                    Marca = marca,
                    Finalidade = finalidade,
                    Cor = reader["cor_presente"].ToString(),
                    Tamanho = decimal.Parse(reader["tamanho_presente"].ToString()),
                    Preco = decimal.Parse(reader["preco_presente"].ToString()),
                    Fornecedor = fornecedor
                };
                presentes.Add(presente);
            }
            return presentes;
        }
    }
}