using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Connection;
using Domain;

namespace Persistence
{
    public class FornecedorPersistence
    {
        StringBuilder sb;
        SQLServer connection;
        public void Create(Fornecedor fornecedor)
        {
            sb = new StringBuilder();
            sb.Append("INSERT INTO fornecedor (nome, telefone, cidade, estado, logradouro, numero, cnpj, email, conta_corrente, agencia, banco) ");
            sb.Append($"VALUES ('{fornecedor.Nome}', '{fornecedor.Telefone}', '{fornecedor.Cidade}', '{fornecedor.Estado}', '{fornecedor.Logradouro}', '{fornecedor.Numero}', '{fornecedor.Cnpj}', '{fornecedor.Email}', '{fornecedor.ContaCorrente}', '{fornecedor.Agencia}', '{fornecedor.Banco}');");
            using (connection = new SQLServer())
            {
                connection.ExecuteCommand(sb.ToString());
            }
        }
        public List<Fornecedor> FindAll()
        {
            using (connection = new SQLServer())
            {
                var sql = "SELECT " +
                             "id, " +
                             "nome, " +
                             "telefone, " +
                             "cidade, " +
                             "estado, " +
                             "logradouro, " +
                             "numero, " +
                             "cnpj, " +
                             "email, " +
                             "conta_corrente, " +
                             "agencia, " +
                             "banco " +
                          "FROM fornecedor " +
                          "ORDER BY nome ASC;";
                return PreparateList(connection.ExecuteCommandWithReturn(sql));
            }
        }
        private List<Fornecedor> PreparateList(SqlDataReader reader)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            while (reader.Read())
            {
                Fornecedor fornecedor = new Fornecedor()
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Nome = reader["nome"].ToString(),
                    Telefone = reader["telefone"].ToString(),
                    Cidade = reader["cidade"].ToString(),
                    Estado = reader["estado"].ToString(),
                    Logradouro = reader["logradouro"].ToString(),
                    Numero = reader["numero"].ToString(),
                    Cnpj = reader["cnpj"].ToString(),
                    Email = reader["email"].ToString(),
                    ContaCorrente = reader["nome"].ToString(),
                    Agencia = reader["agencia"].ToString(),
                    Banco = reader["banco"].ToString()
                };
                fornecedores.Add(fornecedor);
            }
            return fornecedores;
        }
    }
}