using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarPricingInterface
{
    public interface ICarPricingRepository
    {
        List<CarPricingEntity> GetCarPricingWithCars();
        List<CarPricingEntity> GetCarPricingWithTimePeriod();
        List<CarPricingViewModel> GetCarPricingWithTimePeriod1();
    }
}
