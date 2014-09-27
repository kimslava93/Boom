using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boom_Manager_Project.MyClasses
{

    public struct RoundedTimeSpan
    {

        private const int TimespanSize = 7; // it always has seven digits

        private readonly TimeSpan _roundedTimeSpan;
        private int _precision;

        public RoundedTimeSpan(long ticks, int precision)
        {
            if (precision < 0)
            {
                throw new ArgumentException("precision must be non-negative");
            }
            _precision = precision;
            int factor = (int) Math.Pow(10, (TimespanSize - precision));

            // This is only valid for rounding milliseconds-will *not* work on secs/mins/hrs!
            _roundedTimeSpan = new TimeSpan(((long) System.Math.Round((1.0*ticks/factor))*factor));
        }

        public TimeSpan TimeSpan
        {
            get { return _roundedTimeSpan; }
        }

    }
}
