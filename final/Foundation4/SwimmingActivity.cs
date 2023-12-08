using System;
using System.Runtime.CompilerServices;

class Swimming : Activity {
    private int _laps;

    //Constructor for a swimming activity
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes) {
        _laps = laps;
    }

    //Override to get distance
    public override double GetDistance() {
        return _laps * 50.0 / 1000.0;
    }

    //Override to get speed
    public override double GetSpeed() {
        return GetDistance() / (GetMinutes() / 60.0);
    }

    //Override to get pace
    public override double GetPace() {
        return GetMinutes() / GetDistance();
    }

    //Override to get the summary
    public override string GetSummary() {
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetMinutes()} min)- Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km\n";
    }
}