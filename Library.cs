using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class Library : Form
    {

        Customer op = new Customer();
        Show_Book show = new Show_Book();
        Worker wop = new Worker();
        public Library()
        {
            InitializeComponent();
            slctrow = 0;
        }
        
        private void Library_Load(object sender, EventArgs e)
        {
            // show books
            show.ViewBooks(dataGridView1);
            buttonshowpw.Image = Image.FromFile("C:\\Users\\gorke\\OneDrive\\Documents\\C#\\Library Manager\\show.png"); // added image in repretoire write that file path in here 
            textBoxpassw.UseSystemPasswordChar = true;
        }
        int slctrow;
        int selectcount = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectcount++; // to not couse any problem used a variable 
            slctrow = dataGridView1.SelectedCells[0].RowIndex + 1;    // getting row index to add ,delete , update
            op.Row = slctrow;
            wop.Row = slctrow;    // sending row index
            
        }

        private void buttonbarrow_Click(object sender, EventArgs e)
        {
            if(selectcount >= 1)
            {
                op.BarrowBook();        // barrow
                show.ViewBooks(dataGridView1);    
                selectcount = 0;
            }
            else
            {
                MessageBox.Show("Select the book you wanna BARROW !");
            }
            
        }

        private void buttonreturn_Click(object sender, EventArgs e)
        {
            if (selectcount >= 1)
            {
                op.ReturnBook();    //return
                show.ViewBooks(dataGridView1);
                selectcount = 0;
            }
            else
            {
                MessageBox.Show("Select the book you wanna RETURN !");
            }
            
        }

        private void buttoncustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBoxactions.Visible = true;
            buttoncustomer.Visible = false;
            buttonworker.Visible = true;
            groupBoxlogin.Visible = false;
            groupBoxworkactions.Visible = false;
            k = 0;
            textBoxpassw.Clear();
            textBoxusern.Clear();
            textBoxpubly.Clear();
        }
        private void buttonworker_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBoxlogin.Visible = true;
            groupBoxactions.Visible = false;
            buttonworker.Visible = false;
            buttoncustomer.Visible = true;
            labelun.Text = "Username :";
            labelpw.Text = "Password :";
            labelpubly.Visible = false;
            textBoxpubly.Visible = false;
            textBoxpassw.UseSystemPasswordChar = true;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textBoxusern.Text == "admin" && textBoxpassw.Text == "adminpanelopen")    //this the username and password I defined you can change it
            {
                groupBoxworkactions.Visible = true;
                groupBoxlogin.Visible = false;
                dataGridView1.Visible = true; 
                textBoxpassw.Clear();
                textBoxpassw.UseSystemPasswordChar = false;
                textBoxusern.Clear();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        int i = 0;
        private void buttonshowpw_Click(object sender, EventArgs e)   // this changes the textboxes text appearance with that little any button
        {
            i++;
            if (i % 2 == 1)
            {
                textBoxpassw.UseSystemPasswordChar = false;
                buttonshowpw.Image = Image.FromFile("C:\\Users\\gorke\\OneDrive\\Documents\\C#\\Library Manager\\unshow.png"); // to not couse any confison

            }
            else if (i % 2 == 0)
            {
                textBoxpassw.UseSystemPasswordChar = true;
                buttonshowpw.Image = Image.FromFile("C:\\Users\\gorke\\OneDrive\\Documents\\C#\\Library Manager\\show.png");
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (selectcount >= 1)
            {
                wop.DeleteBook();        // delete
                show.ViewBooks(dataGridView1);
                selectcount = 0;               
            }
            else
            {
                MessageBox.Show("Select a book to DELETE !");
            }
                   
        }
        int k = 0;
        private void buttonadd_Click(object sender, EventArgs e)
        {
            wop.IDCount();  // this is checking ids is there any nonexist id 
            k++;
            if (k == 1)
            {
                groupBoxlogin.Visible = true;
                
                labelun.Text = "Book Name :";
                labelpw.Text = "Author :";
                buttonshowpw.Visible = false;
                labelpubly.Visible = true;
                textBoxpubly.Visible = true;
                buttonlogin.Visible = false;              
            }
            else if (k >= 2)
            {
                string bookn = textBoxusern.Text;
                string author = textBoxpassw.Text;
                string publy = textBoxpubly.Text.ToString();
                wop.AddBook(bookn, author, publy); //adding
                show.ViewBooks(dataGridView1);
                textBoxpassw.Clear();
                textBoxpubly.Clear();
                textBoxusern.Clear();
            }
        }

        
    }
}
