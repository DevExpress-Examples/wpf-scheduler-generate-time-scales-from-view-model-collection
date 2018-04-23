Imports DevExpress.Mvvm.POCO
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace WpfSchedulerTimelineScalesTemplate
    Public Class MainViewModel
        Public Overridable Property Start() As Date
        Private privateCalendars As IEnumerable(Of TeamCalendar)
        Public Overridable Property Calendars() As IEnumerable(Of TeamCalendar)
            Get
                Return privateCalendars
            End Get
            Protected Set(ByVal value As IEnumerable(Of TeamCalendar))
                privateCalendars = value
            End Set
        End Property
        Private privateAppointments As IEnumerable(Of TeamAppointment)
        Public Overridable Property Appointments() As IEnumerable(Of TeamAppointment)
            Get
                Return privateAppointments
            End Get
            Protected Set(ByVal value As IEnumerable(Of TeamAppointment))
                privateAppointments = value
            End Set
        End Property
        Private privateTimeScales As ObservableCollection(Of TimeScaleViewModel)
        Public Overridable Property TimeScales() As ObservableCollection(Of TimeScaleViewModel)
            Get
                Return privateTimeScales
            End Get
            Protected Set(ByVal value As ObservableCollection(Of TimeScaleViewModel))
                privateTimeScales = value
            End Set
        End Property

        Protected Sub New()
            Start = TeamData.Start
            Calendars = New ObservableCollection(Of TeamCalendar)(TeamData.Calendars)
            Appointments = New ObservableCollection(Of TeamAppointment)(TeamData.AllAppointments)
            CreateTimeScales()
        End Sub

        Private Sub CreateTimeScales()
            TimeScales = New ObservableCollection(Of TimeScaleViewModel)()
            AddTimeScale("Work Day", True, ScaleType.WorkDay)
            AddTimeScale("Work Hour", True, ScaleType.WorkHour)
            AddFixedTimeScale("Half Hour", False, New TimeSpan(0, 30, 0))
        End Sub

        Private Sub AddTimeScale(ByVal caption As String, ByVal showHeaders As Boolean, ByVal type As ScaleType)
            Dim timeScale As TimeScaleViewModel = TimeScaleViewModel.Create()
            timeScale.Caption = caption
            timeScale.ShowHeaders = showHeaders
            timeScale.Type = type
            timeScale.IsEnabled = True
            TimeScales.Add(timeScale)
        End Sub

        Private Sub AddFixedTimeScale(ByVal caption As String, ByVal showHeaders As Boolean, ByVal scale As TimeSpan)
            Dim timeScale As TimeScaleViewModel = TimeScaleViewModel.Create()
            timeScale.Caption = caption
            timeScale.Scale = scale
            timeScale.ShowHeaders = showHeaders
            timeScale.Type = ScaleType.FixedTime
            timeScale.IsEnabled = True
            TimeScales.Add(timeScale)
        End Sub
    End Class

    Public Enum ScaleType
        WorkDay
        WorkHour
        FixedTime
    End Enum

    Public Class TimeScaleViewModel
        Public Shared Function Create() As TimeScaleViewModel
            Return ViewModelSource.Create(Function() New TimeScaleViewModel())
        End Function
        Protected Sub New()
        End Sub
        Public Overridable Property Caption() As String
        Public Overridable Property ShowHeaders() As Boolean
        Public Overridable Property IsEnabled() As Boolean
        Public Overridable Property Scale() As TimeSpan
        Public Property Type() As ScaleType
    End Class
End Namespace
