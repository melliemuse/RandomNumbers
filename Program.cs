﻿using System;
using System.Collections.Generic;

namespace Random_Numbers
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
}; 
for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
   if (numbers.Contains(i)) {
       Console.WriteLine($"{i} is in the list");
   } 
   else {
       Console.WriteLine($"{i} is not in the list");
   }
};
        }
    }
}
