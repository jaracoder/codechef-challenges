// jripoll.dev

using System;

class FLOW001
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        string[] ab;

        for (int i = 0; i < t; i++)
        {
            ab = Console.ReadLine().Split(' ');
            Console.WriteLine(
                int.Parse(ab[0]) + int.Parse(ab[1])
            );
        }
    }
}

