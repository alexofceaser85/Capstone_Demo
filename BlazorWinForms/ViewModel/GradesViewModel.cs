using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BlazorWinForms.Services;
using CapstoneDemo.Shared;

namespace BlazorWinForms.ViewModel
{
    public class GradesViewModel : IEnumerable<Grade>, INotifyCollectionChanged
    {
        private readonly GradesService gradesService;

        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public GradesViewModel()
        {
            this.gradesService = new GradesService();
        }

        public ObservableCollection<Grade> GetGrades()
        {
            var newGrades = this.gradesService.GetGrades();
            this.CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            return new ObservableCollection<Grade>(newGrades);
        }

        public void AddGrade(string name, string subject, int amount)
        {
            this.gradesService.AddGrade(name, subject, amount);
            this.GetGrades();
        }

        public IEnumerator<Grade> GetEnumerator()
        {
            return this.gradesService.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
