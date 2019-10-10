using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace ConsoleApp.SQL
{
    class Program
    {
        static readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=xhuxhu;Integrated Security=True;Pooling=False";

        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET - Hello World!");

            Dictionary<Guid, string> registros = new Dictionary<Guid, string>()
            {
                [Guid.Parse("9DE506C0-A789-4FFD-B8AF-DB2F64888C56")] = "Elvis",
                [Guid.Parse("D29015DB-FA04-41A7-8CB7-68F0C86275C5")] = "Jonny Cash",
                [Guid.Parse("F5ACD77C-776F-4EC3-90FA-D6DFD3E71621")] = "Eric Clapton",
                [Guid.Parse("95339037-8403-421A-AC47-856516DD7229")] = "John Lennon",
                [Guid.Parse("52CBBCF8-9916-44D5-A4C2-5F06DAA4CF1B")] = "Mick Jagger",
                [Guid.Parse("2D426A4D-BDB6-43BF-AF7E-912887F5B073")] = "Shakira"
            };

            foreach (KeyValuePair<Guid, string> item in registros)
            {
                CriarRegistro(item.Key, item.Value);
            }

            MostrarRegistros();

            DeletarRegistros(registros.Keys.ToArray());
        }

        private static void MostrarRegistros()
        {
            using (var conn = SqlClientFactory.Instance.CreateConnection())
            {
                conn.ConnectionString = _connectionString;

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Nome FROM Contato";

                    conn.Open();

                    using (DbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            //uma maneira de pegar os dados
                            string id = reader.GetString(0);
                            string nome = reader.GetString(1);

                            //segunda maneira de pegar os dados
                            id = reader["Id"].ToString();
                            nome = reader["Nome"].ToString();

                            Console.WriteLine($"Id {id} Nome {nome}");
                        }
                    }

                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                }
            }
        }

        private static void MostrarRegistros2()
        {
            using (var conn = SqlClientFactory.Instance.CreateConnection())
            {
                conn.ConnectionString = _connectionString;

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Nome FROM Contato";

                    conn.Open();

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));

                    string id = dt.Rows[0]["Id"].ToString();
                    string nome = dt.Rows[0]["Nome"].ToString();

                    Console.WriteLine($"Id {id} Nome {nome}");

                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                }
            }
        }

        static void DeletarRegistros(params Guid[] idCollection)
        {
            using (var conn = SqlClientFactory.Instance.CreateConnection())
            {
                conn.ConnectionString = _connectionString;

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [Contato] WHERE ID = @PARAM_ID";

                    conn.Open();

                    foreach (var idDelete in idCollection)
                    {
                        cmd.Parameters.Clear();

                        var paramId = cmd.CreateParameter();
                        paramId.ParameterName = "PARAM_ID";
                        paramId.Direction = ParameterDirection.Input;
                        paramId.DbType = DbType.String;
                        paramId.Value = idDelete.ToString();

                        cmd.Parameters.Add(paramId);

                        cmd.ExecuteNonQuery();
                    }
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        static void CriarRegistro(Guid id, string nome)
        {
            using (DbConnection conn = SqlClientFactory.Instance.CreateConnection())
            {
                conn.ConnectionString = _connectionString;

                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = @"INSERT INTO [Contato]
                        (
                            Id,
                            Nome
                        ) 
                        VALUES 
                        (
                            @PARAM_ID, 
                            @PARAM_NOME
                        )";

                    DbParameter paramId = cmd.CreateParameter();
                    paramId.ParameterName = "PARAM_ID";
                    paramId.Direction = ParameterDirection.Input;
                    paramId.DbType = DbType.String;
                    paramId.Value = id.ToString();

                    cmd.Parameters.Add(paramId);


                    DbParameter paramNome = cmd.CreateParameter();
                    paramNome.ParameterName = "PARAM_NOME";
                    paramNome.Direction = ParameterDirection.Input;
                    paramNome.DbType = DbType.String;
                    paramNome.Value = nome;

                    cmd.Parameters.Add(paramNome);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }
    }
}
