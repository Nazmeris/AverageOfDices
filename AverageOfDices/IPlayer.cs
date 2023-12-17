namespace AverageOfDices
{
    internal interface IPlayer
    {
        string Name { get; }
        void AddDice(string dice);
        void AddDice(int dice);
        Statistics GetPlayerStatistics();
    }
}
