using System;

abstract class StrategySearch
{
    public string Title { get; set; }
    public abstract int Search(string start, string end);
}
