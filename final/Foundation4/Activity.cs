using System;

class Activity {
    private DateTime _date;
    private int _minutes;

    //Constructor for an activity
    public Activity(DateTime date, int minutes) {
        _date = date;
        _minutes = minutes;
    }

    //Getter for the date
    public DateTime GetDate() {
        return _date;
    }

    //Getter for the minutes
    public int GetMinutes() {
        return _minutes;
    }

    //Virtual method for distance
    public virtual double GetDistance() {
        return 0;
    }

    //Virtual method for speed
    public virtual double GetSpeed() {
        return 0;
    }

    //Virtual method for pace
    public virtual double GetPace() {
        return 0;
    }

    //Virtual method for the summary
    public virtual string GetSummary() {
        return "";
    }
}