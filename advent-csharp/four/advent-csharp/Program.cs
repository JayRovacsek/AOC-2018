using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var programLogic = new ProgramLogic();
            var logs = programLogic.LoadLogs("input.txt");
            logs = programLogic.AddEndDate(logs.OrderBy(x => x.StartDate).ToList());
            logs = programLogic.AddAsleepFlag(logs.ToList());
            var guards = programLogic.GenerateGuardData(logs);
            var sleepyHead = programLogic.MostSleepy(guards);
            var mostAsleepMinute = programLogic.MostAsleepMinute(sleepyHead, logs);

            Console.WriteLine($"El' Sleepy: {sleepyHead.Id}, Time asleep: {sleepyHead.TimeAsleep}, Answer = {sleepyHead.Id*mostAsleepMinute}");




            //var fabricSquares = programLogic.CountDoubleClaims(matrix);

            //Console.WriteLine($"Fabric tiles count used by two or more claims is: {fabricSquares}");

            //var claimNotOverlapping = programLogic.DetermineNonOverlapping(claims);

            //Console.WriteLine($"Fabric claim not overlapping with any other claim is: {claimNotOverlapping}");
            //Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
