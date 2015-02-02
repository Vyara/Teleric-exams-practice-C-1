using System;



class OnesАndZeros
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string binary = Convert.ToString(input, 2).PadLeft(32, '0');
        //char[] charArray = binary.ToCharArray();
        //Array.Reverse(charArray);
        //Console.WriteLine(binary);
        //Console.WriteLine(charArray);
        //Console.WriteLine(binary[1]);
        for (int row = 0; row < 5; row++)
        {
            for (int i = 16; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    switch (row)
                    {
                        case 0:
                        case 4:
                            Console.Write("###");
                            break;
                        case 1:
                        case 2:
                        case 3:
                            Console.Write("#.#");
                            break;
                    }

                }
                else if (binary[i] == '1')
                {
                    switch (row)
                    {
                        case 0:
                        case 2:
                        case 3:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 4:
                            Console.Write("###");
                            break;
                    }
                }
                if (i < 31)
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();
        }
    }

}
