using System;
using les_03_task_01;
using les_03_task_02;

namespace les_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // task_01
            Task_01 ts01 = new Task_01(20);
            Console.WriteLine(ts01.getPairCount());

            //task_02
            Task_02 ts02 = new Task_02(20, 2, 5);
            Console.WriteLine($"Sum of all elements: {ts02.Sum()}");
            
            ts02.Inverse();
            Console.WriteLine("\"Inverse\" done");
            Console.WriteLine($"Sum of all elements: {ts02.Sum()}");

            ts02.Multi(3);
            Console.WriteLine("\"Mult\" done");
            Console.WriteLine($"Sum of all elements: {ts02.Sum()}");

            ts02.MaxCount();
            Console.WriteLine("\"MaxCount\" done");
            Console.WriteLine($"Count of max elements: {ts02.MaxCount()}");
        }
    }
}
