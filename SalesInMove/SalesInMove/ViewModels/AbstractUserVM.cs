namespace SalesInMove.ViewModels
{
    public abstract class AbstractUserVM
    {
        public byte UserType {get; set;}
        public string Email { get; set; }
        public string Password { get; set; }
    }
}