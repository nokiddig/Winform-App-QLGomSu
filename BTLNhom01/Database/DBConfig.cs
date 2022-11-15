using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLNhom01
{
    internal class DBConfig
    {
        static DBConfig instance = new DBConfig();

        private const string STRING_CONNNECT = "Data Source=DESKTOP-RDC3D90\\SQLEXPRESS;Initial Catalog=QLyGomSu;Integrated Security=True";
        private SqlDataAdapter sqlDataAdapter;
        private SqlCommand sqlCommand;

        public DBConfig()
        {
            DBConfig.instance = this;
        }

        public DataTable GetTable(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(STRING_CONNNECT))
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            return dataTable;
        }

        public void Excute(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(STRING_CONNNECT))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public object GetValue(string query)
        {
            object val;
            using (SqlConnection sqlConnection = new SqlConnection(STRING_CONNNECT))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                val = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
            }
            return val;
        }

    }
}
