using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapstoneDemo.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Server.Dal;
using Server.Service;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GradesController : ControllerBase
    {
        private readonly GradesService gradesService;

        public GradesController()
        {
            this.gradesService = new GradesService();
        }

        [HttpGet(Name = "GetGrades")]
        public IEnumerable<Grade> Get()
        {
            return this.gradesService.GetGrades();
        }

        [HttpPost(Name = "PostGrades")]
        public bool Post(Grade gradeToAdd)
        {
            return this.gradesService.AddGrade(gradeToAdd);
        }
    }
}