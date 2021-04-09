using Abp.Domain.Entities;
using MyFirstProject.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstProject.Cars
{
    public class CarPark : Entity<int>
    {
        [NotMapped]
        [ForeignKey("UserId")]
        public User Users { get; set; }

        public string Plaka { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ExitTime { get; set; }

        public CarPark()
        {
            LoginTime = DateTime.Now;
        }
    }
}
