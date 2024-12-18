using System;

    // Derived class: Running
    public class Running : Activity
    {
        private double _distance; // Distance in kilometers

        // Constructor
        public Running(DateTime date, int durationMinutes, double distance) 
            : base(date, durationMinutes)
        {
            _distance = distance;
        }

        // Override methods
        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / DurationMinutes) * 60;
        }

        public override double GetPace()
        {
            return DurationMinutes / _distance;
        }
    }

