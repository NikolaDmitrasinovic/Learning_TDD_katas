
namespace CalcStats.Library
{
    public class CalcStats
    {
        private int[] value;

        public CalcStats(int[] value)
        {
            this.value = value;
        }

        public object Minimum()
        {
            return value.Min();
        }
    }
}
