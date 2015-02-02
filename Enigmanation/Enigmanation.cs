using System;



class Enigmanation
{
    static void Main()
    {
        string expression = Console.ReadLine();
        int count = 0;
        long sum = 0;
        long bracketsSum = 0;
        char operation = '+';
        while (expression[count] != '=')
        {
            if (expression[count] == '(')
            {
                char operationBrackets = '+';
                while (expression[count] != ')')
                {
                    if (Char.IsDigit(expression[count]))
                    {

                        switch (operationBrackets)
                        {
                            case '+': bracketsSum += expression[count] - '0';
                                break;
                            case '-': bracketsSum -= expression[count] - '0';
                                break;
                            case '*': bracketsSum *= expression[count] - '0';
                                break;
                            case '%': bracketsSum %= expression[count] - '0';
                                break;

                        }
                    }
                    else
                    {
                        if (expression[count] != '(')
                        {
                            operationBrackets = expression[count];
                        }
                    }
                    count++;

                }

                switch (operation)
                {
                    case '+': sum += bracketsSum;
                        break;
                    case '-': sum -= bracketsSum;
                        break;
                    case '*': sum *= bracketsSum;
                        break;
                    case '%': sum %= bracketsSum;
                        break;

                }
                bracketsSum = 0;
            }

            if (Char.IsDigit(expression[count]))
            {

                switch (operation)
                {
                    case '+': sum += expression[count] - '0';
                        break;
                    case '-': sum -= expression[count] - '0';
                        break;
                    case '*': sum *= expression[count] - '0';
                        break;
                    case '%': sum %= expression[count] - '0';
                        break;

                }
            }
            else
            {
                if (expression[count] != '('&& expression[count] != ')')
                {
                    operation = expression[count];
                }
 
            }
            count++;
        }

        Console.WriteLine("{0:F3}", sum + bracketsSum);
    }

}

