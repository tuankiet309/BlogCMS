using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Models
{
    public class PageResult<T> : PagedResultBase where T: class
    {
        public List<T> Results { get; set; }
        public PageResult() 
        { 
            Results = new List<T>();
        }
    }
}
