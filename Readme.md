<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655915/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T591091)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/WpfSchedulerTimelineScalesTemplate/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/WpfSchedulerTimelineScalesTemplate/MainViewModel.vb))
* **[MainWindow.xaml](./CS/WpfSchedulerTimelineScalesTemplate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfSchedulerTimelineScalesTemplate/MainWindow.xaml))**
* [TimeScaleTemplateSelector.cs](./CS/WpfSchedulerTimelineScalesTemplate/TimeScaleTemplateSelector.cs) (VB: [TimeScaleTemplateSelector.vb](./VB/WpfSchedulerTimelineScalesTemplate/TimeScaleTemplateSelector.vb))
<!-- default file list end -->
# How to customize time scales in the Timeline view


This example demonstrates how to specify time scales for the <a href="https://documentation.devexpress.com/WPF/119586/Controls-and-Libraries/Scheduler/Views/Timeline-View">Timeline View</a> using the MVVM architectural pattern. <br>The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScalesSource.property">TimelineView.TimeScalesSource</a> property allows you to bind the Timeline View to a collection of objects containing time scale settings described in the ViewModel. The Timeline View generates time scales based on templates. A template that describes time scales should be assigned to the view's <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScaleTemplate.property">TimelineView.TimeScaleTemplate</a> property. This example uses the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScaleTemplateSelector.property">TimelineView.TimeScaleTemplateSelector</a> property to choose the required template based on the time scale type. Three time scales are generated: Work Day, Work Hour and Half Hour.<br>The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimelineView.TimeScales.property">TimelineView.TimeScales</a> collection stores all time scales of the current Timeline View. You can also use the collection's members to add, modify or remove time scales. <br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-time-scales-in-the-timeline-view-t591091/17.2.3+/media/3811d890-161a-4fe0-bbc6-7823437741b4.png">

<br/>


