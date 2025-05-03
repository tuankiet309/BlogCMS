using Blog.Core.Domain.Royalty;
using Blog.Core.Models;
using Blog.Core.Models.Royalty;
using Blog.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction,Guid>
    {
        Task<PageResult<TransactionDto>> GetAllPaging(string? userName,
                 int fromMonth, int fromYear, int toMonth, int toYear, int pageIndex = 1, int pageSize = 10);
    }
}
