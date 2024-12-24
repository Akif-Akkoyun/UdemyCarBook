using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class LocationEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RentACarEntity> RentACars { get; set; }
        public List<ReservationEntity> PickUpReservation { get; set; }
        public List<ReservationEntity> DropOffReservation { get; set; }
    }
}
