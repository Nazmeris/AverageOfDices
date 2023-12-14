namespace AverageOfDices
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
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
                    case < 1:
                        return "Not Applicable";
                    default:
                        return "Something went bad";
                }
            }
        }
        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0;
            Max = float.MinValue;
            Min = float.MaxValue;
        }
        public void CalculateStatistics(float dice)
        {
            Count++;
            Sum += dice;
            Min = Math.Min(Min, dice);
            Max = Math.Max(Max, dice);
        }
    }
}