using System.ComponentModel.DataAnnotations;

namespace SalesInMove.Models.JoinTables
{
    public class CompanyPosition
    {
        [Key]
        public int CompanyPositionId { get; set; }

        public int CompanyId { get; set; }
        
        public int PositionId { get; set; }

        public Company Company { get; set; }
        
        public Position Position { get; set; }
    }
}