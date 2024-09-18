using LibraryManagementSystem.Data;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{

    //Database.SetInitializer<DataContext>(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());

    public partial class RegisterationForm : Form
    {
        private LoginForm loginForm = new LoginForm();
        ApplicationDbContext context = new ApplicationDbContext(); 
        public RegisterationForm()
        {
            InitializeComponent();
        }

        private void RegisterationForm_Load(object sender, EventArgs e)
        {

        }

        private void signINBtn_Click(object sender, EventArgs e)
        {
         
            loginForm = new LoginForm();    
            loginForm.Show(); 
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void Register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPassTxt.PasswordChar = Register_showPass.Checked ? '\0' : '*'; 
        }
        private bool IsValid(User model, out string errorMessage)
        {
            var validationContext = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(model, validationContext, results, true);

            if (!isValid)
            {
                errorMessage = string.Join("\n", results.Select(r => r.ErrorMessage));
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private  void  RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegisterPassTxt.Text) ||
                string.IsNullOrEmpty(Register_Name.Text) ||
                string.IsNullOrEmpty(Register_Email.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            var users = context.Users.FirstOrDefault(u => u.Email == Register_Email.Text);

            if (users != null)
            {
                MessageBox.Show("Email Is Already Please Change email", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Hashing a password
                string hashedPassword = PasswordHaser.HashPassword(RegisterPassTxt.Text);

                User user = new User()
                {
                    Email = Register_Email.Text,
                    UserName = Register_Name.Text,
                    Password = hashedPassword,
                };



                if (IsValid(user, out string errorMessage))
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Registration failed: {errorMessage}");
                }

            }

        }
    }
}
