using System;

class Cycling : Activity {
    private double _speed;

    //Constructor for a cycling activity
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes) {
        _speed = speed;
    }

    //Override to get the distance
    public override double GetDistance() {
        return _speed * (GetMinutes() / 60.0);
    }

    //Override to get the speed
    public override double GetSpeed() {
        return _speed;
    }

    //Override to get the pace
    public override double GetPace() {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetMinutes()} min)- Distance {GetDistance():F1} km, Speed: {_speed} kph, Pace: {GetPace():F1} min per km\n";
    }
}