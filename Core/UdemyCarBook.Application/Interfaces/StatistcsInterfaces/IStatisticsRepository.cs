using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Interfaces.StatistcsInterfaces
{
    public interface IStatisticsRepository
    {
        int GetCarCount();
        int GetLocationCount();
        int GetAuthorCount();
        int GetBLogCount();
        int GetBrandCount();
        decimal GetAvgRentPriceForDayliy();
        decimal GetAvgRentPriceForWeekly();
        decimal GetAvgRentPriceForMonthly();
        int GetCarCountByTransmissionIsAuto();
        string GetBrandNameByMaxCarCount();
        string GetBlogTitleByMaxComments();
        int GetCarCountByKmSmallerThan1000();
        int GetCarCountByFuelGasOrDiesel();
        int GetCarCountByFuelElectric();
        string GetCarBrandAndModelByRendPriceDailyMax();
        string GetCarBrandAndModelByRendPriceDailyMin();
    }
}
