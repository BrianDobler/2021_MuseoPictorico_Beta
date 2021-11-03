using System;

namespace MuseoPictoricoG11.Utils
{
    public struct Hours
    {
        public int seconds;
        public Hours(int seconds)
        {
            this.seconds = seconds;
        }

        public static Hours operator +(Hours x, Hours y)
        {
            return new Hours(x.seconds + y.seconds);
        }

        public static Hours operator -(Hours x, Hours y)
        {
            return new Hours(x.seconds - y.seconds);
        }

        public override string ToString()
        {
            string hh = Math.Floor(seconds / 3600f).ToString();
            string mm = Math.Floor((seconds / 60f) % 60).ToString();
            string ss = (seconds % 60).ToString();
            if (hh.Length == 1) hh = "0" + hh;
            if (mm.Length == 1) mm = "0" + mm;
            if (ss.Length == 1) ss = "0" + ss;
            return string.Join(":", hh, mm, ss);
        }
    }
}
