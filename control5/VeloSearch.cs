using System;


class VeloSearch : StrategySearch
{
    public VeloSearch()
    {
        Title = "Путь по велодорожкам";
    }

    public override string ToString()
    {
        return Title;
    }

    public override int Search(string start, string end)
    {
        return 3;
    }
}