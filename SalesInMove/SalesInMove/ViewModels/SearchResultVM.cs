using System.Collections.Generic;

namespace SalesInMove.ViewModels
{
    public class SearchResultVM
    {
        public int ResultNumber { get; set; }
        public List<EmployeeSearchVM> Results { get; set; }
    }
}