using Bp.Posts;
using Bp.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Bp.PostsSalary
{
    public class PostSalary : IEntity
    {
        public string PostName { get; set; }
        public int RegionId { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public Region Region { get; set; }
        public Post Post { get; set; }

        public object[] GetKeys()
        {
            return new object[] { PostName, RegionId };
        }
    }
}
