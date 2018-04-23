using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfSchedulerTimelineScalesTemplate {
    public class MainViewModel {
        public virtual DateTime Start { get; set; }
        public virtual IEnumerable<TeamCalendar> Calendars { get; protected set; }
        public virtual IEnumerable<TeamAppointment> Appointments { get; protected set; }
        public virtual ObservableCollection<TimeScaleViewModel> TimeScales { get; protected set; }

        protected MainViewModel() {
            Start = TeamData.Start;
            Calendars = new ObservableCollection<TeamCalendar>(TeamData.Calendars);
            Appointments = new ObservableCollection<TeamAppointment>(TeamData.AllAppointments);
            CreateTimeScales();
        }

        private void CreateTimeScales() {
            TimeScales = new ObservableCollection<TimeScaleViewModel>();
            AddTimeScale("Work Day", true, ScaleType.WorkDay);
            AddTimeScale("Work Hour", true, ScaleType.WorkHour);
            AddFixedTimeScale("Half Hour", false, new TimeSpan(0, 30, 0));
        }

        private void AddTimeScale(string caption, bool showHeaders, ScaleType type) {
            TimeScaleViewModel timeScale = TimeScaleViewModel.Create();
            timeScale.Caption = caption;
            timeScale.ShowHeaders = showHeaders;
            timeScale.Type = type;
            timeScale.IsEnabled = true;
            TimeScales.Add(timeScale);
        }

        private void AddFixedTimeScale(string caption, bool showHeaders, TimeSpan scale) {
            TimeScaleViewModel timeScale = TimeScaleViewModel.Create();
            timeScale.Caption = caption;
            timeScale.Scale = scale;
            timeScale.ShowHeaders = showHeaders;
            timeScale.Type = ScaleType.FixedTime;
            timeScale.IsEnabled = true;
            TimeScales.Add(timeScale);
        }
    }

    public enum ScaleType { WorkDay, WorkHour, FixedTime }

    public class TimeScaleViewModel {
        public static TimeScaleViewModel Create() {
            return ViewModelSource.Create(() => new TimeScaleViewModel());
        }
        protected TimeScaleViewModel() { }
        public virtual string Caption { get; set; }
        public virtual bool ShowHeaders { get; set; }
        public virtual bool IsEnabled { get; set; }
        public virtual TimeSpan Scale { get; set; }
        public ScaleType Type { get; set; }
    }
}
