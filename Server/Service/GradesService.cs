using CapstoneDemo.Shared;
using Server.Dal;

namespace Server.Service
{
    public class GradesService
    {
        public IEnumerable<Grade> GetGrades()
        {
            return GradesDal.GetGrades();
        }

        public bool AddGrade(Grade gradeToAdd)
        {
            return GradesDal.AddGrade(gradeToAdd);
        }

        public bool RemoveGrades()
        {
            return GradesDal.RemoveGrades();
        }
    }
}
