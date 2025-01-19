using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly CarBookContext _context;

        public CarFeatureRepository(CarBookContext context)
        {
            _context = context;
        }

        public void ChangeCarFeatureAvailableToFalse(int id)
        {
            var values = _context.CarFeatures.Where(x => x.Id == id).FirstOrDefault();
            values.Available = false;
            _context.SaveChangesAsync();
        }

        public void ChangeCarFeatureAvailableToTrue(int id)
        {
            var values =  _context.CarFeatures.Where(x => x.Id == id).FirstOrDefault();
            values.Available = true;
             _context.SaveChanges();
        }

        public void CreateCarFeatureByCar(CarFeatureEntity carFeatureEntity)
        {
            _context.CarFeatures.Add(carFeatureEntity);
            _context.SaveChanges();
        }

        public List<CarFeatureEntity> GetCarFeaturesByCarId(int id)
        {
            var values = _context.CarFeatures.Include(y=>y.Feature).Where(x => x.CarID == id).ToList();
            return values;
        }
    }
}
