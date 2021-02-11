using System;
using SalesInMove.Models;

namespace SalesInMove.Services
{
    public class EmployeeFactory : UserFactory, IEmployeeFactory
    {
        public Employee CreateRegisterEntity(string email, string firstName, string lastName, string password)
        {
            User newUser = base.CreateUser(1,email, password);
            
            return new Employee
            {
                User = newUser
            };
        }

        public Employee CreateEntity(
            int userType, string emailAddress, string password, string firstName, 
            string lastName, string jobTitle, string education, string[] languages, 
            string birthDate, int turnoverLastYear, string profilePicture, string profileVideo, 
            bool isSubscribed, bool hasPersonalityTest, int age, string city, 
            bool drivingLicence, bool salesCourseSubscription, int salesTurnOver, 
            string specialisation, string previousCompany, string[] otherCertificates, 
            string[] pros, string[] cons, string[] progressionIntensions, string motto
            )
        {
            User newUser = base.CreateUser(userType, emailAddress, password);

            DateTime birth = DateTime.Parse(birthDate, AppCulture.GetCultureInfo());

            Employee newEmployee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                JobTitle = jobTitle,
                Education = education,
                Languages = languages,
                BirthDate = birth,
                TurnoverLastYear = turnoverLastYear,
                ProfilePicture = profilePicture,
                ProfileVideo = profileVideo,
                IsSubscribed = isSubscribed,
                DrivingLicence = drivingLicence,
                SalesCourseSubscription = salesCourseSubscription,
                SalesTurnOver = salesTurnOver,
                Specialisation = specialisation,
                PreviousCompany = previousCompany,
                OtherCertificates = otherCertificates,
                Pros = pros,
                Cons = cons,
                ProgressionIntetions = progressionIntensions,
                Motto = motto,
                User = newUser
            };

            return newEmployee;
        }

    }
}