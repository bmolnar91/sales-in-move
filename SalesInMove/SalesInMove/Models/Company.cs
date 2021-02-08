using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using SalesInMove.Models.JoinTables;

namespace SalesInMove.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public int UserId { get; set; }

        public IList<int> CompanyPositionIds { get; set; }

        public string Name { get; set; }
        
        public string Headquarter { get; set; }
        
        [MaxLength(11)]
        public long TaxNumber { get; set; }
        
        // Cégjegyzék
        public long Registry { get; set; }

        public DateTime? YearOfFoundation { get; set; }
        
        public int NumberOfSalesman { get; set; }
        
        public string Sector { get; set; }
        
        public long AnnualNettoIncome { get; set; }

        // Munkavállalóink írták
        public IList<string>  EmployeeOpinions { get; set; }
        
        // Értékesítési támogatást nyújtunk
        public bool SalesSupport { get; set; }

        public UserCompany UserCompany { get; set; }

        public IList<CompanyPosition> CompanyPositions { get; set; }
    }
}