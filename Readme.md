<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655915/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T591091)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Scheduler - Generate Time Scales From a View Model Collection

This example generates [Time Scales](https://docs.devexpress.com/WPF/119586/controls-and-libraries/scheduler/views/timeline-view#time-scales) from a collection. The [TimelineView.TimeScalesSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScalesSource) property specifies the collection of objects that describe time scale elements. The [TimelineView.TimeScaleTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScaleTemplate) property allows you to define a data template used to generate time scales. The example uses the [TimelineView.TimeScaleTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScaleTemplateSelector) property to choose a template based on the time scale type and generates the following time scales: **Day**, **Hour**, and **Half Hour**.

The [TimelineView.TimeScales](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScales) collection stores all time scales. You can also use collection members to add, modify, or remove time scales.

![image](https://github.com/DevExpress-Examples/how-to-customize-time-scales-in-the-timeline-view-t591091/assets/65009440/1b5911f5-91e8-43ba-9d94-323211a84368)

## Files to Review

* [MainWindow.xaml](./CS/WpfSchedulerTimelineScalesTemplate/MainWindow.xaml)
* [MainViewModel.cs](./CS/WpfSchedulerTimelineScalesTemplate/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/WpfSchedulerTimelineScalesTemplate/MainViewModel.vb))
* [TimeScaleTemplateSelector.cs](./CS/WpfSchedulerTimelineScalesTemplate/TimeScaleTemplateSelector.cs) (VB: [TimeScaleTemplateSelector.vb](./VB/WpfSchedulerTimelineScalesTemplate/TimeScaleTemplateSelector.vb))

## Documentation

* [Timeline View](https://docs.devexpress.com/WPF/119586/controls-and-libraries/scheduler/views/timeline-view)
* [TimelineView.TimeScalesSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScalesSource)
* [TimelineView.TimeScaleTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScaleTemplate)

## More Examples

* [WPF Scheduler - Generate Time Rulers From a View Model Collection](https://github.com/DevExpress-Examples/wpf-scheduler-generate-time-rulers-from-view-model-collection)
