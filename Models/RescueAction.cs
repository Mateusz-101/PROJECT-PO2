using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPManagementSystem.Models
{
    public class RescueAction
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Data akcji jest wymagana.")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(RescueAction), nameof(ValidateDate))]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Typ akcji jest wymagany.")]
        [StringLength(50, ErrorMessage = "Typ akcji nie może być dłuższy niż 50 znaków.")]
        public string Type { get; set; } = "";

        [Required(ErrorMessage = "Lokalizacja jest wymagana.")]
        [StringLength(100, ErrorMessage = "Lokalizacja nie może być dłuższa niż 100 znaków.")]
        public string Location { get; set; } = "";

        [StringLength(1000, ErrorMessage = "Opis akcji nie może przekraczać 1000 znaków.")]
        public string Description { get; set; } = "";

        public ICollection<Firefighter>? Firefighters { get; set; }
        public ICollection<Equipment>? Equipment { get; set; }

        public static ValidationResult? ValidateDate(DateTime date, ValidationContext context)
        {
            if (date > DateTime.Now)
                return new ValidationResult("Data akcji nie może być w przyszłości.");

            var earliestDate = DateTime.Now.AddYears(-30);
            if (date < earliestDate)
                return new ValidationResult("Data akcji jest zbyt odległa w przeszłości.");

            return ValidationResult.Success;
        }
    }
}