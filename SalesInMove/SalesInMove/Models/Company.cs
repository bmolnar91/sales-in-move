using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace SalesInMove.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Headquarter { get; set; }
        
        [MaxLength(11)]
        public int TaxNumber { get; set; }
        
        // Cégjegyzék
        public int Registry { get; set; }

        public DateTime? YearOfFoundation { get; set; }
        
        public int NumberOfSalesman { get; set; }
        
        public string Sector { get; set; }
        
        public long AnnualNettoIncome { get; set; }

        // Munkavállalóink írták
        public IList<string>  EmployeeOpinions { get; set; }
        
        // Értékesítési támogatást nyújtunk
        public bool SalesSupport { get; set; }
    }
}