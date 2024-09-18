using LibraryManagementSystem.Model;
using System.Data.Entity;

namespace LibraryManagementSystem.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(): base("name=MyConnection")
        {
            
        }

        public virtual  DbSet<User> Users { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
    }
}
