Imports System.Windows
Imports System.Windows.Controls
Imports System

Namespace WpfSchedulerTimelineScalesTemplate
    Public Class TimeScaleTemplateSelector
        Inherits DataTemplateSelector

        Public Property WorkDayScaleTemplate() As DataTemplate
        Public Property WorkHourScaleTemplate() As DataTemplate
        Public Property FixedTimeScaleTemplate() As DataTemplate
        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim timeScale As TimeScaleViewModel = TryCast(item, TimeScaleViewModel)
            Select Case timeScale.Type
                Case ScaleType.WorkDay
                    Return WorkDayScaleTemplate
                Case ScaleType.WorkHour
                    Return WorkHourScaleTemplate
                Case ScaleType.FixedTime
                    Return FixedTimeScaleTemplate
                Case Else
                    Throw New NotImplementedException()
            End Select
        End Function
    End Class
End Namespace
