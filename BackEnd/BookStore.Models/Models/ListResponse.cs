using BookStore.Models.ViewModels;
using System.Collections.Generic;

namespace BookStore.Models.Models
{
    public class ListResponse<T> where T : class
    {
        public IEnumerable<T> results { get; set; }

        public int TotalRecords { get; set; }
    }
}
