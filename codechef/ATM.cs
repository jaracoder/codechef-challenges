using System;
using System.Globalization;

namespace codechef
{
    class ATM
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');

            // dinero a retirar
            int x = int.Parse(line[0]);

            // balance en cuenta
            double y = double.Parse(line[1], CultureInfo.InvariantCulture);
            
            // comision
            double comision = 0.50f;

            // si no es multiplo de 5 o no hay balance en cuenta
            if ( (x % 5 != 0) || ((x + comision) > y) )
            {
                Console.WriteLine(y);
                return;
            }
            
            // muestra balance despues de retirar dinero
            double result = y - (x + comision);
            Console.WriteLine(result.ToString("f2"));
        }
    }
}
