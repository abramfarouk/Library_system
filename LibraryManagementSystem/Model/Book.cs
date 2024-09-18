using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="BookTitle Is Required") , MaxLength(25) ]  
        public string BookTitle { set; get; }
        [Required(ErrorMessage = "Author Is Required"), MaxLength(25)]
        public string Author { set; get; }

        [Required]
        public  string Description { get; set; }

        public DateTime Published { set; get; }

        public  int  Count { get; set; }

    }
}
