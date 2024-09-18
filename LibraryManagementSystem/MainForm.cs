using LibraryManagementSystem.Data;
using LibraryManagementSystem.Model;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        private AddBooksForm addBooks;
        private LoginForm loginForm = new LoginForm();
        private Registeration registerationForm = new Registeration();
        private Dashboard dashboard = new Dashboard(); 
        private BorrowedBooks borrowedBooks;
        private ReturnBooks returnBooks;  
        private AddPerson addPerson;
        private ApplicationDbContext _context = new ApplicationDbContext(); 
        public string Name {get { return greet_label.Text;}set{ greet_label.Text = value;} }

        public User User { get; }


        public MainForm(User user)
        {
            
            InitializeComponent();
            User = user;
        }

        private void DisplayForms<T>(T control) where T : UserControl 
        {
            pn_Container.Controls.Clear();
            pn_Container.Controls.Add(control);
        }
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            lblChange.Text = "Library Management System | Dashboard";
            dashboard = new Dashboard();
            DisplayForms(dashboard);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayForms<Dashboard>(dashboard);
            if (User.Roles.ID == 2)
                Add_account.Visible = true;
            else
                Add_account.Visible = false;
        }

        private void bn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addBooks_btn_Click(object sender, EventArgs e)
        {
            lblChange.Text = "Library Management System | Add Books";
            addBooks = new AddBooksForm();
            DisplayForms(addBooks);
        }

        private void Borrowed_Btn_Click(object sender, EventArgs e)
        {
            lblChange.Text = "Library Management System | Borrowed Book";
            borrowedBooks = new BorrowedBooks();
            DisplayForms(borrowedBooks);
        }

        private void returnBooks_btn_Click(object sender, EventArgs e)
        {
            lblChange.Text = "Library Management System | Return Book";
            returnBooks = new ReturnBooks();
            DisplayForms(returnBooks);
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;   
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            lblChange.Text = "Library Management System | Add Person"; 
            addPerson = new AddPerson();
            DisplayForms<AddPerson>(addPerson);
        }


        private void Add_account_Click_1(object sender, EventArgs e)

        {
            lblChange.Text = "Library Management System | Add Account";
            DisplayForms<Registeration>(registerationForm);
                
          }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

