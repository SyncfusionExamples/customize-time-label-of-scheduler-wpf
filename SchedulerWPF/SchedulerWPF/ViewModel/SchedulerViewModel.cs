using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection AppointmentCollection { get; set; } = new ScheduleAppointmentCollection();
        public SchedulerViewModel()
        {
            //Adding schedule appointment in schedule appointment collection 
            ScheduleAppointment appointment1 = new ScheduleAppointment()
            {
                StartTime = new DateTime(2020, 11, 10, 10, 0, 0),
                EndTime = new DateTime(2020, 11, 10, 11, 0, 0),
                Subject = "Booked",
                AppointmentBackground = new SolidColorBrush(Colors.Red),
            };
            //Creating recurrence rule
            appointment1.RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=10";
            //Adding schedule appointment in the schedule appointment collection
            AppointmentCollection.Add(appointment1);
        }
    }
}

    


