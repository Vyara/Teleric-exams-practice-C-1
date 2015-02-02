using System;



class KaspichaniaBoats
{
    static void Main()
    {
        long size = long.Parse(Console.ReadLine());
        long drawingHeight = 6 + ((size - 3) / 2) * 3;
        long drawingWidth = size * 2 + 1;

        string[,] drawing = new string[drawingHeight, drawingWidth];

        //drawind all dots matrix
        for (int row = 0; row < drawingHeight; row++)
        {
            for (int col = 0; col < drawingWidth; col++)
            {
                drawing[row, col] = ".";
            }

        }

        //drawing top
        drawing[0, drawingWidth / 2] = "*";

        //drawing bottom
        for (int i = 0; i < size; i++)
        {
            drawing[drawingHeight - 1, (drawingWidth - size)/ 2 + i] = "*";
        }

        //drawing centre line across
        for (int i = 0; i < drawingWidth; i++)
        {
            drawing[size, i] = "*";
        }

        //drawing top diagonally falling stars
        int count = 1;
        for (int i = 0; i < size - 1; i++)
        {
            drawing[i + 1, (size - count)] = "*";
            drawing[i + 1,  (size + count)] = "*";
            count++;
        }
       
        //drawing bottom diagonally falling stars
        count = 1;

        for (int i = 0; i < size / 2; i++)
        {

            drawing[drawingHeight - 2 - i, (drawingWidth - size) / 2 - count ] = "*";
            drawing[drawingHeight - 2 - i, (drawingWidth - size) / 2 + size + i] = "*";

            count++;
        }

        //drawing a star line in the middle
        for (int i = 0; i < drawingHeight; i++)
        {
            drawing[i, drawingWidth / 2] = "*";
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

