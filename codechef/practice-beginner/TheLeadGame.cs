// jripoll.dev

using System;

class TLG
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        string[] score12;

        int score1 = 0, score2 = 0;
        int max_leader = 0;
        int winner = 0;
        int diff;

        for (int i = 0; i < t; i++)
        {
            score12 = Console.ReadLine().Split(' ');

            score1 = score1 + int.Parse(score12[0]);
            score2 = score2 + int.Parse(score12[1]);
            
            diff = score1 - score2;

            if (Math.Abs(diff) > max_leader)
            {
                max_leader = Math.Abs(diff);
                if (diff > 0)
                    winner = 1;
                else
                    winner = 2;
            }
        }

        Console.Write(winner + " " + max_leader);
    }
}

