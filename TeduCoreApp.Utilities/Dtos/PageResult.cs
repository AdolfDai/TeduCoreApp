using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Utilities.Dtos
{
    public class PageResult<T> : PagedResultBase where T : class
    {
        public PageResult()
        {
            Results = new List<T>();

        }
        public IList<T> Results { get; set; }
    }
}

