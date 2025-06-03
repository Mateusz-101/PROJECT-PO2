using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPManagementSystem.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa sprzętu jest wymagana.")]
        [StringLength(100, ErrorMessage = "Nazwa sprzętu nie może przekraczać 100 znaków.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Numer seryjny jest wymagany.")]
        [StringLength(50, ErrorMessage = "Numer seryjny nie może przekraczać 50 znaków.")]
        public string SerialNumber { get; set; } = "";

        [Required(ErrorMessage = "Status sprzętu jest wymagany.")]
        [StringLength(50, ErrorMessage = "Status nie może przekraczać 50 znaków.")]
        public string Status { get; set; } = "Sprawny";

        [DataType(DataType.Date)]
        [CustomValidation(typeof(Equipment), nameof(ValidateInspectionDate))]
        [Display(Name = "Data ostatniego przeglądu")]
        public DateTime? LastInspectionDate { get; set; }

        public ICollection<RescueAction>? RescueActions { get; set; }

        public static ValidationResult? ValidateInspectionDate(DateTime? date, ValidationContext context)
        {
            if (date.HasValue && date.Value > DateTime.Today)
            {
                return new ValidationResult("Data przeglądu nie może być z przyszłości.");
            }

            return ValidationResult.Success;
        }
    }
}