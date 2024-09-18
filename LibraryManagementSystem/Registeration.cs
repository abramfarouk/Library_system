using LibraryManagementSystem.Data;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Registeration : UserControl
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public Registeration()
        {
            InitializeComponent();
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


        //private void Register_showPass_CheckedChanged(object sender, EventArgs e)
        //{
        //    RegisterPassTxt.PasswordChar = Register_showPass.Checked ? '\0' : '*';

        //}

        private void RegisterBtn_Click_1(object sender, EventArgs e)
        {
            if (
         string.IsNullOrEmpty(Register_Name.Text) ||
         string.IsNullOrEmpty(Register_Email.Text) || UserRolesComb.SelectedIndex == -1)
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

                User user = new User()
                {
                    Email = Register_Email.Text,
                    UserName = Register_Name.Text,
                    Roles = UserRolesComb.SelectedItem as Roles
                };


                if (IsValid(user, out string errorMessage))
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Register_Email.Text = "";
                    this.Register_Name.Text = "";
                    this.UserRolesComb.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show($"Registration failed: {errorMessage}");
                }

            }
        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            var Roles = context.Roles.ToList(); 
             UserRolesComb.DataSource = Roles;
            UserRolesComb.DisplayMember = "Name";

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 16, FontStyle.Bold);
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[1].HeaderText = "Email";
            dataGridView1.Columns[2].Name = "UserName";
            dataGridView1.Columns[2].HeaderText = "UserName";
            dataGridView1.Columns[3].Name = "Roles";
            dataGridView1.Columns[3].HeaderText = "Roles";
            dataGridView1.Rows.Clear();
            GetAllAccounts();

        }


        private void GetAllAccounts()
        {
            var people = context.Users.ToList();


            foreach (var person in people)
            {
                if (person.Roles != null)
                {
                    dataGridView1.Rows.Add(new string[] { person.ID.ToString(), person.Email, person.UserName, person.Roles.Name });
                }
                else
                {
                    dataGridView1.Rows.Add(new string[] { person.ID.ToString(), person.Email, person.UserName, "" });

                }
            }


        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int IndexRow;
        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                var ID = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
                var OldUser = context.Users.FirstOrDefault(x => x.ID == ID);

                if (OldUser != null)
                {
                    OldUser.Email = this.Register_Email.Text;
                    OldUser.Roles = UserRolesComb.SelectedItem as Roles;
                    OldUser.UserName = this.Register_Name.Text;
                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    GetAllAccounts();
                    Clear();
                }
            }
        
            catch (Exception ex)
            {
                MessageBox.Show("Select One Row At Least For Updated" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            IndexRow = dataGridView1.SelectedCells[0].RowIndex;
            try
            {
                Register_Email.Text = dataGridView1[1, IndexRow].Value.ToString();
                Register_Name.Text = dataGridView1[2, IndexRow].Value.ToString();
                UserRolesComb.Text = dataGridView1[3, IndexRow].Value.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error" ,MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }

        private void btn_Drop_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
                var User = context.Users.FirstOrDefault(x => x.ID == ID);
                var Result = MessageBox.Show("Are you Sure Remove this user", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    if (User != null)
                    {

                        context.Users.Remove(User);
                        context.SaveChanges();
                        dataGridView1.Rows.Clear();
                        GetAllAccounts();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("invaild");
                    }
                }

            }
            catch (Exception ex) { 
             MessageBox.Show("Select User " , "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



         
        }

        private void Clear()
        {
            this.UserRolesComb.SelectedIndex = -1;
            this.Register_Email.Text = string.Empty;    
            this.Register_Name.Text = string.Empty; 

        }
    }
}
