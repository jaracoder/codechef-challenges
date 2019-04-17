using System;

namespace codechef
{
    class EnormousInputTest
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
                
            int n = int.Parse(line[0]);
            int k = int.Parse(line[1]);
            int total = 0, number;

            int i = 0;
            for (; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number % k == 0)
                    total++;
            }

            Console.WriteLine(total);
        }
    }
}
