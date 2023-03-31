using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DemoAD
{
    public class DataBase : IDisposable
    {
        string _connectionString = "Server=db.edu.cchgeu.ru;DataBase=193_Dykina;User=193_Dykina;Password=Qq123123";
        private SqlConnection _connection;

        public DataBase()
        {
            _connection = new SqlConnection(_connectionString);
            OpenConnection();
        }

        private void OpenConnection()
        {
            _connection.Open();
        }

        private void CloseConnection()
        {
            _connection.Close();
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable dt = new DataTable();
            var reader = new SqlCommand(sql, _connection).ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public void ExecuteSqlNonQuery(string sql)
        {
            new SqlCommand(sql, _connection).ExecuteNonQuery();
        }

        public void Dispose()
        {
            CloseConnection();
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, _connection);
            command.ExecuteNonQuery();
        }
    }
}
   
