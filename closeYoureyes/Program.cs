using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telegrem
{
    internal class Program
    {
        static void Main()
        {
            var timeStart = DateTime.Parse("13:00");
            var timeEnd = DateTime.Parse("16:00");
            var timeNow = DateTime.Now;
           
            while (true)
            {
                if (timeNow > timeEnd && timeNow < timeStart)
                {
                    Process[] launcher = Process.GetProcessesByName("BsgLauncher");
                    Process[] game = Process.GetProcessesByName("EscapeFromTarkov");
                    removeProcess(launcher);
                    removeProcess(game);

                }
            }
        }

        public static void removeProcess(Process[] processes)
        {
            foreach (var item in processes)
            {
                item.Kill();
                item.WaitForExit();
                item.Dispose();
            }
        }
    }
}
