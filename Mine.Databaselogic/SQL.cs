using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Mine.Databaselogic
{
    public class SQL : IDisposable
    {
        SqlConnection objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString);

        public int ExecutiveNonQuery(string strQuery)
        {
            int iCount = 0;
            SqlCommand objSqlCommand = new SqlCommand(strQuery, objSqlConnection);
            objSqlConnection.Open();
            iCount = objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();

            return iCount;
        }

        public DataTable GetData(string strQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(strQuery, objSqlConnection);
            objSqlDataAdapter.Fill(dt);
            return dt;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}