using Blog.Core.SeedWorks;
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
        public UnitOfWork(BlogContext context)
        {
            this.context = context;
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
