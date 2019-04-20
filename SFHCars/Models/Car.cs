using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SFHCars.Models
{
    public class Car
    {
       

        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(50)]
        [RegularExpression(@"[A-Za-z ]*", ErrorMessage = "Use letters only please")]
        public string Make{ get; set; }
        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(50)]
        
        public string Model { get; set; }
        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(50)]
        
        public string Variant { get; set; }
        public double Price { get; set; }
        public double Mileage { get; set; }
        public int Year { get; set; }

        public int Id { get; set; }
    }
}
