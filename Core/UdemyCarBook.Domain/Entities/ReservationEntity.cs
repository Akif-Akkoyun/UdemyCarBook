using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class ReservationEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public string Surname { get; set; } = default!;
        [Required,EmailAddress]
        public string Email { get; set; } = default!;
        [Required,Phone]
        public string Phone { get; set; } = default!;
        public int? PickUpID { get; set; }
        public int? DropOffID { get; set; }
        [Required]
        public int CarID { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int DrivingLicence { get; set; }
        public string? Description { get; set; }
        public LocationEntity PickUpLocation { get; set; }
        public LocationEntity DropOffLocation { get; set; }
    }
}
