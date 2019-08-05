// jripoll.dev - 05/08/2019
// Football.cs
// Problem Code: MSNSADM1

using System;

class Football
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        int i = 0;
        for (; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());

            int[] goals = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] fouls = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int c = 0;
            int max = 0;
            for (; c < n; c++)
            {
                int goal = goals[c];
                int foul = fouls[c];
                int result = (goal * 20) - (foul * 10);

                if (result > max)
                    max = result;
            }

            Console.WriteLine(max);
        }
           
#if DEBUG
        Console.ReadLine();
#endif
    }
}

