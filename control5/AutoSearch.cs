using System;


class AutoSearch : StrategySearch
{
    public AutoSearch()
    {
        Title = "Путь по автодорогам";
    }

    public override string ToString()
    {
        return Title;
    }

    public override int Search(string start, string end)
    {
        return 1;
    }

  
}