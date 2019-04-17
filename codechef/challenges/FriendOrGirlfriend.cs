// jripoll.dev - 05/04/2019
// FriendOrGirfriend.cs

using System;

class FriendOrGirlfriend
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        string[] line;
        string text;
        char letter;
        
        int i = 0, j;
        int total;
        int sum, res;

        for (; i < t; i++)
        {
            total = int.Parse(Console.ReadLine());
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

