using System;

    // Base class: Activity
    public abstract class Activity
    {
        private DateTime _date;
        private int _durationMinutes; 

        // Constructor
        public Activity(DateTime date, int durationMinutes)
        {
            _date = date;
            _durationMinutes = durationMinutes;
        }

        // Encapsulated properties
        public DateTime Date => _date;
        public int DurationMinutes => _durationMinutes;


        // Abstract methods to calculate distance, speed, and pace
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Common method to get activity summary
        public virtual string GetSummary()
        {
            return $"{Date:dd MMM yyyy}: {DurationMinutes} min - Distance: {GetDistance():F1} km, " +
                   $"Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
        }
    }

