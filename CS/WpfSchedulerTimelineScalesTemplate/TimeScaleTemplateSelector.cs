using System.Windows;
using System.Windows.Controls;
using System;

namespace WpfSchedulerTimelineScalesTemplate {
    public class TimeScaleTemplateSelector : DataTemplateSelector {
        public DataTemplate WorkDayScaleTemplate { get; set; }
        public DataTemplate WorkHourScaleTemplate { get; set; }
        public DataTemplate FixedTimeScaleTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            TimeScaleViewModel timeScale = item as TimeScaleViewModel;
            switch (timeScale.Type) {
                case ScaleType.WorkDay: return WorkDayScaleTemplate;
                case ScaleType.WorkHour: return WorkHourScaleTemplate;
                case ScaleType.FixedTime: return FixedTimeScaleTemplate;
                default: throw new NotImplementedException();
            }
        }
    }
}
