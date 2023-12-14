



namespace CalcStats.Library
{
    public class CalcStats
    {
        private int[] sequence;

        public CalcStats(int[] _sequence)
        {
            sequence = _sequence;
        }

        public object AverageValue()
        {
            return sequence.Average();
        }

        public object Maximum()
        {
            return sequence.Max();
        }

        public object Minimum()
        {
            return sequence.Min();
        }

        public object NumberOfElements()
        {
            return sequence.Length;
        }
    }
}
