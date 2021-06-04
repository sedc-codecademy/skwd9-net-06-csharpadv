﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GoodPractices
{
    public class Loops
    {
        List<string> strings = new List<string>() { "Bob", "Jordan", "Jill", "Greg", "Anne", "Maximilian" };

        public void LoopsExamples()
        {
            // Bad example
            // Print all names that are the same length of the list
            for (int counter = 0; counter < strings.Count; counter++)
            {
                if (strings[counter].Length == strings.Count)
                {
                    Console.WriteLine(strings[counter]);
                }
            }

            // Good example
            // Print all names that are the same length of the list
            int listLength = strings.Count;
            for (int i = 0; i < listLength; i++)
            {
                if (strings[i].Length == listLength)
                {
                    Console.WriteLine(strings[i]);
                }
            }


            foreach(string item in strings)
            {
                if(item == "Jill")
                {
                    Console.WriteLine("We found Jill");
                    break;
                }
            }
        }

    }
}