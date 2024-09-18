using LibraryManagementSystem.Data;
using LibraryManagementSystem.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddPerson : UserControl
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        ApplicationDbContext context = new ApplicationDbContext();

        private void AddPerson_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue; 
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 16, FontStyle.Bold);

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].Name = "Address";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].Name = "Phone";
            dataGridView1.Columns[3].HeaderText = "Phone";
            dataGridView1.Columns[4].Name = "BlackList";
            dataGridView1.Columns[4].HeaderText = "BlackList";
            dataGridView1.Rows.Clear();
            GetAllPerson();
        }

        private void GetAllPerson()
        {
            var people = context.Persons.ToList();

            foreach (var person in people)
            {

                dataGridView1.Rows.Add(new string[] { person.ID.ToString() ,   person.Name, person.Address, person.phone , person.BlackList.ToString()});
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedValue = comboBlacklist.SelectedItem.ToString();

                var person = new Person()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    phone = txtPhone.Text,
                    BlackList= bool.Parse(selectedValue)
                };

                context.Persons.Add(person);
                context.SaveChanges();
                dataGridView1.Rows.Clear();
                GetAllPerson();
                Clear();
            }
            catch
            {
                MessageBox.Show("Enter valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var id = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
            var OldPerson = context.Persons.FirstOrDefault(x => x.ID == id);
            try
            {
                string selectedValue = comboBlacklist.SelectedItem.ToString();

                if (OldPerson != null)
                {
                    OldPerson.Name = txtName.Text;
                    OldPerson.Address = txtAddress.Text;
                    OldPerson.phone = txtPhone.Text;
                    OldPerson.BlackList = bool.Parse(selectedValue);

                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    GetAllPerson();
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Enter valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
            var person = context.Persons.FirstOrDefault(x => x.ID == id);
            var Result = MessageBox.Show("Are you Sure Remove this Person", "Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (person != null)
                {

                    context.Persons.Remove(person);
                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    GetAllPerson();
                    Clear();
                }
                else
                {
                    MessageBox.Show("invaild");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
            => Clear();

        private void Clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            comboBlacklist.SelectedIndex = -1;
        }

        int IndexRow;

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            IndexRow = dataGridView1.SelectedCells[0].RowIndex;

            txtName.Text = dataGridView1[1, IndexRow].Value.ToString();
            txtAddress.Text = dataGridView1[2, IndexRow].Value.ToString();
            txtPhone.Text = dataGridView1[3, IndexRow].Value.ToString();
            comboBlacklist.Text = dataGridView1[4, IndexRow].Value.ToString();
        }

      
    }
}
