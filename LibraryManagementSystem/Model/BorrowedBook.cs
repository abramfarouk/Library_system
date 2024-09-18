using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Model
{
    public class BorrowedBook
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public DateTime StartBorrow { get; set; } = DateTime.Now;
        [Required]
        public DateTime EndBoorow { get; set; }
        public  bool IsReturn { get; set; } 


    }
}