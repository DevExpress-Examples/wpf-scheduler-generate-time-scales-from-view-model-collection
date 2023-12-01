Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace WpfSchedulerTimelineScalesTemplate

    Public Class MainViewModel
        Inherits ViewModelBase

        Private _Calendars As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamCalendar), _Appointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _TimeScales As ObservableCollection(Of WpfSchedulerTimelineScalesTemplate.TimeScaleViewModel)

        Public Property Start As Date

        Public Property Calendars As IEnumerable(Of TeamCalendar)
            Get
                Return _Calendars
            End Get

            Protected Set(ByVal value As IEnumerable(Of TeamCalendar))
                _Calendars = value
            End Set
        End Property

        Public Property Appointments As IEnumerable(Of TeamAppointment)
            Get
                Return _Appointments
            End Get

            Protected Set(ByVal value As IEnumerable(Of TeamAppointment))
                _Appointments = value
            End Set
        End Property

        Public Property TimeScales As ObservableCollection(Of TimeScaleViewModel)
            Get
                Return _TimeScales
            End Get

            Protected Set(ByVal value As ObservableCollection(Of TimeScaleViewModel))
                _TimeScales = value
            End Set
        End Property

        Public Sub New()
            Start = TeamData.Start
            Calendars = New ObservableCollection(Of TeamCalendar)(TeamData.Calendars)
            Appointments = New ObservableCollection(Of TeamAppointment)(AllAppointments)
            CreateTimeScales()
        End Sub

        Private Sub CreateTimeScales()
            TimeScales = New ObservableCollection(Of TimeScaleViewModel)()
            AddTimeScale("Day", True, ScaleType.Day)
            AddTimeScale("Hour", True, ScaleType.Hour)
            AddFixedTimeScale("Half Hour", False, New TimeSpan(0, 30, 0))
        End Sub

        Private Sub AddTimeScale(ByVal caption As String, ByVal showHeaders As Boolean, ByVal type As ScaleType)
            Dim timeScale As TimeScaleViewModel = New TimeScaleViewModel()
            timeScale.Caption = caption
            timeScale.ShowHeaders = showHeaders
            timeScale.Type = type
            timeScale.IsEnabled = True
            TimeScales.Add(timeScale)
        End Sub

        Private Sub AddFixedTimeScale(ByVal caption As String, ByVal showHeaders As Boolean, ByVal scale As TimeSpan)
            Dim timeScale As TimeScaleViewModel = New TimeScaleViewModel()
            timeScale.Caption = caption
            timeScale.Scale = scale
            timeScale.ShowHeaders = showHeaders
            timeScale.Type = ScaleType.FixedTime
            timeScale.IsEnabled = True
            TimeScales.Add(timeScale)
        End Sub
    End Class

    Public Enum ScaleType
        Day
        Hour
        FixedTime
    End Enum

    Public Class TimeScaleViewModel
        Inherits BindableBase

        Public Property Caption As String

        Public Property ShowHeaders As Boolean

        Public Property IsEnabled As Boolean

        Public Property Scale As TimeSpan

        Public Property Type As ScaleType
    End Class
End Namespace
