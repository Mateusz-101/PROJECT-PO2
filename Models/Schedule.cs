using System.ComponentModel.DataAnnotations;

namespace OSPManagementSystem.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Type { get; set; } = ""; // "Dyżur" lub "Ćwiczenie"

        // Relacja do strażaka
        public int FirefighterId { get; set; }
        public Firefighter? Firefighter { get; set; }
    }
}
