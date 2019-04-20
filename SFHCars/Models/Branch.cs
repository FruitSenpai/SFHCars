using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SFHCars.Models
{
    public class Branch
    {
        

        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(50)]
        [RegularExpression(@"[A-Za-z ]*", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Required*")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(50)]
        [RegularExpression(@"[A-Za-z ]*", ErrorMessage = "Use letters only please")]
        public string Location { get; set; }

    }
}
