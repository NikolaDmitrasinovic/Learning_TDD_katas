namespace HumanReadableTime.Library
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int timeInSeconds)
        {
            if (timeInSeconds < 0 || timeInSeconds > 359_999)
                return "00:00:00";

            return ConvertToDoubleDigit(timeInSeconds / 3600) + ":" + ConvertToDoubleDigit(timeInSeconds % 3600 / 60) + ":" + ConvertToDoubleDigit(timeInSeconds % 60);
        }

        private static string ConvertToDoubleDigit(int value)
        {
            if (value < 10)
                return "0" + value;

            return "" + value;
        }
    }
}
