using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LogicalProgramming.LogicalPrograms
{
    internal class ElaspedTimeStopWatch
    {
        public static void ElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            //Thread.Sleep(5000);
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("{0} is even number.",number);
            }
            else
            {
                Console.WriteLine("{0} is odd number.", number);
            }

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.ReadLine();
        }
    }
}
