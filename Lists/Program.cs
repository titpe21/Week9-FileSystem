﻿using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishes = new List<string>();
            myWishes.Add("new pillow");
            myWishes.Add("box of chocolates");
            myWishes.Add("new coffee mug");

            int listLength = myWishes.Count;

            Console.WriteLine($"List length: {listLength}");
            //Console.WriteLine(myWishes[0]);
            //Console.WriteLine(myWishes[1]);
            //Console.WriteLine(myWishes[2]);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"You wish for: {wish}");
            }
        }
    }
}
