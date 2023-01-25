using CapstoneDemo.Shared;
using System.Data;
using Server.Data;

namespace Server.Dal
{
    public static class GradesDal
    {
        public static IEnumerable<Grade> GetGrades()
        {
            List<Grade> grades = new List<Grade>();
            var query = "select * from Grades";
            using var connection = new System.Data.SqlClient.SqlConnection(ApplicationData.SqlConnectionString);
            connection.Open();
            using var command = new System.Data.SqlClient.SqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("Id");
            var nameOrdinal = reader.GetOrdinal("Name");
            var subjectOrdinal = reader.GetOrdinal("Subject");
            var gradeOrdinal = reader.GetOrdinal("GradeAmount");

            while (reader.Read())
            {
                grades.Add(new Grade(
                    reader.GetInt32(idOrdinal),
                    reader.GetString(nameOrdinal),
                    reader.GetString(subjectOrdinal),
                    reader.GetInt32(gradeOrdinal)
                ));
            }

            return grades;
        }

        public static bool AddGrade(Grade gradeToAdd)
        {
            var query = "insert into Grades(Name, Subject, GradeAmount) VALUES (@name, @subject, @gradeAmount)";
            using var connection = new System.Data.SqlClient.SqlConnection(ApplicationData.SqlConnectionString);
            connection.Open();

            using var command = new System.Data.SqlClient.SqlCommand(query, connection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gradeToAdd.Name;
            command.Parameters.Add("@subject", SqlDbType.VarChar).Value = gradeToAdd.Subject;
            command.Parameters.Add("@gradeAmount", SqlDbType.Int).Value = gradeToAdd.GradeAmount;
            return command.ExecuteNonQuery() > 0;
        }

        public static bool RemoveGrades()
        {
            var query = "DELETE FROM [Grades]";
            using var connection = new System.Data.SqlClient.SqlConnection(ApplicationData.SqlConnectionString);
            connection.Open();

            using var command = new System.Data.SqlClient.SqlCommand(query, connection);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
