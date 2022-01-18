using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataHRD
{
    public class TimeFormat
    {

        public string GetReadableTime(int seconds)
        {
            int hrs = seconds / 3600;
            seconds = seconds % 3600;
            int min = seconds / 60;
            int sec = seconds % 60;

            if (seconds > 359999) return string.Format("{0}:{1}:{2}", 99, 59, 59);
            if (seconds < 0) return String.Format("{0}:{1}:{2}", "00", "00", "00");
            else return string.Format("{0}:{1}:{2}", hrs.ToString("00"), min.ToString("00"), sec.ToString("00"));
        }
    }
}
