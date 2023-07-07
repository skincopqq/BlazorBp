using Bp.EntityFrameworkCore;
using Bp.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bp.Posts
{
    public class EfCorePostRepository :
        EfCoreRepository<BpDbContext, Post,string>, IPostRepostitory
    {
        public EfCorePostRepository(
           IDbContextProvider<BpDbContext> dbContextProvider)
           : base(dbContextProvider)
        {
        }
    }
}
