using SalesInMove.Models.JoinTables;
using System.ComponentModel.DataAnnotations;

namespace SalesInMove.Models
{
    public class WorkHourRatio
    {
        [Key]
        public int WorkHourRatioId { get; set; }
        
        public int PositionWorkHourRatioId { get; set; }

        public ushort WorkHoursPerMonth { get; set; }

        public byte OfficeHours { get; set; }
        
        public byte HomeOfficeHours { get; set; }
        
        public byte DrivingHours { get; set; }

        public PositionWorkHourRatio PositionWorkHourRatio { get; set; }
    }
}