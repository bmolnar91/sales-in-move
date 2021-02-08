namespace SalesInMove.Models.JoinTables
{
    public class UserCompany
    {
        public int UserId { get; set; }
        
        public int CompanyId { get; set; }

        public User User { get; set; }
        
        public Company Company { get; set; }
    }
}