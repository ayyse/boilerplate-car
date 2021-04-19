using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Cars
{
    public class CarModel : Entity<int>
    {
        public CarModel()
        {
            LoginTime = DateTime.Now;
        }

        [MaxLength(10)]
        public string Plaka { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY HH:mm}")]
        //[Required]
        public DateTime LoginTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY HH:mm}")]
        [Required]
        public DateTime ExitTime { get; set; }

        
    }
}
