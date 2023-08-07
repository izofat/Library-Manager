using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Library_Manager
{
    internal class Show_Book : Form
    {

        string connectionString = "Data Source=izofat\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        string showBookString = "SELECT BookName,Author,PublicationYear,Status FROM BookInfo ORDER BY CAST (ID AS INT) ASC"; // sorting datas with their ids
        public void ViewBooks(DataGridView datagridview) //showbooks
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                using (SqlCommand showcmd = new SqlCommand(showBookString,connection))
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(showcmd);
                    adapter.Fill(dataTable);
                
                }
                connection.Close();
                datagridview.DataSource = dataTable;

            }
        }
        
    }
}
