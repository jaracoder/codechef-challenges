// jripoll.dev
// 15/05/2019

using System;

class CIELRCPT
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        int[] menu = new int[] { 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
        int count = 0;

        for (int i = 0; i < t; i++)
        {
            int r = int.Parse(Console.ReadLine());

            foreach (int n in menu)
            {
                while (r >= n)
                {
                    count++;
                    r -= n;
                }
            }

            Console.WriteLine(count);
            count = 0;
        }
    }
}

