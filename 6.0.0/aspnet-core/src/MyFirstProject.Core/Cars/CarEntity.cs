using Abp.Domain.Entities;
using MyFirstProject.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Cars
{
    public class CarEntity : Entity<int>
    {
        [NotMapped]
        [ForeignKey("UserId")]
        public User Users { get; set; }

        public string Plaka { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ExitTime { get; set; }

        public CarEntity()
        {
            LoginTime = DateTime.Now;
        }
    }
}
