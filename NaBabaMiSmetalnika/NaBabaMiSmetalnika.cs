using System;



class NaBabaMiSmetalnika
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        //long first = long.Parse(Console.ReadLine());
        //long second = long.Parse(Console.ReadLine());
        //long third = long.Parse(Console.ReadLine());
        //long fourth = long.Parse(Console.ReadLine());
        //long fifth = long.Parse(Console.ReadLine());
        //long sixth = long.Parse(Console.ReadLine());
        //long seventh = long.Parse(Console.ReadLine());
        //long eight = long.Parse(Console.ReadLine());
        //string first = Convert.ToString(Console.ReadLine(), 2).PadLeft(width, '0');
        char[,] smetalo = new char[8, width];

        //
        //creating smetalo matrix
        for (int row = 0; row < 8; row++)
        {
            long number = long.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2).PadLeft(width, '0');
            for (int col = 0; col < width; col++)
            {
                smetalo[row, col] = binary[col];
            }
        }
        while (true)
        {
            string instruction = Console.ReadLine();

            int ones = 0;
            //instruction right
            if (instruction == "right")
            {
                int prustRow = int.Parse(Console.ReadLine());
                int prustCol = int.Parse(Console.ReadLine());
                //prust outside width
                if (prustCol > width || prustCol < 0)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (smetalo[prustRow, col] == '1')
                        {
                            ones++;
                        }
                    }

                    for (int i = 0; i < ones; i++)
                    {
                        smetalo[prustRow, width - 1 - i] = '1';
                        smetalo[prustRow, i] = '0';
                    }
                }

                else
                {
                    ones = 0;
                    for (int col = 0; col < width - (prustCol + 1); col++)
                    {
                        if (smetalo[prustRow, prustCol + col] == '1')
                        {
                            ones++;
                        }
                    }

                    for (int i = 0; i < ones; i++)
                    {
                        smetalo[prustRow, width - 1 - i] = '1';
                    }
                    for (int i = 0; i < width - prustCol - ones; i++)
                    {
                        smetalo[prustRow, prustCol + i] = '0';
                    }
                }
            }

            //instruction left
            if (instruction == "left")
            {
                int prustRow = int.Parse(Console.ReadLine());
                int prustCol = int.Parse(Console.ReadLine());
                //prust outside width
                if (prustCol > width || prustCol < 0)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (smetalo[prustRow, width - 1 - col] == '1')
                        {
                            ones++;
                        }
                    }

                    for (int i = 0; i < ones; i++)
                    {
                        smetalo[prustRow, width - 1 - i] = '0';
                        smetalo[prustRow, i] = '1';
                    }
                }

                else
                {
                    ones = 0;
                    for (int col = 0; col <= prustCol; col++)
                    {
                        if (smetalo[prustRow, prustCol - col] == '1')
                        {
                            ones++;
                        }
                    }

                    for (int i = 0; i < ones; i++)
                    {
                        smetalo[prustRow, i] = '1';

                    }

                    for (int i = 0; i < prustCol - ones; i++)
                    {
                        smetalo[prustRow, prustCol - i] = '0';
                    }
                }
            }

            //instruction is reset
            if (instruction == "reset")
            {
                // 0 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[0, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[0, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[0, width - 1 - i] = '0';
                }

                // 1 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[1, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[1, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[1, width - 1 - i] = '0';
                }

                // 2 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[2, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[2, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[2, width - 1 - i] = '0';
                }

                // 3 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[3, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[3, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[3, width - 1 - i] = '0';
                }

                // 4 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[4, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[4, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[4, width - 1 - i] = '0';
                }

                // 5 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[5, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[5, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[5, width - 1 - i] = '0';
                }

                // 6 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[6, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[6, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[6, width - 1 - i] = '0';
                }

                // 7 row
                ones = 0;

                for (int i = 0; i < width; i++)
                {
                    if (smetalo[7, i] == '1')
                    {
                        ones++;
                    }
                }

                for (int i = 0; i < ones; i++)
                {
                    smetalo[7, i] = '1';
                }

                for (int i = 0; i < width - ones; i++)
                {
                    smetalo[7, width - 1 - i] = '0';
                }
            }

            // instruction is stop
            if (instruction == "stop")
            {
                break;
            }
        }
        long sumLines = 0;
        //converting rows to decimal and summing them

        //string newbinary = null;
        //for (int i = 0; i < width; i++)
        //{
        //    newbinary += smetalo[0, i];
        //}

        for (int i = 0; i < 8; i++)
        {
            string newbinary = null;
            for (int j = 0; j < width; j++)
            {
                newbinary += smetalo[i, j];
            }
            sumLines += Convert.ToInt64(newbinary, 2);
        }

        //finds all zero columns and counts them
        int colcount = 0;
        for (int col = 0; col < width; col++)
        {
            string column = null;
            for (int row = 0; row < 8; row++)
            {
                column += smetalo[row, col];
            }
            if (column == new string('0', 8))
            {
                colcount++;
            }
        }
        //calculates and prints result
        long result = sumLines * colcount;
        Console.WriteLine(result);
        //Console.WriteLine(colcount);
        //Console.WriteLine(sumLines);

        ////for checking
        ////for (int row = 0; row < 8; row++)
        ////{
        ////    for (int col = 0; col < width; col++)
        ////    {
        ////        Console.Write(smetalo[row, col]);
        ////    }
        ////    Console.WriteLine();
        ////}

    }
}

