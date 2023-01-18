using CapstoneDemo.Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using WinFormsClient.Endpoints;
using WinFormsClient.Services;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private GradesService gradesService;
        private Grade[]? forecasts;

        public Form1()
        {
            InitializeComponent();
            this.gradesService = new GradesService();
            this.get();
        }

        private void get()
        {
            this.forecasts = this.gradesService.GetGrades();
            this.gradeGridView.DataSource = this.forecasts;
        }

        private void gradeSubmitButton_Click(object sender, EventArgs e)
        {
            this.gradesService.AddGrade(this.gradeNameInput.Text, this.gradeSubjectInput.Text, int.Parse(this.gradeGradeValueInput.Text));
            this.get();
            this.clearSubmitFields();
        }

        private void clearSubmitFields()
        {
            this.gradeNameInput.Clear();
            this.gradeSubjectInput.Clear();
            this.gradeGradeValueInput.Clear();
        }
    }
}