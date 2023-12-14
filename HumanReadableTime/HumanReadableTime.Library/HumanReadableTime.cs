namespace HumanReadableTime.Library
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 0)
            {
                if (seconds < 10)
                {
                    return "00:00:0" + seconds;
                }
                return "00:00:" + seconds;
            }

            return "00:00:00";
        }
    }
}
