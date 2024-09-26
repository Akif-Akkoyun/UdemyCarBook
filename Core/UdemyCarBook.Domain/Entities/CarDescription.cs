using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CarDescription
    {
        public int Id { get; set; }
        public string Details { get; set; } = default!;
        public int CarID { get; set; }
        public CarEntity Car { get; set; } = default!;
    }
}
