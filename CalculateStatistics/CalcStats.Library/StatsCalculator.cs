namespace CalcStats.Library
{
    public class StatsCalculator
    {
        private int[] sequence;

        public int Minimum { get; }
        public int Maximum { get; }
        public int NumberOfElements { get; }
        public double AverageValue { get; }

        public StatsCalculator(int[] _sequence)
        {
            sequence = _sequence;

            Minimum = sequence.Min();
            Maximum = sequence.Max();
            NumberOfElements = sequence.Length;
            AverageValue = sequence.Average();
        }
    }
}
