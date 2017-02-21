using Npgsql;
using SeeSharpBasics.Training4.Db;

namespace SeeSharpBasics.SlawekKowal.Training4
{
    public class SlawekKPostgresglDbClient: PostgresqlDbClient
    {
        public SlawekKPostgresglDbClient()
        {
            Connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=SlawekSql;User Id=postgres;Password=admin;");
        }



        public override bool Update(string query)
        {
            Connection.Open();
            NpgsqlCommand commanand = new NpgsqlCommand(query);
            commanand.Connection = Connection;
            commanand.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public override bool Delete(string query)
        {
            Connection.Open();
            NpgsqlCommand commanand = new NpgsqlCommand(query);
            commanand.Connection = Connection;
            commanand.ExecuteNonQuery();
            Connection.Close();
            return true;
        }
    }
}