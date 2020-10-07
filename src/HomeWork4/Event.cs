using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    public class Event
    {
        public enum State
        {
            ToDo = 1,
            InProcess,
            Done,
            Canceled,
            Unknown
        }
        public string Description { set; get; }
        public DateTime startDate;
        public DateTime finishDate;
        public string Id = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);

        public State status;
    }
}
