// jripoll.dev

using System;

class FLOW006
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        int total, sum;
        string number;

        for (int i = 0; i < t; i++)
        {
            number = Console.ReadLine();
            total = number.Length;
            sum = 0;
            
            for (int j = 0; j < total; j++)
            {
                sum += int.Parse(number[j].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}

