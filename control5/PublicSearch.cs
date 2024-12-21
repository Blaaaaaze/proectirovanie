using System;


class PublicSearch : StrategySearch
{
    public PublicSearch()
    {
        Title = "Путь на общественном транспорте";
    }

    public override string ToString()
    {
        return Title;
    }

    public override int Search(string start, string end)
    {
        return 4;
    }
}