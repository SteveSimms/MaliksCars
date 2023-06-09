using MaliksCars.Application.Models;

namespace MaliksCars.Application.Services
{
    public interface ICarService
    {

        public Task<List<Car>> GetCarsAsync();
        public Task<Car> GetCarByIdAsync(int id);

        public Task<Car> UpdateCarAsync(Car car);
        public Task<Car> CreateCarAsync(Car car);
    };
}