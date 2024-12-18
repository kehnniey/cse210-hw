using System;

    // Derived class: Swimming
    public class Swimming : Activity
    {
        private int _laps; // Number of laps in the pool
        private const double LapLengthInKm = 50.0 / 1000; 

        // Constructor
        public Swimming(DateTime date, int durationMinutes, int laps) 
            : base(date, durationMinutes)
        {
            _laps = laps;
        }

        // Override methods
        public override double GetDistance()
        {
            return _laps * LapLengthInKm;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / DurationMinutes) * 60;
        }

        public override double GetPace()
        {
            return DurationMinutes / GetDistance();
        }
    }

