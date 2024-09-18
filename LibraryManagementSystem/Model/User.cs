using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Users", Schema = "Secuirty")]

    public class User
    {
        [Key]
        public  int ID { get; set; }
        [Required(ErrorMessage = "UserName is required."), MaxLength(25)]
        public  string UserName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]

        public string Email { get; set; }
        [Required(ErrorMessage = "PassWord is required.") ]
        public string Password { get; set; }
        
        public  DateTime RegisterDate { get; set; }=DateTime.Now;
        public virtual Roles Roles { get; set; }
    }
}
