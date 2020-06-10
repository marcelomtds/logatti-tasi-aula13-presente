using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Connection;
using Domain;

namespace Persistence
{
    public class FinalidadePersistence
    {
        StringBuilder sb;
        SQLServer connection;
        public void Create(Finalidade finalidade)
        {
            sb = new StringBuilder();
            sb.Append("INSERT INTO finalidade (descricao, origem) ");
            sb.Append($"VALUES ('{finalidade.Descricao}', '{finalidade.Origem}');");
            using (connection = new SQLServer())
            {
                connection.ExecuteCommand(sb.ToString());
            }
        }
        public List<Finalidade> FindAll()
        {
            using (connection = new SQLServer())
            {
                var sql = "SELECT " +
                             "id, " +
                             "descricao, " +
                             "origem " +
                          "FROM finalidade " +
                          "ORDER BY descricao ASC;";
                return PreparateList(connection.ExecuteCommandWithReturn(sql));
            }
        }
        private List<Finalidade> PreparateList(SqlDataReader reader)
        {
            List<Finalidade> finalidades = new List<Finalidade>();
            while (reader.Read())
            {
                Finalidade finalidade = new Finalidade()
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Descricao = reader["descricao"].ToString(),
                    Origem = reader["origem"].ToString()
                };
                finalidades.Add(finalidade);
            }
            return finalidades;
        }
    }
}