using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.ReservationDtos
{
    public class CreateReservationDto
    {
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public int PickUpLocationID { get; set; }
        public int DropOffLocationID { get; set; }
        public int CarID { get; set; }
        public int Age { get; set; }
        public int DrivingLicence { get; set; }
        public string? Description { get; set; }
    }
}
