using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarDescriptionDtos
{
    public class ResultCarDescriptionByCarIdDto
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public string Details { get; set; } = default!;
    }
}
