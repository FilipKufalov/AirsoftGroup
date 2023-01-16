using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirsoftGroup.Models.Entity
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Signature { get; set; }
        public string AvatarURL { get; set; }
    }
}
