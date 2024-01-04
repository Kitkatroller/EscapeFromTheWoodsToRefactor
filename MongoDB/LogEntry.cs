using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeFromTheWoods.MongoDB
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string MonkeyName { get; set; }
        public int TreeID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} - {MonkeyName} is at tree {TreeID} ({X}, {Y})";
        }
    }



}
