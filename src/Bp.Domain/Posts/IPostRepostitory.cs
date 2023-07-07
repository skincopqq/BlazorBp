using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Bp.Posts
{
    public interface IPostRepostitory : IRepository<Post,string>
    {
    }
}
