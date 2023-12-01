Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.XtraScheduler

Namespace WpfSchedulerTimelineScalesTemplate

    Public Class TeamCalendar

        Public Property Id As Integer

        Public Property Name As String
    End Class

    Public Class TeamAppointment

        Public Property Id As Integer

        Public Property AppointmentType As Integer

        Public Property AllDay As Boolean

        Public Property Start As DateTime

        Public Property [End] As DateTime

        Public Property Subject As String

        Public Property Description As String

        Public Property Status As Integer

        Public Property Label As Integer

        Public Property Location As String

        Public Property CalendarId As Integer

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String
    End Class

    Public Class Employee

        Public Property FirstName As String

        Public Property LastName As String

        Public Property BirthDate As System.DateTime?
    End Class

    Public Module TeamData

        Private _Start As DateTime, _Calendars As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamCalendar), _AllAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _VacationAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _BirthdayAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _ConferenceAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _MeetingAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _PhoneCallsAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _CarWashAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _CompanyBirthdayAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _TrainingAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _PayBillsAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _DentistAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment), _RestaurantAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)

        Sub New()
            WpfSchedulerTimelineScalesTemplate.TeamData.Random = New System.Random()
            WpfSchedulerTimelineScalesTemplate.TeamData.Start = WpfSchedulerTimelineScalesTemplate.TeamData.GetStart()
            If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then
                WpfSchedulerTimelineScalesTemplate.TeamData.Employees = New System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.Employee)()
                WpfSchedulerTimelineScalesTemplate.TeamData.Calendars = WpfSchedulerTimelineScalesTemplate.TeamData.CreateCalendars().ToList()
                WpfSchedulerTimelineScalesTemplate.TeamData.VacationAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.CompanyBirthdayAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.BirthdayAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.ConferenceAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.MeetingAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.PhoneCallsAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.CarWashAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.PayBillsAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.DentistAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.RestaurantAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                WpfSchedulerTimelineScalesTemplate.TeamData.AllAppointments = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() {}
                Return
            End If

            WpfSchedulerTimelineScalesTemplate.TeamData.Employees = New System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.Employee)()
            Call WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Add(New WpfSchedulerTimelineScalesTemplate.Employee() With {.FirstName = "Andrew", .LastName = "Glover"})
            Call WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Add(New WpfSchedulerTimelineScalesTemplate.Employee() With {.FirstName = "Mark", .LastName = "Oliver"})
            Call WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Add(New WpfSchedulerTimelineScalesTemplate.Employee() With {.FirstName = "John", .LastName = "Heart"})
            Call WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Add(New WpfSchedulerTimelineScalesTemplate.Employee() With {.FirstName = "Olivia", .LastName = "Peyton"})
            Call WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Add(New WpfSchedulerTimelineScalesTemplate.Employee() With {.FirstName = "Sandra", .LastName = "Johnson"})
            Call WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Add(New WpfSchedulerTimelineScalesTemplate.Employee() With {.FirstName = "Amelia", .LastName = "Harper"})
            WpfSchedulerTimelineScalesTemplate.TeamData.Employees(CInt((0))).BirthDate = WpfSchedulerTimelineScalesTemplate.TeamData.Start.AddDays(CDbl((4))).AddYears(-30)
            WpfSchedulerTimelineScalesTemplate.TeamData.Employees(CInt((1))).BirthDate = WpfSchedulerTimelineScalesTemplate.TeamData.Start.AddDays(CDbl((1))).AddYears(-27)
            WpfSchedulerTimelineScalesTemplate.TeamData.Employees(CInt((2))).BirthDate = WpfSchedulerTimelineScalesTemplate.TeamData.Start.AddDays(CDbl((14))).AddYears(-32)
            WpfSchedulerTimelineScalesTemplate.TeamData.Employees(CInt((3))).BirthDate = WpfSchedulerTimelineScalesTemplate.TeamData.Start.AddDays(CDbl((-8))).AddYears(-41)
            WpfSchedulerTimelineScalesTemplate.TeamData.Employees(CInt((4))).BirthDate = WpfSchedulerTimelineScalesTemplate.TeamData.Start.AddDays(CDbl((-18))).AddYears(-41)
            WpfSchedulerTimelineScalesTemplate.TeamData.Employees(CInt((5))).BirthDate = WpfSchedulerTimelineScalesTemplate.TeamData.Start.AddDays(CDbl((48))).AddYears(-25)
            WpfSchedulerTimelineScalesTemplate.TeamData.Calendars = WpfSchedulerTimelineScalesTemplate.TeamData.CreateCalendars().ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.VacationAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateVacationsAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.CompanyBirthdayAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateCompanyBirthdayAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.BirthdayAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateBirthdayAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.ConferenceAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateConferenceAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.MeetingAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateMeetingAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.PhoneCallsAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallsAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.CarWashAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateCarWashAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.TrainingAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateTrainingAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.PayBillsAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreatePayBillsAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.DentistAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateDentistAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.RestaurantAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.CreateRestaurantAppts(WpfSchedulerTimelineScalesTemplate.TeamData.Start).ToList()
            WpfSchedulerTimelineScalesTemplate.TeamData.AllAppointments = WpfSchedulerTimelineScalesTemplate.TeamData.VacationAppointments.Concat(WpfSchedulerTimelineScalesTemplate.TeamData.BirthdayAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.CompanyBirthdayAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.ConferenceAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.MeetingAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.PhoneCallsAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.CarWashAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.TrainingAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.PayBillsAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.DentistAppointments).Concat(WpfSchedulerTimelineScalesTemplate.TeamData.RestaurantAppointments).ToList()
            Dim id As Integer = 0
            For Each appt As WpfSchedulerTimelineScalesTemplate.TeamAppointment In WpfSchedulerTimelineScalesTemplate.TeamData.AllAppointments
                appt.Id = System.Math.Min(System.Threading.Interlocked.Increment(id), id - 1)
            Next
        End Sub

        Public Property Start As DateTime
            Get
                Return _Start
            End Get

            Private Set(ByVal value As DateTime)
                _Start = value
            End Set
        End Property

        Public Property Calendars As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamCalendar)
            Get
                Return _Calendars
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamCalendar))
                _Calendars = value
            End Set
        End Property

        Public ReadOnly Property MyCalendar As TeamCalendar
            Get
                Return WpfSchedulerTimelineScalesTemplate.TeamData.Calendars.ElementAt(0)
            End Get
        End Property

        Public ReadOnly Property TeamCalendar As TeamCalendar
            Get
                Return WpfSchedulerTimelineScalesTemplate.TeamData.Calendars.ElementAt(1)
            End Get
        End Property

        Public Property AllAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _AllAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _AllAppointments = value
            End Set
        End Property

        Public Property VacationAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _VacationAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _VacationAppointments = value
            End Set
        End Property

        Public Property BirthdayAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _BirthdayAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _BirthdayAppointments = value
            End Set
        End Property

        Public Property ConferenceAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _ConferenceAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _ConferenceAppointments = value
            End Set
        End Property

        Public Property MeetingAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _MeetingAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _MeetingAppointments = value
            End Set
        End Property

        Public Property PhoneCallsAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _PhoneCallsAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _PhoneCallsAppointments = value
            End Set
        End Property

        Public Property CarWashAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _CarWashAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _CarWashAppointments = value
            End Set
        End Property

        Public Property CompanyBirthdayAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _CompanyBirthdayAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _CompanyBirthdayAppointments = value
            End Set
        End Property

        Public Property TrainingAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _TrainingAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _TrainingAppointments = value
            End Set
        End Property

        Public Property PayBillsAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _PayBillsAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _PayBillsAppointments = value
            End Set
        End Property

        Public Property DentistAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _DentistAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _DentistAppointments = value
            End Set
        End Property

        Public Property RestaurantAppointments As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Get
                Return _RestaurantAppointments
            End Get

            Private Set(ByVal value As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment))
                _RestaurantAppointments = value
            End Set
        End Property

        Private ReadOnly Employees As System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.Employee)

        Private ReadOnly Random As System.Random

        Private Function GetStart() As DateTime
            Dim today As System.DateTime = System.DateTime.Today
            Dim dayOfWeek As System.DayOfWeek = today.DayOfWeek
            If dayOfWeek = System.DayOfWeek.Monday Then Return today
            If dayOfWeek = System.DayOfWeek.Sunday Then Return today.AddDays(1)
            Return today.AddDays(-(CInt(dayOfWeek) - 1))
        End Function

        Private Function GetRandomEmployee() As Employee
            Return WpfSchedulerTimelineScalesTemplate.TeamData.Employees(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](0, WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Count))
        End Function

        Private Function CreateCalendars() As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamCalendar)
            Return New WpfSchedulerTimelineScalesTemplate.TeamCalendar() {New WpfSchedulerTimelineScalesTemplate.TeamCalendar() With {.Id = 0, .Name = "My Calendar"}, New WpfSchedulerTimelineScalesTemplate.TeamCalendar() With {.Id = 1, .Name = "Team Calendar"}}
        End Function

        Private Function CreateBirthdayAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Return WpfSchedulerTimelineScalesTemplate.TeamData.Employees.[Select](New Global.System.Func(Of Global.WpfSchedulerTimelineScalesTemplate.Employee, Global.WpfSchedulerTimelineScalesTemplate.TeamAppointment)(AddressOf WpfSchedulerTimelineScalesTemplate.TeamData.CreateBirthdayAppt))
        End Function

        Private Function CreateBirthdayAppt(ByVal employee As WpfSchedulerTimelineScalesTemplate.Employee) As TeamAppointment
            If employee.BirthDate Is Nothing Then Return Nothing
            Dim [date] As System.DateTime = employee.BirthDate.Value
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Pattern), .AllDay = True, .Start = [date], .[End] = [date].AddDays(1), .Subject = String.Format("{0}'s Birthday", employee.FirstName), .Status = 0, .Label = 8, .CalendarId = 0}
            appt.RecurrenceInfo = New DevExpress.XtraScheduler.RecurrenceInfo() With {.AllDay = True, .Start = [date], .Month = [date].Month, .DayNumber = [date].Day, .WeekOfMonth = DevExpress.XtraScheduler.WeekOfMonth.None, .Type = DevExpress.XtraScheduler.RecurrenceType.Yearly, .Range = DevExpress.XtraScheduler.RecurrenceRange.NoEndDate}.ToXml()
            Return appt
        End Function

        Private Function CreateConferenceAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim newStart As System.DateTime = start
            Dim thisWeekList As System.Tuple(Of String, System.DateTime)() = {System.Tuple.Create("DevExpress MVVM Framework", newStart.AddDays(CDbl((1))).AddHours(15)), System.Tuple.Create("New Theme Designer", newStart.AddDays(CDbl((2))).AddHours(14)), System.Tuple.Create("GridControl Performance Optimization", newStart.AddDays(CDbl((3))).AddHours(16)), System.Tuple.Create("WinForms and DirectX", newStart.AddDays(CDbl((4))).AddHours(16))}
            newStart = start.AddDays(-7)
            Dim prevWeekList As System.Tuple(Of String, System.DateTime)() = {System.Tuple.Create("LOB applications", newStart.AddDays(CDbl((1))).AddHours(13)), System.Tuple.Create("Module Injection Framework", newStart.AddDays(CDbl((2))).AddHours(16)), System.Tuple.Create("Git tricks", newStart.AddDays(CDbl((3))).AddHours(10)), System.Tuple.Create("Machine learning", newStart.AddDays(CDbl((4))).AddHours(11))}
            newStart = start.AddDays(7)
            Dim nextWeekList As System.Tuple(Of String, System.DateTime)() = {System.Tuple.Create("Azure", newStart.AddDays(CDbl((1))).AddHours(13)), System.Tuple.Create("WCF Services", newStart.AddDays(CDbl((2))).AddHours(16)), System.Tuple.Create("Docking Floating Panels", newStart.AddDays(CDbl((3))).AddHours(10)), System.Tuple.Create("Personal Time Management", newStart.AddDays(CDbl((4))).AddHours(11))}
            newStart = start.AddDays(14)
            Dim nextNextWeekList As System.Tuple(Of String, System.DateTime)() = {System.Tuple.Create("Entity Framework Core", newStart.AddDays(CDbl((1))).AddHours(10)), System.Tuple.Create(".Net Core", newStart.AddDays(CDbl((2))).AddHours(16))}
            Dim list As System.Collections.Generic.IEnumerable(Of System.Tuple(Of String, System.DateTime)) = thisWeekList.Concat(prevWeekList).Concat(nextWeekList).Concat(nextNextWeekList)
            Dim commonList As System.Collections.Generic.List(Of System.Tuple(Of String, System.DateTime)) = New System.Collections.Generic.List(Of System.Tuple(Of String, System.DateTime))()
            Dim interval As DevExpress.Mvvm.DateTimeRange = New DevExpress.Mvvm.DateTimeRange(start.AddDays(-7), start.AddDays(21))
            Dim subjects As System.Collections.Generic.IEnumerable(Of String) = list.[Select](Function(x) x.Item1)
            For i As Integer = 0 To 100 - 1
                newStart = start.AddYears(-1)
                newStart = newStart.AddDays(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](2 * 365))
                newStart = newStart.AddHours(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](9, 18))
                If interval.Start <= newStart AndAlso interval.[End] >= newStart Then Continue For
                Dim subj As String = subjects.ElementAt(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](0, subjects.Count()))
                commonList.Add(System.Tuple.Create(subj, newStart))
            Next

            Return list.Concat(commonList).[Select](Function(x) WpfSchedulerTimelineScalesTemplate.TeamData.CreateConferenceAppt(x.Item1, x.Item2))
        End Function

        Private Function CreateConferenceAppt(ByVal subject As String, ByVal start As System.DateTime) As TeamAppointment
            Dim emp As WpfSchedulerTimelineScalesTemplate.Employee = WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee()
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = False, .Start = start, .[End] = start.AddHours(1.5), .Subject = String.Format("Conference: {0}", subject), .Description = String.Format("{0} {1} tells us about {2}.", emp.FirstName, emp.LastName, subject), .Status = 2, .Label = 2, .Location = "Conference Room", .CalendarId = 1}
            Return appt
        End Function

        Private Function CreateMeetingAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim res As System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment) = New System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)() From {WpfSchedulerTimelineScalesTemplate.TeamData.CreateMeetingRecurrenceAppt("Weekly meeting", start.AddMonths(CInt((-6))).Add(New System.TimeSpan(5, 14, 00, 0))), WpfSchedulerTimelineScalesTemplate.TeamData.CreateLunchAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(0), start.AddDays(CDbl((1))).AddHours(13)), WpfSchedulerTimelineScalesTemplate.TeamData.CreateLunchAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(1), start.AddDays(CDbl((3))).AddHours(13)), WpfSchedulerTimelineScalesTemplate.TeamData.CreateLunchAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(2), start.AddDays(CDbl((-4))).AddHours(13)), WpfSchedulerTimelineScalesTemplate.TeamData.CreateLunchAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(3), start.AddDays(CDbl((9))).AddHours(13)), WpfSchedulerTimelineScalesTemplate.TeamData.CreateLunchAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(4), start.AddDays(CDbl((12))).AddHours(13))}
            Dim interval As DevExpress.Mvvm.DateTimeRange = New DevExpress.Mvvm.DateTimeRange(start.AddDays(-7), start.AddDays(21))
            Dim days As System.Collections.Generic.List(Of Integer) = New System.Collections.Generic.List(Of Integer)()
            For i As Integer = 0 To 50 - 1
                Dim emp As WpfSchedulerTimelineScalesTemplate.Employee = WpfSchedulerTimelineScalesTemplate.TeamData.Employees(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](0, WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Count))
                Dim newStart As System.DateTime = start.AddYears(-1)
                newStart = newStart.AddDays(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](365))
                If interval.Start <= newStart AndAlso interval.[End] >= newStart Then Continue For
                If days.Contains(newStart.DayOfYear) Then Continue For
                If WpfSchedulerTimelineScalesTemplate.TeamData.VacationAppointments.Any(Function(x) x.Start <= newStart AndAlso x.[End] >= newStart) Then Continue For
                days.Add(newStart.DayOfYear)
                res.Add(WpfSchedulerTimelineScalesTemplate.TeamData.CreateLunchAppt(emp, newStart.AddHours(13)))
            Next

            Return res
        End Function

        Private Function CreateMeetingRecurrenceAppt(ByVal subject As String, ByVal start As System.DateTime) As TeamAppointment
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Pattern), .AllDay = False, .Start = start, .[End] = start.AddHours(1), .Subject = subject, .Status = 2, .Label = 2, .CalendarId = 1}
            appt.RecurrenceInfo = New DevExpress.XtraScheduler.RecurrenceInfo() With {.Start = start, .Type = DevExpress.XtraScheduler.RecurrenceType.Weekly, .WeekDays = DevExpress.XtraScheduler.WeekDays.Friday, .Month = 12, .Range = DevExpress.XtraScheduler.RecurrenceRange.NoEndDate}.ToXml()
            Return appt
        End Function

        Private Function CreateLunchAppt(ByVal emp As WpfSchedulerTimelineScalesTemplate.Employee, ByVal start As System.DateTime) As TeamAppointment
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = False, .Start = start, .[End] = start.AddHours(1), .Subject = String.Format("Lunch with {0}", emp.FirstName), .Status = 3, .Label = 3, .CalendarId = 0}
            Return appt
        End Function

        Private Function CreatePhoneCallsAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim res As System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment) = New System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)() From {WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(0), start.AddDays(CDbl((0))).AddHours(10)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(1), start.AddDays(CDbl((3))).AddHours(11)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(2), start.AddDays(CDbl((3))).AddHours(CDbl((12))).AddMinutes(40), System.TimeSpan.FromMinutes(15)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(3), start.AddDays(CDbl((-4))).AddHours(14)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(4), start.AddDays(CDbl((9))).AddHours(15)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.Employees(5), start.AddDays(CDbl((12))).AddHours(15)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee(), start.AddDays(CDbl((0))).AddHours(16)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee(), start.AddDays(CDbl((2))).AddHours(15.6)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee(), start.AddDays(CDbl((4))).AddHours(15)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee(), start.AddDays(CDbl((5))).AddHours(10.5)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee(), start.AddDays(CDbl((5))).AddHours(16)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee(), start.AddDays(CDbl((6))).AddHours(9.7)), WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(WpfSchedulerTimelineScalesTemplate.TeamData.GetRandomEmployee(), start.AddDays(CDbl((6))).AddHours(16.8))}
            Dim interval As DevExpress.Mvvm.DateTimeRange = New DevExpress.Mvvm.DateTimeRange(start.AddDays(-7), start.AddDays(21))
            For i As Integer = 0 To 50 - 1
                Dim emp As WpfSchedulerTimelineScalesTemplate.Employee = WpfSchedulerTimelineScalesTemplate.TeamData.Employees(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](0, WpfSchedulerTimelineScalesTemplate.TeamData.Employees.Count))
                Dim newStart As System.DateTime = start.AddYears(-1)
                newStart = newStart.AddDays(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](365))
                If interval.Start <= newStart AndAlso interval.[End] >= newStart Then Continue For
                If WpfSchedulerTimelineScalesTemplate.TeamData.VacationAppointments.Any(Function(x) x.Start <= newStart AndAlso x.[End] >= newStart) Then Continue For
                res.Add(WpfSchedulerTimelineScalesTemplate.TeamData.CreatePhoneCallAppt(emp, newStart.AddHours(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](9, 18))))
            Next

            Return res
        End Function

        Private Function CreatePhoneCallAppt(ByVal emp As WpfSchedulerTimelineScalesTemplate.Employee, ByVal start As System.DateTime, ByVal Optional duration As System.TimeSpan? = Nothing) As TeamAppointment
            Dim newStart As System.DateTime = start.AddMinutes(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](0, 4) * 15)
            Dim newEnd As System.DateTime = If(duration IsNot Nothing, newStart.Add(duration.Value), newStart.AddMinutes(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](1, 6) * 5))
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = False, .Start = newStart, .[End] = newEnd, .Subject = String.Format("Phone Call with {0}", emp.FirstName), .Status = 2, .Label = 10, .CalendarId = 0}
            Return appt
        End Function

        Private Function CreateVacationsAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Return {New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = True, .Start = start.AddMonths(-6), .[End] = start.AddMonths(CInt((-6))).AddDays(14), .Subject = String.Format("Vacation"), .Status = 0, .Label = 4, .CalendarId = 0}, New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = True, .Start = start.AddMonths(6), .[End] = start.AddMonths(CInt((6))).AddDays(14), .Subject = String.Format("Vacation"), .Status = 0, .Label = 4, .CalendarId = 0}, New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = True, .Start = start.AddDays(4), .[End] = start.AddDays(8), .Subject = String.Format("Vacation"), .Status = 0, .Label = 4, .CalendarId = 0}}
        End Function

        Private Function CreateCarWashAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim res As System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment) = New System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)() From {WpfSchedulerTimelineScalesTemplate.TeamData.CreateCarWashAppt(start.AddDays(CDbl((1))).AddHours(17))}
            Dim newStart As System.DateTime = start.AddYears(-1)
            While newStart < start.AddMonths(1)
                newStart = newStart.AddDays(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](18, 35))
                If WpfSchedulerTimelineScalesTemplate.TeamData.VacationAppointments.Any(Function(x) x.Start <= newStart AndAlso x.[End] >= newStart) Then Continue While
                If newStart >= start AndAlso newStart <= start.AddDays(7) Then Continue While
                Call WpfSchedulerTimelineScalesTemplate.TeamData.CreateCarWashAppt(newStart)
            End While

            Return res
        End Function

        Private Function CreateCarWashAppt(ByVal start As System.DateTime) As TeamAppointment
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = False, .Start = start, .[End] = start.AddHours(1), .Subject = String.Format("Car Wash"), .Status = 3, .Label = 3, .CalendarId = 0}
            Return appt
        End Function

        Private Function CreateCompanyBirthdayAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim newStart As System.DateTime = New System.DateTime(start.Year - 1, start.Month, start.Day)
            newStart = newStart.AddDays(5)
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Pattern), .AllDay = True, .Start = newStart, .[End] = newStart.AddDays(1), .Subject = "Company Birthday Party", .Status = 0, .Label = 8, .CalendarId = 1}
            appt.RecurrenceInfo = New DevExpress.XtraScheduler.RecurrenceInfo() With {.AllDay = True, .Start = newStart, .Type = DevExpress.XtraScheduler.RecurrenceType.Yearly, .Month = newStart.Month, .DayNumber = newStart.Day, .WeekOfMonth = DevExpress.XtraScheduler.WeekOfMonth.None, .Range = DevExpress.XtraScheduler.RecurrenceRange.NoEndDate}.ToXml()
            Return {appt}
        End Function

        Private Function CreateTrainingAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim newStart As System.DateTime = start.AddYears(CInt((-1))).AddHours(8.5)
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Pattern), .AllDay = False, .Start = newStart, .[End] = newStart.AddHours(1.5), .Subject = "Sport Training", .Status = 1, .Label = 3, .CalendarId = 0}
            appt.RecurrenceInfo = New DevExpress.XtraScheduler.RecurrenceInfo() With {.AllDay = False, .Start = newStart, .Type = DevExpress.XtraScheduler.RecurrenceType.Weekly, .WeekDays = DevExpress.XtraScheduler.WeekDays.Monday Or DevExpress.XtraScheduler.WeekDays.Wednesday Or DevExpress.XtraScheduler.WeekDays.Friday, .Range = DevExpress.XtraScheduler.RecurrenceRange.NoEndDate}.ToXml()
            Return {appt}
        End Function

        Private Function CreatePayBillsAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim newStart As System.DateTime = start.AddDays(CDbl((2))).AddYears(-1)
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Pattern), .AllDay = True, .Start = newStart, .[End] = newStart.AddDays(1), .Subject = "Pay Bills", .Status = 0, .Label = 3, .CalendarId = 0}
            appt.RecurrenceInfo = New DevExpress.XtraScheduler.RecurrenceInfo() With {.AllDay = True, .Start = newStart, .Type = DevExpress.XtraScheduler.RecurrenceType.Monthly, .DayNumber = newStart.Day, .WeekOfMonth = DevExpress.XtraScheduler.WeekOfMonth.None, .Range = DevExpress.XtraScheduler.RecurrenceRange.NoEndDate}.ToXml()
            Return {appt}
        End Function

        Private Function CreateDentistAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim res As System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment) = New System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)() From {WpfSchedulerTimelineScalesTemplate.TeamData.CreateDentistAppt(start.AddDays(CDbl((4))).AddHours(17.5))}
            Dim newStart As System.DateTime = start.AddYears(-2)
            While newStart < start
                newStart = newStart.AddDays(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](365 \ 3, 365 \ 2))
                Call WpfSchedulerTimelineScalesTemplate.TeamData.CreateDentistAppt(newStart)
            End While

            Return res
        End Function

        Private Function CreateDentistAppt(ByVal start As System.DateTime) As TeamAppointment
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = False, .Start = start, .[End] = start.AddHours(2), .Subject = String.Format("Dentist"), .Status = 3, .Label = 3, .CalendarId = 0}
            Return appt
        End Function

        Private Function CreateRestaurantAppts(ByVal start As System.DateTime) As IEnumerable(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)
            Dim res As System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment) = New System.Collections.Generic.List(Of WpfSchedulerTimelineScalesTemplate.TeamAppointment)() From {WpfSchedulerTimelineScalesTemplate.TeamData.CreateDinnerAppt(start.AddDays(CDbl((2))).AddHours(19)), WpfSchedulerTimelineScalesTemplate.TeamData.CreateDinnerAppt(start.AddDays(CDbl((14))).AddHours(19)), WpfSchedulerTimelineScalesTemplate.TeamData.CreateDinnerAppt(start.AddDays(CDbl((18))).AddHours(21))}
            Dim newStart As System.DateTime = start.AddYears(-2)
            While newStart < start
                newStart = newStart.AddDays(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](14, 42))
                res.Add(WpfSchedulerTimelineScalesTemplate.TeamData.CreateDinnerAppt(newStart.AddHours(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](18, 22))))
            End While

            Return res
        End Function

        Private Function CreateDinnerAppt(ByVal start As System.DateTime, ByVal Optional duration As System.TimeSpan? = Nothing) As TeamAppointment
            Dim newStart As System.DateTime = start.AddMinutes(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](0, 4) * 15)
            Dim newEnd As System.DateTime = If(duration IsNot Nothing, newStart.Add(duration.Value), newStart.AddMinutes(WpfSchedulerTimelineScalesTemplate.TeamData.Random.[Next](4, 8) * 20))
            Dim appt = New WpfSchedulerTimelineScalesTemplate.TeamAppointment() With {.AppointmentType = CInt(DevExpress.XtraScheduler.AppointmentType.Normal), .AllDay = False, .Start = newStart, .[End] = newEnd, .Subject = String.Format("Dinner"), .Status = 0, .Label = 5, .CalendarId = 0}
            Return appt
        End Function
    End Module
End Namespace
