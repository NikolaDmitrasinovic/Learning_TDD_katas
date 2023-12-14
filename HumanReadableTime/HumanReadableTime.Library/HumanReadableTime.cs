namespace HumanReadableTime.Library
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 0)
            {                
                return "00:00:" + ConvertToDoubleDigit(seconds);
            }

            return "00:00:00";
        }

        private static string ConvertToDoubleDigit(int value)
        {
            if (value < 10)
                return "0" + value;

            return "" + value;
        }
    }
}
