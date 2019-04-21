// jripoll.dev

using System;
using System.Collections.Generic;

class TSORT
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
  
        List<int> nums = new List<int>();
        for (int i = 0; i < t; i++)
            nums.Add(int.Parse(Console.ReadLine()));

        nums.Sort();

        for (int i = 0; i < t; i++)
            Console.WriteLine(nums[i]);
    }
}

