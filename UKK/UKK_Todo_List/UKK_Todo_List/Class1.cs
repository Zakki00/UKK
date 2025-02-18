using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKK_Todo_List
{
    class Class1
    {

        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataAdapter sqlDataAdapter;
        public DataTable DataTable;


        public readonly string server = "Data Source = DESKTOP-85L07UE\\SQLEXPRESS; Initial Catalog = list ; Integrated Security = True";
        

        public void openconection()
        {
            sqlConnection = new SqlConnection(server);
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                
            }
        }

        public void closeconection()
        {
            if(sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
        }

        public bool exc(string sql)
        {
            openconection();
            try
            {
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                closeconection();
            }
        }

        public DataTable getdata(string sql)
        {
            openconection();
            try
            {
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataAdapter = new SqlDataAdapter();
                DataTable = new DataTable();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(DataTable);

                return DataTable;
            }catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                closeconection();
            }
        }
    }
}
