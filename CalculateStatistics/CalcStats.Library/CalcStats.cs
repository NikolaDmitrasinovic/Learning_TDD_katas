namespace CalcStats.Library
{
    public class CalcStats
    {
        private int[] sequence;

        public int Minimum { get; }
        public int Maximum { get; }
        public int NumberOfElements { get; }
        public double AverageValue { get; }

        public CalcStats(int[] _sequence)
        {
            sequence = _sequence;

            Minimum = sequence.Min();
            Maximum = sequence.Max();
            NumberOfElements = sequence.Length;
            AverageValue = sequence.Average();
        }
    }
}
