using System.ComponentModel.DataAnnotations;

namespace AirsoftGroup.Models.Entity
{
    public class Chat
    {
        [Key]
        public int messageID { get; set; }
        public string user { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Your message must contain minimum 10 characters")]
        public string message { get; set; }
        public DateTime messageCreated { get; set; } = DateTime.Now;
    }
}
