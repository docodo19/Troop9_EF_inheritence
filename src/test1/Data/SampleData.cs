using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using test1.Models;

namespace test1.Data
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider sp)
        {
            var db = sp.GetService<ApplicationDbContext>();

            if (!db.NewCars.Any())
            {
                var cars = new NewCar[] {
                    new NewCar { Year = 2000, Make = "VW", Model = "GTI"},
                    new NewCar { Year = 2002, Make = "Ford", Model = "Focus"},
                    new NewCar { Year = 2003, Make = "Honda", Model = "Civic"},
                };
                db.NewCars.AddRange(cars);
                db.SaveChanges();
            }

            if(!db.UsedCars.Any())
            {
                var usedCars = new UsedCar[] {
                    new UsedCar { Year = 1990, Make = "VW", Model = "Fox", Miles = 5000 },
                    new UsedCar { Year = 1995, Make = "Dodge", Model = "Charger", Miles = 8000 },
                    new UsedCar { Year = 1999, Make = "Hyundai", Model = "Sonata", Miles = 9000 },
                };
                db.UsedCars.AddRange(usedCars);
                db.SaveChanges();
            }
        }
    }
}
