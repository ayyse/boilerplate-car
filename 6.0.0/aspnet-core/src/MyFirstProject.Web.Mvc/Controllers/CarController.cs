using Abp.AspNetCore.Mvc.Authorization;
using Abp.Web.Mvc.Alerts;
using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Authorization;
using MyFirstProject.Car;
using MyFirstProject.Car.Dto;
using MyFirstProject.Cars;
using MyFirstProject.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstProject.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Cars)]
    public class CarController : MyFirstProjectControllerBase
    {
        private readonly CarAppService _carService;
        private readonly IAlertManager _alertManager;
        public CarController(CarAppService carService, IAlertManager alertManager)
        {
            _carService = carService;
            _alertManager = alertManager;
        }
        public async Task<IActionResult> Index(CarDto model)
        {
            List<CarDto> data = await _carService.GetAllAsync();
            bool isAllowedAddCar = !(data.Count > 5);
            ViewBag.IsAllowedAddCar = isAllowedAddCar;
            if (model.LoginTime > model.ExitTime)
            {
                _alertManager.Alerts.Warning("Exit time cannot be older than login time");
            }
            if (isAllowedAddCar == false)
            {
                _alertManager.Alerts.Warning("It is not allowed to add more than six cars");
            }
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarDto model)
        {
            await _carService.CreateAsync(model);
            return RedirectToAction("Index");

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
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(CarDto model)
        {
            await _carService.DeleteAsync(model);
            return RedirectToAction("Index");
        }

    }
}
