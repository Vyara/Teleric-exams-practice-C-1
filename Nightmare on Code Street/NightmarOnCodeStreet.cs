

using System;


class NightmarOnCodeStreet
{
    static void Main()
    {
        string text = Console.ReadLine();
        int digit =0;
        long sum = 0;
        long digits = 0;

        for (int i = 1; i < text.Length; i+= 2)
        {
            bool isDigit = int.TryParse(text[i].ToString(), out digit);
           
            if (isDigit)
            {
                sum += digit;
                digits++;
            }
        }

        Console.WriteLine(digits + " " + sum);
    }
}

