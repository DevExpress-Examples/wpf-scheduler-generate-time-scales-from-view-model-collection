Imports System.Windows
Imports System.Windows.Controls
Imports System

Namespace WpfSchedulerTimelineScalesTemplate

    Public Class TimeScaleTemplateSelector
        Inherits DataTemplateSelector

        Public Property DayScaleTemplate As DataTemplate

        Public Property HourScaleTemplate As DataTemplate

        Public Property FixedTimeScaleTemplate As DataTemplate

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim timeScale As TimeScaleViewModel = TryCast(item, TimeScaleViewModel)
            Select Case timeScale.Type
                Case ScaleType.Day
                    Return DayScaleTemplate
                Case ScaleType.Hour
                    Return HourScaleTemplate
                Case ScaleType.FixedTime
                    Return FixedTimeScaleTemplate
                Case Else
                    Throw New NotImplementedException()
            End Select
        End Function
    End Class
End Namespace
