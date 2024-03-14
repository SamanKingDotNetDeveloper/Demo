using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Models
{
    [Table("users")]
    public class UserModel
    {
        [Required]
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column ("firstname")]
        public string FirstName { get; set; }

        [Required]
        [Column("lastname")]
        public string LastName { get; set; }

        [Required]
        [Length(13,13)]
        [Column("phone")]
        public string Phone { get; set; }
    }
}
