using Bp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bp.Regions
{
    public class EfCoreRegionRepository : 
        EfCoreRepository<BpDbContext,Region,int>,IRegionRepository
    {
        public EfCoreRegionRepository(
           IDbContextProvider<BpDbContext> dbContextProvider)
           : base(dbContextProvider)
        {
        }

        public async Task<IEnumerable<Region>> GetForPostName(string postName)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(
                u => u.PostSalaries.Any(u => u.PostName == postName))
               .ToListAsync();
        }
    }
}
