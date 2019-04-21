// jripoll.dev

// Factorial of 100 has 158 digits..

using System;

class FCTRL2
{  
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        int n, max = 158;

        for (int i = 0; i < t; i++)
        {
            n = int.Parse(Console.ReadLine());
            Factorial(n, max);
        }
    }

    
    static void Factorial(int n, int max)
    {
        int[] digits = new int[ max ];
        int size = 1;

        digits[0] = size;
       
        for (int i = 2; i <= n; i++)
        { 
            size = Multiply(i, digits, size);
        }

        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }

        Console.WriteLine();
    }


    static int Multiply(int index, int[] digits, int size)
    {
        int carry = 0;

        for (int i = 0; i < size; i++)
        {
            int total = digits[i] * index + carry;
            digits[i] = total % 10; 
            carry = total / 10;
        }

        while (carry > 0)
        {
            digits[size] = carry % 10;
            carry = carry / 10;
            size++;
        }

        return size;
    }
}

