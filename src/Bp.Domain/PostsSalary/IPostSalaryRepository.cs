using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Bp.PostsSalary
{
    public interface IPostSalaryRepository : IRepository<PostSalary>, ITransientDependency
    {
        public Task<PostSalary> GetPostsSalaryByNameAndRegion(string postName, string regionName);
    }
}
