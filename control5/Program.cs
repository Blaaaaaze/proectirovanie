class Program
{
    static void Main(string[] args)
    {
        string point1 = "start";
        string point2 = "end";

        StrategySearch search = new AutoSearch();
        Context context = new Context(search, point1, point2);

        context.Search();
        context.PrintRoute();

        search = new WalkSearch();
        context = new Context(search, point1, point2);

        context.Search();
        context.PrintRoute();

        search = new VeloSearch();
        context = new Context(search, point1, point2);

        context.Search();
        context.PrintRoute();

        search = new PublicSearch();
        context = new Context(search, point1, point2);

        context.Search();
        context.PrintRoute();

        search = new AttractionSearch();
        context = new Context(search, point1, point2);

        context.Search();
        context.PrintRoute();
    }
}