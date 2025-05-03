using Blog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; } 
        IPostCategoryRepository PostCategories { get; }
        ISeriesRepository Series { get; }

        ITransactionRepository Transactions { get; }
        Task<int> CompleteAsync();
    }
}
