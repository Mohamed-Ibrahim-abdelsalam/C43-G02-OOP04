using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assin4
{
    internal class Duration
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

      
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public void DisplayDuration()
        {
            Console.WriteLine($"{Hours} hours, {Minutes} minutes, {Seconds} seconds");
        }


















    }
}
