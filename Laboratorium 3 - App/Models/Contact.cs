using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Contact
    {

        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Muisz podac imie!")]
        [StringLength(maximumLength: 50, ErrorMessage ="Imie zbyt dlugie, maksymalnie 50 znakow!")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="musisz podac poprawny email(brak znaku @)!")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Numer telefonu powinen zawierac cyfry")]
        public string Phone { get; set; }
        
        public DateTime? Birth { get; set; }

    }
}
