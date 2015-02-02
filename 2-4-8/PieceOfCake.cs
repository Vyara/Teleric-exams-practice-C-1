

using System;



class Program
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long D = long.Parse(Console.ReadLine());

        long resultNominator = ((A * D ) + (B * C));
        long resultDenominator = (B * D);
        decimal result = ((decimal)resultNominator / resultDenominator);

        if (result >= 1)
        {
            Console.WriteLine((long)result);

        }
        else
        {
            Console.WriteLine("{0:F22}", result);

        }

        Console.WriteLine(resultNominator + "/" + resultDenominator);
    }
}

