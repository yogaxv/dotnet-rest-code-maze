using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("phone")]
        public string Phone { get; set; }


        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Column("verified_at")]
        public DateTime VerifiedAt { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("remember_token")]
        public string RememberToken { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
