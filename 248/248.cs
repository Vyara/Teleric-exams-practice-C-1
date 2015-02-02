

using System;



class Program
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long R = 0;

        if (B == 2)
        {
            long firstRemainder = A % C;
            R = firstRemainder;
        }

        if (B == 4)
        {
            long sum = A + C;
            R = sum;
        }

        if (B == 8)
        {
            long product = A * C;
            R = product;
        }

        if (R % 4 == 0)
        {
            Console.WriteLine(R / 4);
        }

        else
        {
            Console.WriteLine(R % 4);
        }

        Console.WriteLine(R);
    }
}

