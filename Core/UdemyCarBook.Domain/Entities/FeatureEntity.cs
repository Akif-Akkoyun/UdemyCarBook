using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class FeatureEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<CarFeatureEntity> CarFeatures { get; set; } = default!;
    }
}
