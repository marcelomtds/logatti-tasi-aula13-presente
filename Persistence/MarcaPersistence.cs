using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Connection;
using Domain;

namespace Persistence
{
    public class MarcaPersistence
    {
        StringBuilder sb;
        SQLServer connection;
        public void Create(Marca marca)
        {
            sb = new StringBuilder();
            sb.Append("INSERT INTO marca (descricao) ");
            sb.Append($"VALUES ('{marca.Descricao}');");
            using (connection = new SQLServer())
            {
                connection.ExecuteCommand(sb.ToString());
            }
        }
        public List<Marca> FindAll()
        {
            using (connection = new SQLServer())
            {
                var sql = "SELECT " +
                             "id, " +
                             "descricao " +
                          "FROM marca " +
                          "ORDER BY descricao ASC;";
                return PreparateList(connection.ExecuteCommandWithReturn(sql));
            }
        }
        private List<Marca> PreparateList(SqlDataReader reader)
        {
            List<Marca> marcas = new List<Marca>();
            while (reader.Read())
            {
                Marca marca = new Marca()
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Descricao = reader["descricao"].ToString()
                };
                marcas.Add(marca);
            }
            return marcas;
        }
    }
}