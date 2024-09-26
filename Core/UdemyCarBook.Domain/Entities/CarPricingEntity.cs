using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CarPricingEntity
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public CarEntity Car { get; set; } = default!;
        public int PricingID { get; set; }
        public PricingEntity Pricing { get; set; } = default!;
        public decimal Amount { get; set; }
    }
}
