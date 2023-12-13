
namespace CalcStats.Library
{
    public class CalcStats
    {
        private int[] sequence;

        public CalcStats(int[] _sequence)
        {
            sequence = _sequence;
        }

        public object Minimum()
        {
            return sequence.Min();
        }
    }
}
