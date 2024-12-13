using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class RentACarProcessEntity
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public CarEntity Car { get; set; } = default!;
        public int PickUpLocationID { get; set; }
        public int DropOffLocationID { get; set; }
        public DateOnly PickUpDate { get; set; }
        public DateOnly DropOffDate { get; set; }
        public TimeOnly PickUpTİme{ get; set; }
        public TimeOnly DropOffTime{ get; set; }
        public int CustomerId { get; set; }
        public CustomerEntity Customer{ get; set; } = default!;
        public string PickUpDescription { get; set; } = default!;
        public string DropOffDescription { get; set; } = default!;
        public decimal TotalPrice { get; set; }
    }
}
