using System;


    // Derived class: Cycling
    public class Cycling : Activity
    {
        private double _speed; // Speed in kph

        // Constructor
        public Cycling(DateTime date, int durationMinutes, double speed) 
            : base(date, durationMinutes)
        {
            _speed = speed;
        }

        // Override methods
        public override double GetDistance()
        {
            return (_speed * DurationMinutes) / 60;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / _speed;
        }
    }

