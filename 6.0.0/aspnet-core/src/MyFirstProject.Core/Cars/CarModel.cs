using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Cars
{
    public class CarModel : Entity<int>
    {
        public string Plaka { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
