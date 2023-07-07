using Bp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bp.PostsSalary
{
    public class EfCorePostsSalaryRepository
         : EfCoreRepository<BpDbContext, PostSalary>,
            IPostSalaryRepository
    {
        public EfCorePostsSalaryRepository(
            IDbContextProvider<BpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<PostSalary> GetPostsSalaryByNameAndRegion(string postName,string regionName)
        {
            var dbSet = await GetDbSetAsync();
            var posts = await dbSet.Include(ps => ps.Post)
                .FirstOrDefaultAsync(ps=>ps.PostName == postName && ps.Region.Name == regionName);
            return posts;
        }
    }
}
