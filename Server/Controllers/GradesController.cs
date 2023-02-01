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

namespace Server.Controllers
{
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly GradesService gradesService;

        public GradesController()
        {
            this.gradesService = new GradesService();
        }

        [HttpGet]
        [Route("GetGrades")]
        public IEnumerable<Grade> Get()
        {
            return this.gradesService.GetGrades();
        }

        [HttpPost]
        [Route("PostGrades")]
        public bool Post(Grade gradeToAdd)
        {
            return this.gradesService.AddGrade(gradeToAdd);
        }

        [HttpDelete]
        [Route("DeleteGrades")]
        public bool Delete()
        {
            return this.gradesService.RemoveGrades();
        }
    }
}