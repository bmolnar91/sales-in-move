using SalesInMove.Models;

namespace SalesInMove.Services
{
    public interface IEmployeeFactory
    {
        Employee CreateEntity
        (
            int userType, string emailAddress, string password, string firstName,
            string lastName, string jobTitle, string education, string[] languages,
            string birthDate, int turnoverLastYear, string profilePicture, string profileVideo,
            bool isSubscribed, bool hasPersonalityTest, int age, string city, bool drivingLicence,
            bool salesCourseSubscription, int salesTurnOver, string Specialisation, string previousCompany,
            string[] otherCertificates, string[] pros, string[] cons, string[] progressionIntensions,
            string Motto
        );
    }
}