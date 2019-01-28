using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entity.Models
{
	[Table("Users", Schema = "dbo")]
	public class User : BaseEntity
	{
		[Column("Name")]
		public string Name { get; set; }

		[Column("Surname")]
		public string Surname { get; set; }

		[Column("Login")]
		public string Login { get; set; }

		[Column("Password")]
		public string Password { get; set; }
	}
}