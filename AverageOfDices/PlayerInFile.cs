namespace AverageOfDices
{
    public class PlayerInFile : BasePlayer
    {
        private string fileName;

        public PlayerInFile(string name)
            : base(name) 
        {
            fileName = "Throws" + name + ".txt";
        }
        public override void AddDice(int dice)
        {
            if (dice >= 1 && dice <= 20)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(dice);
                }
            }
            else
            {
                throw new Exception("invalid dice throw value");
            }
        }
        public override Statistics GetPlayerStatistics()
        {
            var dicesFromFile = ReadDicesFromFile();
            var result = CountPlayerStatistics(dicesFromFile);
            return result;
        }
        private List<int> ReadDicesFromFile()
        {
            var dices = new List<int>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    string line;
                    while((line = reader.ReadLine()!) != null)
                        {
                        var number = int.Parse(line);
                        if (number < 1 || number > 20)
                        {  
                            continue; 
                        }
                        dices.Add(number);
                    }
                }
            }
            return dices;
        }
        private Statistics CountPlayerStatistics(List<int> dices)
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

