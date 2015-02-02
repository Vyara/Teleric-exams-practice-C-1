using System;



class Eggcelent
{
    static void Main()
    {
        long eggSize = long.Parse(Console.ReadLine());
        long drawingHeight = 2 * eggSize;
        long drawingWidth = 3 * eggSize + 1;

        string[,] drawing = new string[drawingHeight, drawingWidth];

        //drawind all dots matrix
        for (int row = 0; row < drawingHeight; row++)
        {
            for (int col = 0; col < drawingWidth; col++)
            {
                drawing[row, col] = ".";
            }

        }

        //drawing top and bottom
        for (int i = 0; i < eggSize - 1; i++)
        {
            drawing[0, eggSize + 1 + i] = "*";
            drawing[drawingHeight - 1, eggSize + 1 + i] = "*";
        }

        //drawing both top diagonalically dalling stars
        int count = 1;

        for (int i = 0; i < eggSize / 2; i++)
        {
            drawing[i + 1, (eggSize - i - count)] = "*";
            drawing[i + 1, ((2 * eggSize) + i + count)] = "*";
            count++;
        }

        //drawing straight lines of stars in the centre
        for (int i = 0; i < eggSize; i++)
        {
            drawing[eggSize / 2 + i, 1] = "*";
            drawing[eggSize / 2 + i, drawingWidth - 2] = "*";
        }

        //drawing both bottom diagonalically dalling stars
        count = 1;

        for (int i = 0; i < eggSize / 2; i++)
        {

            drawing[drawingHeight - 2 - i, (eggSize - i - count)] = "*";
            drawing[drawingHeight - 2 - i, ((2 * eggSize) + i + count)] = "*";

            count++;
        }
        //first line middle

        for (int i = 0; i < drawingWidth - 4; i += 2)
        {

            drawing[drawingHeight / 2 - 1, 2 + i] = "@";

        }

        //second line middle
        for (int i = 0; i < drawingWidth - 5; i += 2)
        {

            drawing[drawingHeight / 2, 3 + i] = "@";

        }

        //for checking
        for (int row = 0; row < drawingHeight; row++)
        {
            for (int col = 0; col < drawingWidth; col++)
            {
                Console.Write(drawing[row, col]);
            }
            Console.WriteLine();
        }
    }
}



