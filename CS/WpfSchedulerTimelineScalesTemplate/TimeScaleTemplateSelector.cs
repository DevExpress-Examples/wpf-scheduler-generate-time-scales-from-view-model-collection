using System.Windows;
using System.Windows.Controls;
using System;

namespace WpfSchedulerTimelineScalesTemplate {
    public class TimeScaleTemplateSelector : DataTemplateSelector {
        public DataTemplate DayScaleTemplate { get; set; }
        public DataTemplate HourScaleTemplate { get; set; }
        public DataTemplate FixedTimeScaleTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            TimeScaleViewModel timeScale = item as TimeScaleViewModel;
            switch (timeScale.Type) {
                case ScaleType.Day: return DayScaleTemplate;
                case ScaleType.Hour: return HourScaleTemplate;
                case ScaleType.FixedTime: return FixedTimeScaleTemplate;
                default: throw new NotImplementedException();
            }
        }
    }
}
