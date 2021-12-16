using System;
using System.Collections.Generic;

namespace Module3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sum = 0;
            var taskOne = new TaskOne();
            taskOne.TryCatch(() => sum = taskOne.SumResult(5, 4));
            Console.WriteLine($"Task one: {sum}");
            var taskTwo = new TaskTwo();
            taskTwo.Run();
        }
    }
}
