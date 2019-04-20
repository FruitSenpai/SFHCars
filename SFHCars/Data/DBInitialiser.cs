using SFHCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFHCars.Data
{
    public class DBInitialiser
    {
        public static void Initialise(SFHContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cars.Any())
            {
                return;
            }

            var cars = new Car[]
           {
                new Car{Make="Honda", Model="Jazz", Mileage=10000, Price=100000, Variant="1.5 Vtec", Year= 2012 }
           };

            foreach(Car c in cars)
            {
                context.Cars.Add(c);
            }
            context.SaveChanges();

            var branches = new Branch[]
            {
                new Branch{Name = "SFH Sandown", Location="Sandton"}
            };

            foreach(Branch b in branches)
            {
                context.Branches.Add(b);
            }
            context.SaveChanges();

            var salespersons = new SalesPerson[]
            {
                new SalesPerson{Name= "John", Address="1 Aloe road", Cellno="0762345624", Commission= 0.10, Salary= 15000}
            };

            foreach(SalesPerson sp in salespersons)
            {
                context.SalesPeople.Add(sp);
            }
            context.SaveChanges();
        }
    }
}
