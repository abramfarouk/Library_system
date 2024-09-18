using DevExpress.Portable;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Model
{
    public class Person
    {

        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is Required"), MaxLength(25)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Name is Required") ,MaxLength(25)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Name is Required"), MaxLength(11)]
        public string phone { get; set; }
        public virtual ICollection<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();
        public  bool BlackList { get; set; }
       

    }
}