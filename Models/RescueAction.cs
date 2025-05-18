using System.ComponentModel.DataAnnotations;

namespace OSPManagementSystem.Models
{
    public class RescueAction
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Type { get; set; } = ""; // np. Pożar, Wypadek, Powódź

        [Required]
        public string Location { get; set; } = "";

        public string Description { get; set; } = "";

        public ICollection<Firefighter>? Firefighters { get; set; }
        public ICollection<Equipment>? Equipment { get; set; }
    }
}