using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Results.CarDescriptionResults
{
    public class GetCarDescriptionByCarIdQueryResult
    {
        public int Id { get; set; }
        public string Details { get; set; } = default!;
        public int CarID { get; set; }
    }
}
