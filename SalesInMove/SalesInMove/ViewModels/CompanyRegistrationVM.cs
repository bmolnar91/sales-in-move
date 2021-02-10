namespace SalesInMove.ViewModels
{
    public class CompanyRegistrationVM : AbstractUserVM
    {
        public string companyName { get; set; }
        public string[] CompanyProfile { get; set; }
        public string Headquarter { get; set; }
        public long TaxNumber { get; set; }
        public long Registry { get; set; }
        public string YearOfFoundation { get; set; }
        public int NumberOfSalesman { get; set; }
        public string Sector { get; set; }
        public long AnnualNettoIncome { get; set; }
        public bool SalesSupport { get; set; }
        public string[] EmployeeOpinions { get; set; }
    }
}