namespace HumanReadableTime.Library
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int timeInSeconds)
        {
            if (timeInSeconds > 0)
            {
                return "00:" + ConvertToDoubleDigit(timeInSeconds / 60) + ":" + ConvertToDoubleDigit(timeInSeconds % 60);
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
