using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.StatistcsInterfaces;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxComments()
        {
            var values = _context.Comments
                .GroupBy(x=>x.Id)
                .Select(y=> new { BlogId = y.Key, CommentCount = y.Count() })
                .OrderByDescending(x => x.CommentCount).Take(1).FirstOrDefault();

            string blogTitle = _context.Blogs.Where(x => x.Id == values.BlogId).Select(x => x.Title).FirstOrDefault();
            return blogTitle;
        }

        public string GetBrandNameByMaxCarCount()
        {
            string brandName = _context.Cars
                .GroupBy(x => x.Brand.Name)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key)
                .FirstOrDefault();
            return brandName;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDayliy()
        {
            int id = _context.Pricings.Where(x =>x.Name=="Günlük").Select(x => x.Id).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            int id = _context.Pricings.Where(x => x.Name == "Aylık").Select(x => x.Id).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(x => x.Name == "Haftalık").Select(x => x.Id).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public int GetBLogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRendPriceDailyMax()
        {
            //int pricingId = _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.Id).FirstOrDefault();
            //decimal amount = _context.CarPricings.Where(y => y.PricingID == pricingId).Max(x => x.Amount);
            //int carId = _context.CarPricings.Where(x => x.Amount == amount).Select(x => x.CarID).FirstOrDefault();
            //string brandModel = _context.Cars.Where(x => x.Id == carId).Include(x => x.Brand).Select(x => x.Brand.Name + " " + x.Model).FirstOrDefault();
            //return brandModel;
            var brandModel = _context.CarPricings
                .Where(cp => cp.Pricing.Name == "Günlük")
                .OrderByDescending(cp => cp.Amount)
                .Select(cp => cp.Car.Brand.Name + " " + cp.Car.Model)
                .FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRendPriceDailyMin()
        {
            int pricingId = _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.Id).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricingId).Min(x => x.Amount);
            int carId = _context.CarPricings.Where(x => x.Amount == amount).Select(x => x.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.Id == carId).Include(x => x.Brand).Select(x => x.Brand.Name + " " + x.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            var values = _context.Cars.Count();
            return values;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x=>x.Fuel == "Elektrik").Count();
            return value;
        }

        public int GetCarCountByFuelGasOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetCarCountByKmSmallerThan1000()
        {
            var value = _context.Cars.Where(x=>x.Km < 1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.LocationEntities.Count();
            return value;
        }
    }
}
