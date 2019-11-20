using System.Collections.Generic;
using SqlKata.Execution;

namespace DigitalProject.Models
{
    public class Apprenticeship
    {
        public int ApprenticeshipId;

        public string Company;

        public string AppName;

        public int AppLevel;

        public string Location;

        public string Requirements;

        public string Link;

        public int Points;

        public string Success;

        public static IEnumerable<Apprenticeship> GetApprenticeships()
        {
            return DatabaseManager.QueryFactory.Query("Apprenticeships").Get<Apprenticeship>();
        }

        public static IEnumerable<Apprenticeship> GetApprenticeships(string company)
        {
            return DatabaseManager.QueryFactory.Query("Apprenticeships").Where("company", "LIKE", company).Get<Apprenticeship>();
        }

        public static IEnumerable<Apprenticeship> GetApprenticeships(int level)
        {
            return DatabaseManager.QueryFactory.Query("Apprenticeships").Where("applevel", "<", level).Get<Apprenticeship>();
        }

        public static Apprenticeship GetApprenticeship(int id)
        {
            return DatabaseManager.QueryFactory.Query("Apprenticeships").Where("apprenticeshipid", id).FirstOrDefault<Apprenticeship>();
        }
    }
}
