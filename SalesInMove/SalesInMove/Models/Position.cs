using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesInMove.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        public int WorkHourRatioId { get; set; }

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

        // Hogyan fog kinézni egy napja
         public WorkHourRatio WorkHourRatio { get; set; }

        public Company Company { get; set; }

       


    }
}