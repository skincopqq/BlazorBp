using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Abp.BuisnessPortal
{
    public class CalculateSalaryDto
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public int EmployeeNumber { get; set; }

        [Required]
        public string PostName { get;set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public string Region { get; set; }

    }
}
