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
        public virtual void AddDice(string dice)
        {
            var parsingResult = int.TryParse(dice, out int result);
            if (!parsingResult)
            {
                throw new InvalidOperationException();
            }
            AddDice(result);
        }
        public abstract void AddDice(int dice);
    }
}
