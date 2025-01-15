using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assin4
{
    internal class Duration3
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

     
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600; 
            totalSeconds %= 3600; 
            Minutes = totalSeconds / 60; 
            Seconds = totalSeconds % 60; 
        }

        
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            return $"Seconds: {Seconds}";
        }










    }
}
