using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '9', 'a', '3', 'b', '1', '2', 'x', '5', '4' };
            var numbers = new List<int>();
            var str = "";

            foreach (char c in arr)
            {
                try
                {
                    str = c.ToString();
                    numbers.Add(int.Parse(str));
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{c.ToString()}'");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unhandled exception: {e.GetType().Name} | {e.Message}");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
