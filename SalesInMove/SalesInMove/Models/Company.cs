using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesInMove.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string UserId { get; set; }

        public int PositionId { get; set; }

        public IList<string> CompanyProfile { get; set; }

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
        public IList<String> EmployeeOpinions { get; set; }
        
        // Értékesítési támogatást nyújtunk
        public bool SalesSupport { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public User User { get; set; }

        public ICollection<Position> Positions { get; set; }

    }
}