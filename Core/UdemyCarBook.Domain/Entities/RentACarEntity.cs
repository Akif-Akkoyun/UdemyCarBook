using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class RentACarEntity
    {
        public int Id { get; set; }
        public int LocationID { get; set; }
        public LocationEntity Location{ get; set; } = default!;
        public int CarID { get; set; }
        public CarEntity Car{ get; set; } = default!;
        public bool Available{ get; set; }
    }
}
