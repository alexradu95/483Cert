using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Events
{
    class AlarmEventArgs : EventArgs
    {
        public string Location { get; set; }
        public AlarmEventArgs(string location)
        {
            Location = location;
        }
    }
    class Alarm
    {
        // Delegate for the alarm event
        public event EventHandler<AlarmEventArgs> OnAlarmRaised = delegate { };
        // Called to raise an alarm
        public void RaiseAlarm(string location)
        {
            List<Exception> exceptionList = new List<Exception>();
            foreach (Delegate handler in OnAlarmRaised.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, new AlarmEventArgs(location));
                }
                catch (TargetInvocationException e)
                {
                    exceptionList.Add(e.InnerException);
                }
            }
        if (exceptionList.Count > 0)
        throw new AggregateException(exceptionList);
        }
    }
    class PublishSubscribe
    {
        // Method that must run when the alarm is raised
        static void AlarmListener1(object sender, AlarmEventArgs e)
        {
            Console.WriteLine("Alarm listener 1 called");
            Console.WriteLine("Alarm in {0}", e.Location);
            throw new Exception("Bang");
        }
        // Method that must run when the alarm is raised
        static void AlarmListener2(object sender, AlarmEventArgs e)
        {
            Console.WriteLine("Alarm listener 2 called");
            Console.WriteLine("Alarm in {0}", e.Location);
            throw new Exception("Boom");
        }
        public static void RunPublishSubscribeExample()
        {
            // Create a new alarm
            Alarm alarm = new Alarm();
            // Connect the two listener methods
            alarm.OnAlarmRaised += AlarmListener1;
            alarm.OnAlarmRaised += AlarmListener2;
            // raise the alarm
            try
            {
                alarm.RaiseAlarm("Kitchen");
            }
            catch (AggregateException agg)
            {
                foreach (Exception ex in agg.InnerExceptions)
                    Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Alarm raised");
            Console.ReadKey();
        }
    }
}
