using System;


class WalkSearch : StrategySearch
{
    public WalkSearch()
    {
        Title = "Путь пешком";
    }

    public override string ToString()
    {
        return Title;
    }

    public override int Search(string start, string end)
    {
        return 2;
    }
}