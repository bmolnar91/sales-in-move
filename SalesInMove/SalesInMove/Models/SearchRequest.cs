using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.Models
{
    public class SearchRequest
    {
        public string Title { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
