using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CarFeatureEntity
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public CarEntity Car { get; set; } = default!;
        public int FeatureID { get; set; }
        public FeatureEntity Feature { get; set; } = default!;
        public bool Available { get; set; }
    }
}
