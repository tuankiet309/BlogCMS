using AutoMapper;
using Blog.Core.Repositories;
using Blog.Core.SeedWorks;
using Blog.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext context;
        public IPostRepository Posts { get; private set; }

        public IPostCategoryRepository PostCategories { get; private set; }

        public UnitOfWork(BlogContext context, IMapper mapper)
        {
            this.context = context;
            Posts = new PostRepository(context, mapper);
            PostCategories = new PostCategoryRepository(context, mapper);
        }


        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }
        public void Dispose() 
        {
            context.Dispose();
        }
    }
}
