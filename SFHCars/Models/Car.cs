using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFHCars.Models
{
    public class Car
    {
        private string make;
        private string model;
        private string variant;
        private double price;
        private double mileage;
        private int year;

        public string Make{ get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public double Price { get; set; }
        public double Mileage { get; set; }
        public int Year { get; set; }
    }
}
