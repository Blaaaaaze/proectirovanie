using System;

class GeometryProgression : Progression
{
    public GeometryProgression(int f, int l, int h) : base(f, l, h) { }

    public override void Progress()
    {
        int fF = First;
        do
        {
            progList.Add(fF);
            fF = fF * H;
        }
        while (fF < Last);
    }
}