using System.ComponentModel.DataAnnotations;

namespace SalesInMove.Models.JoinTables
{
    public class PositionWorkHourRatio
    {
        [Key]
        public int PositionWorkHourRatioId { get; set; }

        public int PositionId { get; set; }
        
        public int WorkHourId { get; set; }

        public Position Position { get; set; }
        
        public WorkHourRatio WorkHourRatio { get; set; }
    }
}