﻿using System;
using System.Collections.Generic;

namespace Task1.Domain
{
    public static class PrintInConsole
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        public static void PrintCollection<T> (List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        } 

    }
}
