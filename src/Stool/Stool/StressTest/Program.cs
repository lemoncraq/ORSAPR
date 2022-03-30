using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.Devices;
using StoolPlugin.Model.Kompas;
using StoolPlugin.Model.Parameters;

namespace StressTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stoolParameters = new StoolParameters();
            StoolBuilder tableBuilder = new StoolBuilder();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var streamWriter = new StreamWriter("LogAfterStressTest.txt",
                true);
            var count = 0;
            int maxTable = 100;
            for (int i = 0; i < maxTable; i++)
            {
                tableBuilder.Build(stoolParameters, LegsType.RoundLegs);
                var computerInfo = new ComputerInfo();
                var usedMemory = (computerInfo.TotalPhysicalMemory
                                  - computerInfo.AvailablePhysicalMemory)
                                 / Math.Pow(1024, 3);
                streamWriter.WriteLine($"{++count}" +
                                       $"\t{stopWatch.Elapsed:hh\\:mm\\:ss}\t" +
                                       $"{usedMemory}");
                streamWriter.Flush();
            }
            stopWatch.Stop();
            streamWriter.Close();
        }
    }
}
