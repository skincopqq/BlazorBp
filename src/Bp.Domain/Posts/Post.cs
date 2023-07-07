using Bp.PostsSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Bp.Posts
{
    public class Post : IEntity<string>
    {
        public string Name { get; set; }

        public bool IsLead { get; set; }

        public ICollection<PostSalary> PostSalaries { get; set; }

        public string Id => Name;

        public object[] GetKeys()
        {
            return new object[] { Name };
        }
    }
}
