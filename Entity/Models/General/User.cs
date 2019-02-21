using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("Users", Schema = "dbo")]
    public class User : BaseEntity
    {
        [Column("Name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column("Surname")]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Column("Login")]
        [MaxLength(100)]
        public string Login { get; set; }

        [Column("Password")]
        [MaxLength(100)]
        public string Password { get; set; }

        public override string ToString()
        {
            return Name.Equals(Surname) ? Name : $"{Surname} {Name}";
        }
    }
}