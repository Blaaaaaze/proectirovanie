using System;


class AttractionSearch : StrategySearch
{
    public AttractionSearch()
    {
        Title = "Путь по достопремичательностям";
    }

    public override string ToString()
    {
        return Title;
    }

    public override int Search(string start, string end)
    {
        return 5;
    }
}
