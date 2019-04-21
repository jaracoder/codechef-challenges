// jripoll.dev

using System;

class FLOW002
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        string[] ab;
        int a, b;

        for (int i = 0; i < t; i++)
        {
            ab = Console.ReadLine().Split(' ');
            a = int.Parse(ab[0]);
            b = int.Parse(ab[1]);

            Console.WriteLine(a % b);
        }
    }
}

