using System; 

class Running : Activity {
    private double _distance;

    //Constructor for a running activity
    public Running (DateTime date, int minutes, double distance) : base(date, minutes) {
        _distance = distance;
    }

    //Override to get the distance run
    public override double GetDistance() {
        return _distance;
    }

    //Override to get the speed
    public override double GetSpeed() {
        return _distance / (GetMinutes() / 60);
    }

    //Override to get the pace
    public override double GetPace() {
        return GetMinutes() / _distance;
    }

    //Override to get the summary
    public override string GetSummary() {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetMinutes()} min)- Distance {_distance} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km\n";
    }
}