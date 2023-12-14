namespace AverageOfDices
{
    internal interface IPlayer
    {
        string Name { get; }
        void AddDice(string dice);
        Statistics GetPlayerStatistics();
    }
}
