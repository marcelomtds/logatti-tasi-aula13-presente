using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Connection;
using Domain;

namespace Persistence
{
    public class TipoPersistence
    {
        StringBuilder sb;
        SQLServer connection;
        public void Create(Tipo tipo)
        {
            sb = new StringBuilder();
            sb.Append("INSERT INTO tipo (descricao) ");
            sb.Append($"VALUES ('{tipo.Descricao}');");
            using (connection = new SQLServer())
            {
                connection.ExecuteCommand(sb.ToString());
            }
        }
        public List<Tipo> FindAll()
        {
            using (connection = new SQLServer())
            {
                var sql = "SELECT " +
                             "id, " +
                             "descricao " +
                          "FROM tipo " +
                          "ORDER BY descricao ASC;";
                return PreparateList(connection.ExecuteCommandWithReturn(sql));
            }
        }
        private List<Tipo> PreparateList(SqlDataReader reader)
        {
            List<Tipo> tipos = new List<Tipo>();
            while (reader.Read())
            {
                Tipo tipo = new Tipo()
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Descricao = reader["descricao"].ToString()
                };
                tipos.Add(tipo);
            }
            return tipos;
        }
    }
}