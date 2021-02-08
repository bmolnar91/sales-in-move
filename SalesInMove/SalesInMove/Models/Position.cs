using SalesInMove.Models.JoinTables;
using System.ComponentModel.DataAnnotations;

namespace SalesInMove.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        public int CompanyPositionId { get; set; }
        
        public int PositionWorkHourRatioId { get; set; }

        public string Name { get; set; }
        
        public string City { get; set; }
        
        public string Description { get; set; }
        
        // Milyen nelegyen a munkavállaló
        public string Expectations { get; set; }

        // Közvetlen vezetőm kérései/evlárásai
        public string BossExpectations { get; set; }

        // Munkaidő
        public string WorkHour { get; set; }

        public string Wages { get; set; }
        
        // Egyéb juttatások
        public string OtherBenefits { get; set; }

        // Továbbképzési támogatás
        public bool ProgressionSupport { get; set; }

        public CompanyPosition CompanyPosition { get; set; }


    }
}