using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPManagementSystem.Models
{
    public class Training
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa szkolenia jest wymagana.")]
        [StringLength(100, ErrorMessage = "Nazwa nie może mieć więcej niż 100 znaków.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Data szkolenia jest wymagana.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data szkolenia")]
        [CustomValidation(typeof(Training), nameof(ValidateTrainingDate))]
        public DateTime Date { get; set; }

        public ICollection<Firefighter>? Firefighters { get; set; }

        public static ValidationResult? ValidateTrainingDate(DateTime date, ValidationContext context)
        {
            if (date > DateTime.Now.AddYears(1))
                return new ValidationResult("Szkolenie nie może być planowane dalej niż rok do przodu.");
            if (date < DateTime.Now.AddYears(-10))
                return new ValidationResult("Data szkolenia jest zbyt odległa w przeszłości.");
            return ValidationResult.Success;
        }
    }
}