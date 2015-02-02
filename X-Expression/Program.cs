using System;



class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();

        decimal result = 0;

        decimal currentBracketResult = 0;

        char currentOperator = '+';

        char currentBracketOperator = '+';

        bool inBracket = false;

        foreach (char symbol in expression)
        {
            if (symbol == '(')
            {
                inBracket = true;
                continue;
            }
            if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
            {
                currentOperator = symbol;
            }
            if (char.IsDigit(symbol))
            {
                int currentNumber = symbol - '0';
                switch (currentOperator)
                {
                    case '+': result += currentNumber;
                        break;
                    case '-': result -= currentNumber;
                        break;
                    case '*': result *= currentNumber;
                        break;
                    case '/': result /= currentNumber;
                        break;
                       
                    default:
                        break;
                }
            }
        }
       Console.WriteLine("{0:F2}", result);
    }
}

