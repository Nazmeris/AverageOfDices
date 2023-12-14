namespace AverageOfDices
{
    public class PlayerInMemory : BasePlayer
    {
        private List<int> dices = new List<int>();

        public PlayerInMemory(string name)
            : base(name)
        {
            dices = new List<int>();
        }
        public override void AddDice(string dice)
        {
            var parsingResult = int.TryParse(dice, out int result);
            if (!parsingResult)
            {
                throw new InvalidOperationException();
            }
            if (result >= 0 && result <= 20)
            {
                dices.Add(result);
            }
            else
            {
                throw new Exception("invalid dice throw value");
            }
        }
        public override void AddDice(int dice)
        {
            if (dice >= 0 && dice <= 20)
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
        private Statistics CountPlayerStatistics(List<float> dices)
        {
            var statistics = new Statistics();
            
            foreach (var dice in dices)
            {
                statistics.CalculateStatistics(dice);
            }

            return statistics;
        }
    }
}
