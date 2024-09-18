using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using System.Data.Entity;
namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private  RegisterationForm registerForm;
        private  MainForm mainForm;


        public LoginForm()
        {
            InitializeComponent();
        }


        private void signupBtn_Click(object sender, EventArgs e)
        {
            registerForm = new RegisterationForm();
            registerForm.Show();
            this.Close();
        }

  
        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = login_showPass.Checked ? '\0' : '*'; 
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                var user = context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Email == txtEmail.Text);

                if (user != null && user.Roles != null)
                {
                    string storedHashedPassword = user.Password;

                    bool isPasswordValid = PasswordHaser.VerifyPassword(txtPassword.Text, storedHashedPassword);

                    if (isPasswordValid)
                    {

                        mainForm = new MainForm(user);
                        mainForm.Show();
                        mainForm.Name = $"Welcome, {user.UserName}";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password or not registered by the Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
