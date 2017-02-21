using System.Collections;
using System.Runtime.InteropServices;
using Npgsql;

namespace SeeSharpBasics.Training4.Db
{
    public abstract class PostgresqlDbClient
    {
        protected NpgsqlConnection Connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=con_air;User Id=postgres;Password=beatka;");

        public abstract bool Update(string query);

        public abstract bool Delete(string query);

        public Hashtable[] Select(string query)
        {
            Connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(query);

            command.Connection = Connection;

            NpgsqlDataReader reader = command.ExecuteReader();

            var columns = reader.GetColumnSchema();

            Hashtable[] table = new Hashtable[7];
            int i = 0;
            while (reader.Read())
            {
                Hashtable hash = new Hashtable();

                foreach (var column in columns)
                {
                    hash.Add(column.BaseColumnName, reader[column.BaseColumnName]);
                }

                table[i] = hash;
                i++;
            }

            Connection.Close();

            return null;
        }

        public int Insert(string query)
        {
            Connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(query);
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();

            return 1;
        }
    }
}