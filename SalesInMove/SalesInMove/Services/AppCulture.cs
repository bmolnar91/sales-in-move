using System.Globalization;
namespace SalesInMove.Services
{
    public static class AppCulture
    {
        private static CultureInfo _cultureSetting = new CultureInfo("hu-HU");

        public static CultureInfo GetCultureInfo()
        {
            return _cultureSetting;
        } 
          
    }
}