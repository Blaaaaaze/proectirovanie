using System;

class Drive
{
    public event EventHandler driveevent;

    private string twist;

    public string Twist
    {
        get { return twist; }
        set
        {
            twist = value;
            if (driveevent != null)
                driveevent(this, new EventArgs());
        }
    }

    public Drive()
    {
        Twist = "исходящая позиция";
    }

    public void TurnLeft()
    {
        Twist = "Поворот налево";
    }

    public void TurnRight()
    {
        Twist = "Поворот направо";
    }

    public void Stop()
    {
        Twist = "Стоп";
    }

    public override string ToString()
    {
        string s = String.Format("Привод: {0}", Twist);
        return s;
    }
}