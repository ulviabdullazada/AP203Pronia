using System.Collections.Generic;

namespace Geco.ViewModels
{
    public class PaginationVM<T>
    {
        public List<T> Items{ get; set; }
        public int PageCount { get; set; }
        public int ActivePage { get; set; }
    }
}
