using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Bp.Regions
{
    public interface IRegionRepository : IRepository<Region, int>
    {
        public Task<IEnumerable<Region>> GetForPostName(string postName);
    }
}
