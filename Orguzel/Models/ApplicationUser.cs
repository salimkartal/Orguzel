using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orguzel.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Surname { get; set; }
        public string? Adres { get; set; }
        public string? Sehir { get; set; }
        public string? Semt { get; set; }
        public string? PostaKodu { get; set; }
        [NotMapped]
        public string Role { get; set; }

    }
}
