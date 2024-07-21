using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Calculations;

public class Calculator
{
    public static double Calculators(double number1, double number2, char operators)
    {
        double result = 0;

        switch (operators)
        {
            case '+':
                result = Sum(number1, number2);
                Console.WriteLine($"{result}");
                break;
            case '-':
                result = Subtract(number1, number2);
                Console.WriteLine($"{result}");
                break;
            case '*':
                result = Multiply(number1, number2);
                Console.WriteLine($"{result}");
                break;
            case '/':
                result = Divide(number1, number2);
                Console.WriteLine($"{result}");
                break;
            case '^':
                //Potencia
                result = Powers(number1, number2);
                Console.WriteLine($"{result}");
                break;
            case 'r':
                //RaizQuadrada
                result = SquareRoot(number1);
                Console.WriteLine($"{result}");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        return result;
    }

    private static double Sum(double a, double b)
    {
        return a + b;
    }

    private static double SquareRoot(double a)
    {
        return Math.Sqrt(a);
    }

    private static double Divide(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return 0;
        }
    }

    private static double Multiply(double a, double b)
    {
        return a * b;
    }

    private static double Subtract(double a, double b)
    {
        return a - b;
    }

    private static double Powers(double a, double b)
    {
        return Math.Pow(a, b);
    }
}

