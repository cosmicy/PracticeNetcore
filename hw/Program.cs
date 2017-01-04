using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            if (args.Length == 1)
            {
                bool b = Regex.IsMatch(args[0], @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");

                Console.WriteLine(b);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1,"fwef");


            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }
    }
}
