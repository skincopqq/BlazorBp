using Bp.PostsSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Bp.Regions
{
    public class Region : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PostSalary> PostSalaries { get; set; }

        public object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}
