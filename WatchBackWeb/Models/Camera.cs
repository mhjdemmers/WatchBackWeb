using System.ComponentModel.DataAnnotations;

namespace WatchBackWeb.Models
{
    public class Camera
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Location { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
        public DateTime LastConfirmed { get; set; } = DateTime.Now;
    }
}
