using Abp.Application.Services;
using MyFirstProject.Car.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstProject.Car
{
    public interface ICarAppService
    {
        Task<CarDto> GetById(int carId);

        //CarDto CreateCar(CarDto model);
        //CarDto EditCar(int carId);
        //Task<List<CarDto>> GetAllAsync();
        //void Delete(int carId);
    }
}
