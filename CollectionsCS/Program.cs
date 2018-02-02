using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Austin", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
