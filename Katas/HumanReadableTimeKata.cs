using System;

namespace Katas
{
    public static class HumanReadableTimeKata
    {
        public static string GetReadableTime(int seconds)
        {
            int minutes = 0, 
                hours = 0;

            if (seconds > 59)
            {
                minutes = (int)Math.Floor((decimal)(seconds / 60));

                seconds = seconds - (minutes * 60);

                if (minutes > 59)
                {
                    hours = (int)Math.Floor((decimal)(minutes / 60));

                    minutes = minutes - (hours * 60);
                }
            }

            string dateString = string.Format("{0}:{1}:{2}", 
                                              hours.ToString().PadLeft(2, '0'), 
                                              minutes.ToString().PadLeft(2, '0'), 
                                              seconds.ToString().PadLeft(2, '0'));

            return dateString;
        }
    }
}
