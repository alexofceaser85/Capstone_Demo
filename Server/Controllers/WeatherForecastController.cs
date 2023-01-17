using System.Configuration;
using System.Data.SqlClient;
using CapstoneDemo.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Grade> Get()
        {
            List<Grade> grades = new List<Grade>();
            var query = "select * from Grades";
            using var connection = new System.Data.SqlClient.SqlConnection("Data Source=(localdb)\\projectmodels;Initial Catalog=Database;Integrated Security=True");
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
    }
}