using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFHCars.Models
{
    public class SalesPerson
    {
        private string name;
        private string address;
        private string cellno;
        private double salary;
        private double commission;
        public int id;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cellno { get; set; }
        public double Salary { get; set; }
        public double Commission { get; set; }
    }
}
