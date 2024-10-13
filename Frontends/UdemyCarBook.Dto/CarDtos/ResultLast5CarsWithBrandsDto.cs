using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarDtos
{
    public class ResultLast5CarsWithBrandsDto
    {
        public int Id { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; } = default!;
        public string Model { get; set; } = default!;
        public string CoverImageUrl { get; set; } = default!;
        public int Km { get; set; }
        public string Transmission { get; set; } = default!;
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; } = default!;
        public string BigImageUrl { get; set; } = default!;
    }
}
