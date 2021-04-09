using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Car.Dto
{
    public class CarDto : EntityDto<int>
    {
        public string Plaka { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
