using MaliksCars.Application.Database;
using MaliksCars.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace MaliksCars.Application.Services
{
    public class CarService : ICarService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _factory;

        public CarService(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }

  public async Task<Car> CreateCarAsync(Car car)
        {
        using var context = _factory.CreateDbContext();
        var addedCar = await context.Cars.AddAsync(car);
        await context.SaveChangesAsync();
        return addedCar.Entity;

        }


        //update car

        public async Task<Car> UpdateCarAsync(Car car)
        { 
        using var context = _factory.CreateDbContext();
        var updatedCar = context.Cars.Update(car);
        await context.SaveChangesAsync();
        return updatedCar.Entity;

        }


        public async Task<Car> GetCarByIdAsync(int id)
        {
            using  var context = _factory.CreateDbContext();
            var car = await context.Cars.FirstOrDefaultAsync(c => c.Id == id);
            return car;
        }


      


        //get all cars
        public async Task<List<Car>> GetCarsAsync()
        {
            using  var context = _factory.CreateDbContext();
            var car = await context.Cars.ToListAsync();
            return car;
        }
    }
}
