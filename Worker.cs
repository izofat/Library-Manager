using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Manager
{
    internal class Worker : Form
    {
        private string connectionString = "Data Source=izofat\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        private string delString = "DELETE FROM BookInfo WHERE ID = @id";
        private string idfound = "SELECT ID FROM BookInfo";        // these are the paths ues yours
        private string countid = "SELECT COUNT(ID) FROM BookInfo";
        private string addString = "INSERT INTO BookInfo (ID,BookName,Author,PublicationYear,Status) VALUES (@id , @bookname , @author,@publyear,@status)";
        private int row;

        public int Row { get => row; set => row = value; }
        public void DeleteBook() //delete book
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand delcmd = new SqlCommand(delString, connection))
                {
                    delcmd.Parameters.AddWithValue("@id",row.ToString()); 
                    delcmd.ExecuteNonQuery();
                }
                connection.Close();
                
            }
        }
        
        public void IDCount() // getting ids to determinate missing id
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand countcmd = new SqlCommand(countid, connection))
                {
                    object countobj = countcmd.ExecuteScalar();
                    int count = Convert.ToInt32(countobj);
                    string[] ids = new string[count];
                    using (SqlCommand idcmd = new SqlCommand(idfound, connection))
                    {
                        SqlDataReader reader = idcmd.ExecuteReader();
                        int index = 0;
                        while (reader.Read())
                        {
                            string id = reader["ID"].ToString();
                            ids[index] = id;
                            index++;
                        }
                        IDFound(ids);
                    }
                }
            }
            
        }
        private int nonexistid; // book's id that's gonna add
        private int m = 0;
        int k = 1;
        private void IDFound(string[] ids)
        {
            
            foreach (string id in ids)
            {
                
                if (k != Convert.ToInt32(id))
                {
                    nonexistid = k;
                    m = 1;
                    break;
                }                
                k++;
            }
        }

        public void AddBook(string bookname , string author, string publyear)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (m == 0)
                {
                    nonexistid = k++; //if there is not a missing id adding new id to the database
                }
                connection.Open();
                using (SqlCommand addcmd = new SqlCommand(addString, connection))
                {
                    addcmd.Parameters.AddWithValue("@id", nonexistid.ToString());
                    addcmd.Parameters.AddWithValue("@bookname", bookname);
                    addcmd.Parameters.AddWithValue("@author", author);
                    addcmd.Parameters.AddWithValue("@publyear", publyear);
                    addcmd.Parameters.AddWithValue("@status", "Available");
                    addcmd.ExecuteNonQuery();
                }
                connection.Close();          
            }
            k = 1;
        }
        
    }
}
