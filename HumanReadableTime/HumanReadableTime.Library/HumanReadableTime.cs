namespace HumanReadableTime.Library
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int timeInSeconds)
        {
            if (timeInSeconds < 0 || timeInSeconds > 359_999)
                return "00:00:00";

            return $"{timeInSeconds / 3600:00}:{timeInSeconds % 3600 / 60:00}:{timeInSeconds % 60:00}";
        }
    }
}
