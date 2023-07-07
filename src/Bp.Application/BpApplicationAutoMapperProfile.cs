using AutoMapper;
using Bp.Posts;
using Bp.PostsSalary;
using Bp.Regions;

namespace Bp;

public class BpApplicationAutoMapperProfile : Profile
{
    public BpApplicationAutoMapperProfile()
    {
        CreateMap<Post, PostsDto>();
        CreateMap<Region, RegionsDto>();
        CreateMap<PostSalary, PostsSalaryDto>();
    }
}
