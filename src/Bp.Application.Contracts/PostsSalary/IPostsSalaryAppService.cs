using Abp.BuisnessPortal;
using Bp.Posts;
using Bp.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Bp.PostsSalary
{
    public interface IPostsSalaryAppService : IApplicationService
    {
        public Task<(decimal minSalary, decimal maxSalary)> GetSalaryRange(CalculateSalaryDto input);
        public Task<IEnumerable<PostsDto>> GetPostsList();
        public Task<IEnumerable<RegionsDto>> GetRegionsListByPostName(string postName);
    }
}
