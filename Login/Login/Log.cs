using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Log
    {
        int id;
        List<LogEntry> entries = new List<LogEntry>();
        DateTime LastTimeChecked;

        int check()
        {
            return id;
        }

        int getId()
        {
            return id;
        }
    }
}