namespace AverageOfDices
{
    public class Statistics
    {
        public int Min { get; private set; }
        public int Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public string ThrowAverage
        {
            get
            {
                switch (Average)
                {
                    case >= 16:
                        return "Impossible!";
                    case >= 12:
                        return "Very Good!";
                    case >= 8:
                        return "Average";
                    case >= 4:
                        return "Below Average";
                    case >= 1:
                        return "Very Bad";
                    default:
                        return "Not Applicable";
                }
            }
        }
        public double Average
        {
            get
            {
                double result = Sum / Count;
                return Math.Round(result,2);
            }
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0;
            Max = int.MinValue;
            Min = int.MaxValue;
        }
        public void CalculateStatistics(int dice)
        {
            Count++;
            Sum += dice;
            Min = Math.Min(Min, dice);
            Max = Math.Max(Max, dice);
        }
    }
}