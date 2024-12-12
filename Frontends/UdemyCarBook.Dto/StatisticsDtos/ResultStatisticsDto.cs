using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgPriceDaily { get; set; }
        public decimal avgPriceForWeekly { get; set; }
        public decimal avgPriceForMontly { get; set; }
        public int carCountByTransmissionIsAuto { get; set; }
        public int carCountByKmSmallerThan1000 { get; set; }
        public int carCountByFuelGasOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public string carBrandAndModelByRendPriceDailyMin { get; set; }
        public string carBrandAndModelByRendPriceDailyMax { get; set; }
        public string brandNameByMaxCarCount { get; set; }
        public string blogTitleByMaxComments { get; set; }
    }
}
