using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPManagementSystem.Models
{
    public class Firefighter
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane.")]
        [StringLength(30, ErrorMessage = "Imię nie może być dłuższe niż 30 znaków.")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [StringLength(50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków.")]
        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "Data urodzenia jest wymagana.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]
        [CustomValidation(typeof(Firefighter), nameof(ValidateBirthDate))]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
        [Phone(ErrorMessage = "Podaj poprawny numer telefonu.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Numer telefonu musi mieć dokładnie 9 cyfr.")]
        public string Phone { get; set; } = "";

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres e-mail.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Stopień jest wymagany.")]
        [StringLength(50)]
        public string Rank { get; set; } = "";

        [Display(Name = "Aktywny")]
        public bool IsActive { get; set; } = true;

        public ICollection<Training>? Trainings { get; set; }
        public ICollection<RescueAction>? RescueActions { get; set; }
        public ICollection<Schedule>? Schedules { get; set; }
        public static ValidationResult? ValidateBirthDate(DateTime birthDate, ValidationContext context)
        {
            if (birthDate > DateTime.Now)
            {
                return new ValidationResult("Data urodzenia nie może być z przyszłości.");
            }

            var minDate = DateTime.Now.AddYears(-80);
            if (birthDate < minDate)
            {
                return new ValidationResult("Data urodzenia jest zbyt odległa.");
            }

            return ValidationResult.Success;
        }
    }
}
