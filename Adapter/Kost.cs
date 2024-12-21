using System;

class Kost : IGame
{
    Random r;

    public Kost()
    {
        r = new Random();
    }

    public int Brosok()
    {
        int res = r.Next(6) + 1;
        return res;
    }
}