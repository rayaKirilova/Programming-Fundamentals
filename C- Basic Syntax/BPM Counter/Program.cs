using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            // 1 bar == 4 beats ->> 1 beat = 1 / 4 bar - >> 60 * 0.25

            double bars = Math.Round(numberOfBeats * 0.25, 1);

            double seconds = numberOfBeats * 60.0 / beatsPerMinute;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine($"{bars} bars - {minutes}m {Math.Floor(seconds)}s");
        }
    }
}
