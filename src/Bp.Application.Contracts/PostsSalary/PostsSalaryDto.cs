using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Bp.PostsSalary
{
    public class PostsSalaryDto
    {
        public string PostName { get; set; }
        public string RegionId { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
    }
}
