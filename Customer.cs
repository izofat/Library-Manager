using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Library_Manager
{
    internal class Customer 
    {
        string connectionString = "Data Source=izofat\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";        //write the sql server path in here
        string updateString = "UPDATE BookInfo SET Status = @status WHERE ID = @id";        // write the table name you working on 
        private int row;
        public int Row { get => row; set => row = value; }
        // barrow the book
        public void BarrowBook()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))            // this changes the status "Taken"
            {
                connection.Open();
                using (SqlCommand updatecmd = new SqlCommand(updateString, connection))
                {
                    updatecmd.Parameters.AddWithValue("@status", "Taken");
                    updatecmd.Parameters.AddWithValue("@id", row.ToString());
                    updatecmd.ExecuteNonQuery();
                }
                connection.Close();

            }
        }
        // return the book
        public void ReturnBook ()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();                
                using (SqlCommand updatecmd = new SqlCommand(updateString, connection))    // this changes the status "Available"
                {
                    updatecmd.Parameters.AddWithValue("@status", "Available");
                    updatecmd.Parameters.AddWithValue("@id", row.ToString());
                    updatecmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
