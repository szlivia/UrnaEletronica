using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.DataAccess
{
    public static class Connection
    {
        private static readonly string _connectionString;

        static Connection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"]?.ConnectionString
                ?? throw new InvalidOperationException("Erro ao conectar com o banco de dados.");
        }

        private static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public static object ExecuteQuery(string query, ExecutionType executionType)
        {
            using (var conn = GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                switch (executionType)
                {
                    case ExecutionType.NonQuery:
                        return cmd.ExecuteNonQuery();

                    case ExecutionType.DataTable:
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            var table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }

                    default:
                        throw new ArgumentException("Tipo de execução não suportado.");
                }
            }
        }
    }
}
