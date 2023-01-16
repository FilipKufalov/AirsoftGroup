using System.ComponentModel.DataAnnotations;

namespace AirsoftGroup.Models
{
    public class Stats
    {
        [Key]
        public int UserId { get; set; }
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }
        public int Win { get; set; }
        public int Defeat { get; set; }
        public double Accuracy { get; set; }
        [Display(Name = "Headshot Percentage")]
        public double HeadshotPercentage { get; set; }
        [Display(Name = "Favourite Weapon")]
        public string FavouriteWeapon { get; set; }
    }
}
