using Bp.Posts;
using Bp.PostsSalary;
using Bp.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Bp
{
    public class BpDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Region, int> _regionRepository;
        private readonly IRepository<Post, string> _postRepostitory;
        private readonly IRepository<PostSalary> _postSalaryRepository;
        public BpDataSeederContributor(IRepository<Region, int> regionRepository,
            IRepository<Post, string> postRepostitory,
            IRepository<PostSalary> postSalaryRepository)
        {
            _regionRepository =regionRepository;
            _postSalaryRepository = postSalaryRepository;
            _postRepostitory = postRepostitory;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _regionRepository.GetCountAsync() == 0)
            {
                await _regionRepository.InsertManyAsync(new List<Region>
                {
                    new Region { Name = "Boston" },
                    new Region { Name = "Denver" },
                    new Region { Name = "Los Angeles" },
                    new Region { Name = "New York" }
                },autoSave:true);
            }

            if (await _postRepostitory.GetCountAsync() == 0)
            {
                await _postRepostitory.InsertManyAsync(new List<Post> {
                    new Post { Name = "CTO", IsLead = true },
                    new Post { Name = "Developer", IsLead = false },
                    new Post { Name = "Project Manager", IsLead = true },
                    new Post { Name = "Team lead", IsLead = true }
                });
            }
            if (await _postSalaryRepository.GetCountAsync() == 0)
            {
                await _postSalaryRepository.InsertManyAsync(new List<PostSalary>
            {
                new PostSalary { PostName = "CTO", RegionId = 1, MinSalary = 4500.00m, MaxSalary = 100000.00m },
                new PostSalary { PostName = "CTO", RegionId = 2,  MinSalary = 65000.00m, MaxSalary = 125000.00m},
                new PostSalary { PostName = "CTO", RegionId = 3, MinSalary = 60000.00m, MaxSalary = 150000.00m},
                new PostSalary { PostName = "CTO",RegionId = 4 , MinSalary = 72000.00m, MaxSalary = 200000.00m},
                new PostSalary { PostName = "Developer", RegionId = 1, MinSalary = 35000.00m, MaxSalary = 90000.00m},
                new PostSalary { PostName = "Developer", RegionId = 2, MinSalary = 55000.00m, MaxSalary = 115000.00m},
                new PostSalary { PostName = "Developer", RegionId = 3, MinSalary = 50000.00m, MaxSalary = 140000.00m},
                new PostSalary { PostName = "Developer", RegionId = 4, MinSalary = 62000.00m, MaxSalary = 190000.00m},
                new PostSalary { PostName = "Project Manager", RegionId = 1, MinSalary = 30000.00m, MaxSalary = 90000.00m},
                new PostSalary { PostName = "Project Manager", RegionId = 2, MinSalary = 50000.00m, MaxSalary = 110000.00m},
                new PostSalary { PostName = "Project Manager", RegionId = 3, MinSalary = 45000.00m, MaxSalary = 135000.00m },
                new PostSalary { PostName = "Project Manager", RegionId = 4, MinSalary = 57000.00m, MaxSalary = 185000.00m},
                new PostSalary { PostName = "Team lead", RegionId = 1, MinSalary = 40000.00m, MaxSalary =  95000.00m},
                new PostSalary { PostName = "Team lead", RegionId = 2, MinSalary = 60000.00m, MaxSalary = 120000.00m},
                new PostSalary { PostName = "Team lead", RegionId = 3, MinSalary = 55000.00m, MaxSalary = 145000.00m},
                new PostSalary { PostName = "Team lead", RegionId = 4, MinSalary = 67000.00m, MaxSalary = 195000.00m},
            });
            }
        }
    }
}
