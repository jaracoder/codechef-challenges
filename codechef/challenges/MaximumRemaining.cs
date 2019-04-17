// jripoll.dev - 05/04/2019

using System;
using System.Collections.Generic;
using System.Linq;

class MaximumRemaining
{
    static void Main()
    {
        Console.ReadLine();

        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .Distinct()
            .ToList()
            .OrderByDescending(x => x)
            .ToList();

        if (nums.Count > 1 && nums[0] > 0)
            Console.WriteLine(nums[1] % nums[0]);
        else
            Console.WriteLine("0");

#if DEBUG
        Console.ReadLine();
#endif
    }
}

