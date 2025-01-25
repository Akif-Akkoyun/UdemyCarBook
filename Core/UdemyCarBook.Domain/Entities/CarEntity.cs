using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CarEntity
    {
        public int Id { get; set; }
        public int BrandID { get; set; }
        public BrandEntity Brand { get; set; } = default!;
        public string Model { get; set; } = default!;
        public string CoverImageUrl{ get; set; } = default!;
        public int Km{ get; set; }
        public string Transmission{ get; set; } = default!;
        public byte Seat { get; set; }
        public byte Luggage{ get; set; }
        public string Fuel{ get; set; } = default!;
        public string BigImageUrl{ get; set; } = default!;
        public List<CarFeatureEntity> CarFeatures { get; set; } = default!;
        public List<CarDescription> CarDescriptions { get; set; } = default!;
        public List<CarPricingEntity> CarPricings { get; set; } = default!;
        public List<RentACarEntity> RentACars { get; set; } = default!;
        public List<RentACarProcessEntity> RentACarProcesses { get; set; } = default!;
        public List<ReservationEntity> Reservations { get; set; } = default!;
        public List<ReviewEntity> Reviews { get; set; } = default!;

    }
}
