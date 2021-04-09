﻿using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Authorization;
using MyFirstProject.Car;
using MyFirstProject.Car.Dto;
using MyFirstProject.Cars;
using MyFirstProject.Controllers;
using System.Threading.Tasks;

namespace MyFirstProject.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Cars)]
    public class CarController : MyFirstProjectControllerBase
    {
        private readonly CarAppService _carService;
        public CarController(CarAppService carService)
        {
            _carService = carService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _carService.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarDto model)
        {
            
            {
                var data = await _carService.CreateAsync(model);
                return View("Index");
            }
            return View("Create");
            
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await _carService.GetById(id);
            return View(data);
        }

        public async Task<IActionResult> Update(int id)
        {
            var data = await _carService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CarDto model)
        {
            await _carService.UpdateAsync(model);
            return View();
        }

        public async Task<IActionResult> Delete(CarDto model)
        {
            await _carService.DeleteAsync(model);
            return View();
        }

    }
}