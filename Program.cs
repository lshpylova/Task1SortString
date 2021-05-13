using System;
using System.Collections.Generic;

namespace SortListByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "testqqqqqqqaaa", "qaqaqa", "123456789", "OlenaShpylova" };
            SortStringLength sortLength = new SortStringLength();
            names.Sort(sortLength);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }

}
