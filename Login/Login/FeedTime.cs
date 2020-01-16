using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class FeedTime
    {
        public int Id { get; private set; }
        string Time;
        public static int NextId;

        public FeedTime(string time)
        {
            Id = NextId;
            NextId++;
            Time = time;
        }

    }
}
