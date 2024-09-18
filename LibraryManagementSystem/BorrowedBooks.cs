using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem
{
    public partial class BorrowedBooks : UserControl
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public BorrowedBooks()
        {
            InitializeComponent();
        }

        private void bookBorrowed_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookIssue_bookTitle.SelectedValue != null && ListName.SelectedValue != null)
                {
                    Book bID = bookIssue_bookTitle.SelectedValue as Book;
                    Person PID = ListName.SelectedValue as Person;
                    if (bookIssue_returnDate.Value > DateTime.UtcNow )
                    {
                        var x = this.ListName.SelectedIndex;
                        var BorrowedBook = new BorrowedBook()
                        {

                            BookId = bID.Id,
                            PersonId = PID.ID,
                            EndBoorow = bookIssue_returnDate.Value,

                        };

                        context.BorrowedBooks.Add(BorrowedBook);
                        bID.Count -= 1;
                        context.SaveChanges();
                        dataGridView11.Rows.Clear();
                        GetAllBorrowed();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("invalid Data" ,"Error" ,MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            }
            catch
            {
                MessageBox.Show("Enter valid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            dataGridView11.EnableHeadersVisualStyles = false;
            dataGridView11.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridView11.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView11.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 16, FontStyle.Bold);

            dataGridView11.ColumnCount = 6;
            dataGridView11.Columns[0].Name = "Name";
            dataGridView11.Columns[0].HeaderText = "Name";
            dataGridView11.Columns[1].Name = "BookTitle";
            dataGridView11.Columns[1].HeaderText = "BookTitle";
            dataGridView11.Columns[2].Name = "Author";
            dataGridView11.Columns[2].HeaderText = "Author";
            dataGridView11.Columns[3].Name = "Address";
            dataGridView11.Columns[3].HeaderText = "Address"; 
            dataGridView11.Columns[4].Name = "Phone";
            dataGridView11.Columns[4].HeaderText = "Phone";
            dataGridView11.Columns[5].Name = "Return";
            dataGridView11.Columns[5].HeaderText = "Return";
            dataGridView11.Rows.Clear();
            GetAllBorrowed();
        }

        private void GetAllBorrowed()
        {
            var Books = context.BorrowedBooks.Where(d=>d.IsReturn == false).ToList();

            foreach (var item in Books)
            {

                dataGridView11.Rows.Add(new string[] { item.Person.Name, item.Book.BookTitle, item.Book.Author, item.Person.Address, item.Person.phone, item.EndBoorow.ToString() });
            }

        }

        private void bookIssue_bookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bookIssue_bookTitle.SelectedItem != null)
            {
                Book bk = bookIssue_bookTitle.SelectedItem as Book;
                txtAuthor.Text = bk.Author;
            }
        }
        int IndexRow; 
        private void dataGridView11_Click(object sender, EventArgs e)
        {
            IndexRow = dataGridView11.SelectedCells[0].RowIndex;

            ListName.Text = dataGridView11[0, IndexRow].Value.ToString();
            bookIssue_bookTitle.Text = dataGridView11[1, IndexRow].Value.ToString();
            txtAuthor.Text = dataGridView11[2, IndexRow].Value.ToString();
            borrowed_Address.Text = dataGridView11[3, IndexRow].Value.ToString();
            Borrowed_phone.Text = dataGridView11[4, IndexRow].Value.ToString();
            bookIssue_returnDate.Text = dataGridView11[5, IndexRow].Value.ToString();
        }


        private void Borrowed_clearBtn_Click(object sender, EventArgs e) => Clear();

        private void Clear()
        {
            ListName.DataSource = null;
            bookIssue_bookTitle.DataSource = null;
            txtAuthor.Text = "";
            borrowed_Address.Text = "";
            Borrowed_phone.Text = "";
        }

        private void ListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListName.SelectedItem != null)
            {
                Person person = ListName.SelectedItem as Person; ;
                borrowed_Address.Text = person.Address;
                Borrowed_phone.Text = person.phone;
            }
        }

        private void bookIssue_bookTitle_Click(object sender, EventArgs e)
        {
            var Books = context.Books.Where(d => d.Count > 0).ToList();
            bookIssue_bookTitle.DataSource = Books;
            bookIssue_bookTitle.DisplayMember = "BookTitle";
        }

        private void ListName_Click(object sender, EventArgs e)
        {
            var Persons = context.Persons.Where(d=>d.BlackList == false).ToList();
            ListName.DataSource = Persons;
            ListName.DisplayMember = "Name";
        }
    }
}
