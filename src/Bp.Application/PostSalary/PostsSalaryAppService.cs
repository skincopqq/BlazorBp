using Abp.BuisnessPortal;
using Bp.Posts;
using Bp.PostsSalary;
using Bp.Regions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bp.PostsSalary
{
    public class PostsSalaryAppService :
       BpAppService, IPostsSalaryAppService
    {
        private readonly IPostSalaryRepository _postSalaryRepository;
        private readonly IPostRepostitory _postRepository;
        private readonly IRegionRepository _regionRepository;

        public PostsSalaryAppService(IPostSalaryRepository postSalaryRepository,
            IPostRepostitory postRepostitory, IRegionRepository regionRepository)
        {
            _postSalaryRepository = postSalaryRepository;
            _postRepository = postRepostitory;
            _regionRepository = regionRepository;
        }
        public async Task<(decimal minSalary, decimal maxSalary)> GetSalaryRange(CalculateSalaryDto input)
        {
            var postsSalary = await _postSalaryRepository.GetPostsSalaryByNameAndRegion(input.PostName,input.Region);
            decimal leadReward = Convert.ToDecimal(postsSalary.Post.IsLead) * postsSalary.MaxSalary * (decimal)0.1;
            decimal experienceReward = postsSalary.MaxSalary - postsSalary.MinSalary - leadReward;
            decimal minSalary = postsSalary.MinSalary + Math.Round((decimal)input.Experience / 5, 0) * experienceReward;
            decimal maxSalary = input.Experience * experienceReward + postsSalary.MinSalary + leadReward;
            return (minSalary, maxSalary);
        }

        public async Task<IEnumerable<PostsDto>> GetPostsList()
        {
            var posts = await _postRepository.GetListAsync();
            return ObjectMapper.Map<IEnumerable<Post>, IEnumerable<PostsDto>>(posts);
        }

        public async Task<IEnumerable<RegionsDto>> GetRegionsListByPostName(string postName)
        {
            var regions = await _regionRepository.GetForPostName(postName);
            return ObjectMapper.Map<IEnumerable<Region>, IEnumerable<RegionsDto>>(regions);
        }
    }
}
