namespace AverageOfDices
{
    public abstract class BasePlayer : IPlayer
    {
        public BasePlayer(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public abstract Statistics GetPlayerStatistics();
        public abstract void AddDice(string dice);
        public abstract void AddDice(int dice);
    }
}
