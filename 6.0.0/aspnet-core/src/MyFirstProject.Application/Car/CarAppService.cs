using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyFirstProject.Authorization;
using MyFirstProject.Car.Dto;
using MyFirstProject.Cars;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstProject.Car
{
    [AbpAuthorize(PermissionNames.Pages_Cars)]
    public class CarAppService : AsyncCrudAppService<CarModel, CarDto, int>, ICarAppService
    {
        private readonly IRepository<CarModel, int> _carRepository;
        private readonly IMapper _mapper;
        public CarAppService(IRepository<CarModel, int> carRepository, IMapper mapper) : base(carRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public override async Task<CarDto> CreateAsync(CarDto input)
        {
            var result = await _carRepository.GetAll().ToListAsync();
            if (result.Count <= 5)
            {
                var car = _mapper.Map<CarModel>(input);
                var createdCar = await _carRepository.InsertAsync(car);
                await CurrentUnitOfWork.SaveChangesAsync();
                return _mapper.Map<CarDto>(createdCar);
            }
            return input;
         }

        public async Task DeleteAsync(int input)
        {
            var deletedCar = await _carRepository.FirstOrDefaultAsync(c => c.Id == input);
            await _carRepository.DeleteAsync(deletedCar);
            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public override async Task<CarDto> UpdateAsync(CarDto input)
        {
            var car = _mapper.Map<CarModel>(input);
            await _carRepository.UpdateAsync(car);
            await CurrentUnitOfWork.SaveChangesAsync();
            return _mapper.Map<CarDto>(car);
        }

        public async Task<List<CarDto>> GetAllAsync()
        {
            var carList = await _carRepository.GetAll().ToListAsync();
            return _mapper.Map<List<CarDto>>(carList);
        }

        public async Task<CarDto> GetById(int carId)
        {
            var car = await _carRepository.FirstOrDefaultAsync(car => car.Id == carId);
            return _mapper.Map<CarDto>(car);
        }
    }
}
