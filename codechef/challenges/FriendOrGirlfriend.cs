// jripoll.dev - 19/04/2019
// FriendOrGirfriend.cs
// Problem Code: STRCH

using System;

class FriendOrGirlfriend
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        int i = 0;
        int j = 0;

        long total;
        long sum, res;

        string[] line;
        string text;

        char letter;
        
        for (; i < t; i++)
        {
            total = long.Parse(Console.ReadLine());
            line = Console.ReadLine().Split(' ');
            text = line[0];
            letter = char.Parse(line[1]);
            sum = 0;
            res = 0;

            for (j = 0; j < total; j++)
            {
                if (text[j] == letter)
                {
                    sum += (j - res + 1) * (total - j);
                    res = j + 1;
                }
            }

            Console.WriteLine(sum);
        }

#if DEBUG
        Console.ReadLine();
#endif
    }
}

