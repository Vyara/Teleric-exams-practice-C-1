

using System;



class AngryFEmaleGPS
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.Trim('-');
        long positivSum = 0;
        long negativeSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int num = (int)Char.GetNumericValue(input[i]);
            if (num % 2 == 0)
            {
                positivSum += num;
            }
            else
            {
                negativeSum += num;
            }
        }
        if (positivSum - negativeSum > 0)
        {
            Console.WriteLine("right " + positivSum);
        }
        else if (positivSum - negativeSum < 0)
        {
            Console.WriteLine("left " + negativeSum);
        }
        else
        {
            Console.WriteLine("straight " + positivSum);
        }
    }
}



