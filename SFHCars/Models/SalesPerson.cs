using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SFHCars.Models
{
    public class SalesPerson
    {
       

        public int Id { get; set; }
        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(50)]
        [RegularExpression(@"[A-Za-z ]*", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(50)]
        //[RegularExpression(@"[A-Za-z 0-9]*", ErrorMessage = "Use letters only please")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid contact number")]
        [StringLength(10)]
        [Display(Name = "Contact No")]
        public string Cellno { get; set; }
        public double Salary { get; set; }
        public double Commission { get; set; }
    }
}
