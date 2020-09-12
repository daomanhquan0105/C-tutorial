using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sql_connectionName
{

    class DbAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader dbReader;
        private static SqlDataAdapter dbAdapter = new SqlDataAdapter();
        private static string stringConnection = 
            "Data Source=(local);Initial Catalog=Networksocial;Integrated Security=True";
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = stringConnection;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;
                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
