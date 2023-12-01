using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfSchedulerTimelineScalesTemplate {
    public class MainViewModel : ViewModelBase {
        public DateTime Start { get; set; }
        public IEnumerable<TeamCalendar> Calendars { get; protected set; }
        public IEnumerable<TeamAppointment> Appointments { get; protected set; }
        public ObservableCollection<TimeScaleViewModel> TimeScales { get; protected set; }

        public MainViewModel() {
            Start = TeamData.Start;
            Calendars = new ObservableCollection<TeamCalendar>(TeamData.Calendars);
            Appointments = new ObservableCollection<TeamAppointment>(TeamData.AllAppointments);
            CreateTimeScales();
        }

        private void CreateTimeScales() {
            TimeScales = new ObservableCollection<TimeScaleViewModel>();
            AddTimeScale("Day", true, ScaleType.Day);
            AddTimeScale("Hour", true, ScaleType.Hour);
            AddFixedTimeScale("Half Hour", false, new TimeSpan(0, 30, 0));
        }

        private void AddTimeScale(string caption, bool showHeaders, ScaleType type) {
            TimeScaleViewModel timeScale = new TimeScaleViewModel();
            timeScale.Caption = caption;
            timeScale.ShowHeaders = showHeaders;
            timeScale.Type = type;
            timeScale.IsEnabled = true;
            TimeScales.Add(timeScale);
        }

        private void AddFixedTimeScale(string caption, bool showHeaders, TimeSpan scale) {
            TimeScaleViewModel timeScale = new TimeScaleViewModel();
            timeScale.Caption = caption;
            timeScale.Scale = scale;
            timeScale.ShowHeaders = showHeaders;
            timeScale.Type = ScaleType.FixedTime;
            timeScale.IsEnabled = true;
            TimeScales.Add(timeScale);
        }
    }

    public enum ScaleType { Day, Hour, FixedTime }

    public class TimeScaleViewModel : BindableBase {
        public string Caption { get; set; }
        public bool ShowHeaders { get; set; }
        public bool IsEnabled { get; set; }
        public TimeSpan Scale { get; set; }
        public ScaleType Type { get; set; }
    }
}
