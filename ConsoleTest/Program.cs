﻿using System;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //JObjectTest.JObject();
            await ProcessTest.Process();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("end...");
            Console.ReadKey();
        }
    }
}
