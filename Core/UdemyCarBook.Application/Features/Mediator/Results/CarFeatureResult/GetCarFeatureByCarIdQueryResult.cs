﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results.CarFeatureResult
{
    public class GetCarFeatureByCarIdQueryResult
    {
        public int Id { get; set; }
        public int FeatureID { get; set; }
        public string FeatureName{ get; set; }
        public bool Available { get; set; }
    }
}
