using System;

namespace eticaret_programi
{
    internal class JobScheduler
    {
        private TimeSpan timeSpan;
        private Action action;

        public JobScheduler(TimeSpan timeSpan, Action action)
        {
            this.timeSpan = timeSpan;
            this.action = action;
        }

        internal void Start()
        {
            throw new NotImplementedException();
        }
    }
}