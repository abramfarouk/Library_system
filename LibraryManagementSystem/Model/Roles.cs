using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Roles", Schema = "Secuirty")]
    public class Roles
    {
        [Key]
        public  int ID { get; set; }
        public  string Name { get; set; }
        public  string NormalizedName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
