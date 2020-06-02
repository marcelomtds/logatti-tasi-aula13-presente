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
            sb.Append("INSERT INTO PRESENTE (descricao, tipo, marca, finalidade, cor, tamanho, preco, nome_fornecedor) ");
            sb.Append($"VALUES ('{presente.Descricao}', '{presente.Tipo}', '{presente.Marca}', '{presente.Finalidade}', '{presente.Cor}', '{presente.Tamanho}', {presente.Preco.ToString(CultureInfo.CreateSpecificCulture("en-US"))}, '{presente.NomeFornecedor}');");
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
                             "id, " +
                             "descricao, " +
                             "tipo, " +
                             "marca, " +
                             "finalidade, " +
                             "cor, " +
                             "tamanho, " +
                             "preco, " +
                             "nome_fornecedor " +
                          "FROM presente " +
                          "ORDER BY id ASC;";
                return PreparateList(connection.ExecuteCommandWithReturn(sql));
            }
        }
        private List<Presente> PreparateList(SqlDataReader reader)
        {
            List<Presente> presentes = new List<Presente>();
            while (reader.Read())
            {
                Presente presente = new Presente()
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Descricao = reader["descricao"].ToString(),
                    Tipo = reader["tipo"].ToString(),
                    Marca = reader["marca"].ToString(),
                    Finalidade = reader["finalidade"].ToString(),
                    Cor = reader["cor"].ToString(),
                    Tamanho = reader["tamanho"].ToString(),
                    Preco = decimal.Parse(reader["preco"].ToString()),
                    NomeFornecedor = reader["nome_fornecedor"].ToString()
                };
                presentes.Add(presente);
            }
            return presentes;
        }
    }
}