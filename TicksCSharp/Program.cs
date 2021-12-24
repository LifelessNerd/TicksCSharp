using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicksCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the amount of ticks to be converted.");
            int ticks = Int32.Parse(Console.ReadLine());
            int secs = ticks / 20;
            TimeSpan t = TimeSpan.FromSeconds(secs);

            string answer = string.Format("{0:D2}d, {1:D2}h, {2:D2}m, {3:D2}s",
                            t.Days,
                            t.Hours,
                            t.Minutes,
                            t.Seconds);

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
