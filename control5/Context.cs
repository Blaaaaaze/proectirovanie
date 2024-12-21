using System;

class Context
{
    StrategySearch strategy;

    string start;
    string end;

    public Context(StrategySearch strategy, string start, string end)
    {
        this.strategy = strategy;
        this.start = start;
        this.end = end;
    }

    public void Search()
    {
        strategy.Search(start, end);
    }

    public void PrintRoute()
    {
        Console.WriteLine(strategy.ToString());
    }
}