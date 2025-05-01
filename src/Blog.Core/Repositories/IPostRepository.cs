using Blog.Core.Domain.Content;
using Blog.Core.Models;
using Blog.Core.Models.Content;
using Blog.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post,Guid>
    {
       Task<List<Post>> GetPopularPost(int count);
       Task<PageResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);

    }
}
