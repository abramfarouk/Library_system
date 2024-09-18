using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Model;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
        public ReturnBooks()
        {
            InitializeComponent();

        }

        private void GetAllBorrowed()
        {
            var Books = context.BorrowedBooks.Where(d=>d.IsReturn ==false).ToList();

            foreach (var item in Books)
            {

                dataGridView11.Rows.Add(new string[] {item.ID.ToString(),  item.Person.Name, item.Book.BookTitle, item.Book.Author, item.Person.Address, item.Person.phone, item.EndBoorow.ToString() });
            }
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {

            dataGridView11.EnableHeadersVisualStyles = false;
            dataGridView11.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridView11.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView11.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 16, FontStyle.Bold);
            dataGridView11.ColumnCount = 7;

            dataGridView11.Columns[0].Name = "ID";
            dataGridView11.Columns[0].HeaderText = "ID";
            dataGridView11.Columns[0].Visible = false;   
            dataGridView11.Columns[1].Name = "Name";
            dataGridView11.Columns[1].HeaderText = "Name";
            dataGridView11.Columns[2].Name = "BookTitle";
            dataGridView11.Columns[2].HeaderText = "BookTitle";
            dataGridView11.Columns[3].Name = "Author";
            dataGridView11.Columns[3].HeaderText = "Author";
            dataGridView11.Columns[4].Name = "Address";
            dataGridView11.Columns[4].HeaderText = "Address";
            dataGridView11.Columns[5].Name = "Phone";
            dataGridView11.Columns[5].HeaderText = "Phone";
            dataGridView11.Columns[6].Name = "Return";
            dataGridView11.Columns[6].HeaderText = "Return";
            dataGridView11.Rows.Clear();
            GetAllBorrowed();
        }

        int IndexRow;
        private void dataGridView11_Click(object sender, EventArgs e)
        {
            IndexRow = dataGridView11.SelectedCells[0].RowIndex;

            textName.Text = dataGridView11[1, IndexRow].Value.ToString();
            textBook.Text = dataGridView11[2, IndexRow].Value.ToString();
            txtAuthor.Text = dataGridView11[3, IndexRow].Value.ToString();
            borrowed_Address.Text = dataGridView11[4, IndexRow].Value.ToString();
            Borrowed_phone.Text = dataGridView11[5, IndexRow].Value.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e) => Clear();

        private void Clear()
        {
            textName.Text = "";
            textBook.Text = "";
            txtAuthor.Text = "";
            borrowed_Address.Text = "";
            Borrowed_phone.Text = "";
        }

        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {
            ReadyOnly(); try
            {
              int id = int.Parse(dataGridView11[0, IndexRow].Value.ToString());

            
          
                var BooksBrowered = context.BorrowedBooks.FirstOrDefault(d => d.ID == id);
                var Result = MessageBox.Show("Are you Sure Return this Book", "Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    if (BooksBrowered != null)
                    {
                        var bookId = BooksBrowered.BookId;
                        var book = context.Books.Where(b => b.Id == bookId).FirstOrDefault();
                        book.Count += 1;
                        BooksBrowered.IsReturn = true;

                        context.SaveChanges();
                        context.SaveChanges();
                        dataGridView11.Rows.Clear();
                        GetAllBorrowed();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("invaild");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        

        private void btn_GetAllReturned_Click(object sender, EventArgs e)
        {
            ReadyOnly();
            this.returnBooks_returnBtn.Enabled = false;

            this.lblChangeTxt.Text = "Dispaly All books Returned ";

          var AllBorrowedBooks = context.BorrowedBooks.Where(d=>d.IsReturn == true).ToList();
            dataGridView11.Rows.Clear();
             foreach(var  item in AllBorrowedBooks)
            {
                dataGridView11.Rows.Add(new string[] { item.ID.ToString(), item.Person.Name, item.Book.BookTitle, item.Book.Author, item.Person.Address, item.Person.phone, item.EndBoorow.ToString() });

            }
            Clear();




        }



        private void ReadyOnly()
        {
            this.textName.ReadOnly = true; 
            this.borrowed_Address.ReadOnly = true; 
            this.Borrowed_phone.ReadOnly = true;   
            this.txtAuthor.ReadOnly = true;    
            this.textBook.ReadOnly = true; 
        }

        private void Resert_Page_Click(object sender, EventArgs e)
        {
            ReadyOnly();
            this.returnBooks_returnBtn.Enabled = true;
            this.lblChangeTxt.Text = "All Borrowed Books ";

            var Reset_Page = context.BorrowedBooks.Where(d => d.IsReturn == false).ToList();
             dataGridView11.Rows.Clear();
            GetAllBorrowed(); 
            Clear();    

        }
    }
}
