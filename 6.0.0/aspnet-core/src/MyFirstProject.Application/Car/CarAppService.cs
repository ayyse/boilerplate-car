using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstProject.Authorization;
using MyFirstProject.Car.Dto;
using MyFirstProject.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Car
{
    [AbpAuthorize(PermissionNames.Pages_Cars)]
    public class CarAppService : AsyncCrudAppService<CarEntity, CarDto, int>, ICarAppService
    {
        private readonly IRepository<CarEntity, int> _carRepository;
        //private readonly IObjectMapper _objectMapper;
        public CarAppService(IRepository<CarEntity, int> carRepository) : base(carRepository)
        {
            _carRepository = carRepository;
            //_objectMapper = objectMapper;
        }

        public override async Task<CarDto> CreateAsync(CarDto input)
        {
            CarEntity car = ObjectMapper.Map<CarEntity>(input);
            var createdCar = await _carRepository.InsertAsync(car);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<CarDto>(createdCar);
            //var recordNum = _carRepository.GetAll().CountAsync();
            //if (await recordNum < 6)
            //{

            //}
        }

        public async Task DeleteAsync(int input)
        {
            var deletedCar = await _carRepository.FirstOrDefaultAsync(c => c.Id == input);
            await _carRepository.DeleteAsync(deletedCar);
            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public override async Task<CarDto> UpdateAsync(CarDto input)
        {
            //CarEntity car = ObjectMapper.Map<CarEntity>(input);
            var updatedCar = await _carRepository.FirstOrDefaultAsync(c => c.Id == input.Id);
            await _carRepository.UpdateAsync(updatedCar);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<CarDto>(updatedCar);
        }

        public async Task<List<CarDto>> GetAllAsync()
        {
            var carList = await _carRepository.GetAll().ToListAsync();
            return ObjectMapper.Map<List<CarDto>>(carList);
        }

        //protected override async Task<CarDto> GetEntityByIdAsync(int id)
        //{
        //    CarEntity car = ObjectMapper.Map<CarEntity>(id);
        //    await _carRepository.FirstOrDefaultAsync(car => car.Id == id);
        //    return ObjectMapper.Map<CarDto>(car);
        //}

        public async Task<CarDto> GetById(int carId)
        {
            CarEntity car = ObjectMapper.Map<CarEntity>(carId);
            await _carRepository.FirstOrDefaultAsync(car => car.Id == carId);
            return ObjectMapper.Map<CarDto>(car);
        }
    }
}
