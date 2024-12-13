using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        public string CustomerName{ get; set; } = default!;
        public string CustomerSurname { get; set; } = default!;
        public string CustomerMail { get; set; } = default!;
        public List<RentACarProcessEntity> RentACarProcesses{ get; set; }
    }
}
