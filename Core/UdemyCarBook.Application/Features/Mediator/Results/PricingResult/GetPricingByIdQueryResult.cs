﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Results.PricingResult
{
    public class GetPricingByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
