using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.TimelineViewSettings.TimeInterval = new System.TimeSpan(1, 0, 0);

            TimelineViewSettings timelineViewSettings = new TimelineViewSettings();
            timelineViewSettings.StartHour = 0;
            timelineViewSettings.EndHour = 23;
            timelineViewSettings.TimeRulerFormat = string.Format("'Room'") + " " + "HH";
            this.AssociatedObject.TimelineViewSettings = timelineViewSettings;

            DaysViewSettings daysViewSettings = new DaysViewSettings();
            daysViewSettings.StartHour = 0;
            daysViewSettings.EndHour = 23;
            daysViewSettings.TimeRulerFormat = string.Format("'Room'") + " " + "HH";
            this.AssociatedObject.DaysViewSettings = daysViewSettings;
        }
    }
}



