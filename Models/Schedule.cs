using System;
using System.ComponentModel.DataAnnotations;

namespace OSPManagementSystem.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Data dyżuru jest wymagana.")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Schedule), nameof(ValidateDate))]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Typ dyżuru jest wymagany.")]
        [StringLength(50, ErrorMessage = "Typ dyżuru nie może być dłuższy niż 50 znaków.")]
        public string Type { get; set; } = "";

        [Required(ErrorMessage = "Strażak jest wymagany.")]
        public int FirefighterId { get; set; }

        public Firefighter? Firefighter { get; set; }

        public static ValidationResult? ValidateDate(DateTime date, ValidationContext context)
        {
            if (date < DateTime.Today.AddYears(-5))
                return new ValidationResult("Data jest zbyt odległa w przeszłości.");

            return ValidationResult.Success;
        }
    }
}