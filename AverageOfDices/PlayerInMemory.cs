namespace AverageOfDices
{
    public class PlayerInMemory : BasePlayer
    {
        private List<int> dices;

        public PlayerInMemory(string name)
            : base(name)
        {
            dices = new List<int>();
        }
        public override void AddDice(int dice)
        {
            if (dice >= 1 && dice <= 20)
            {
                dices.Add(dice);
            }
            else
            {
                throw new Exception("invalid dice throw value");
            }
        }
        public override Statistics GetPlayerStatistics()
        {
            var statistics = new Statistics();
            if (dices.Count == 0 || dices == null)
            {
                statistics.CalculateStatistics(0); 
                return statistics;
            }
            foreach (var dice in dices)
            {
                statistics.CalculateStatistics(dice);
            }
            return statistics;
        }
    }
}
