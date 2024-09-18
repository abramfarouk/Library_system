using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraExport.Helpers;
using LibraryManagementSystem.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : UserControl
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public Dashboard()
        {
            InitializeComponent();
            int CopyBookCount = context.Books.Sum(x => x.Count);
           

            var borrowedBookCount = context.BorrowedBooks.Where(d => d.IsReturn == false).Count(); ; 
            lblBorrowed.Text = borrowedBookCount.ToString();

            var allBook = CopyBookCount + borrowedBookCount;

            lblAll.Text = (allBook).ToString();

            lblAvailable.Text = (allBook - borrowedBookCount).ToString();

             int PersonCount = context.Persons.Count(); 
             PeopleCount.Text = PersonCount.ToString(); 

        }

      
    }
}
