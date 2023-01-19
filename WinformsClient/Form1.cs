using System.Collections.Specialized;
using CapstoneDemo.Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using WinFormsClient.Endpoints;
using WinFormsClient.Services;
using WinFormsClient.ViewModel;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private BindingSource gridViewBindingSource;
        private GradesViewModel gradesViewModel;

        public Form1()
        {
            InitializeComponent();
            this.gradesViewModel = new GradesViewModel();
            this.gradesViewModel.CollectionChanged += GradesServiceOnCollectionChanged;
            this.get();
        }

        private void GradesServiceOnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            this.gridViewBindingSource = new BindingSource();
            this.gridViewBindingSource.DataSource = this.gradesViewModel;
            this.gradeGridView.DataSource = this.gridViewBindingSource;
        }

        private void get()
        {
            this.gradesViewModel.GetGrades();
        }

        private void gradeSubmitButton_Click(object sender, EventArgs e)
        {
            this.gradesViewModel.AddGrade(this.gradeNameInput.Text, this.gradeSubjectInput.Text, int.Parse(this.gradeGradeValueInput.Text));
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