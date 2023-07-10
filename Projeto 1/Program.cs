using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{


     class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            bool EXIT = false;
            while (!EXIT)
            {
                Console.WriteLine("Welcome to the CALC, select the option: ");
                Console.WriteLine("1- Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

               switch (opcao)
                {
                            case Menu.Soma:
                            Soma();
                                break;
                            case Menu.Subtracao:
                            Sub();
                                break;
                            case Menu.Divisao:
                            Div();
                                break;
                            case Menu.Multiplicacao:
                            Mult();
                                break;
                            case Menu.Potencia:
                            Pot();
                                break;
                            case Menu.Raiz:
                            Raiz();
                                break;
                            case Menu.Sair:
                            EXIT = true;
                                break;
                }
                
                Console.Clear();

            }
            
        }

        static void Soma()
        {
            Console.WriteLine("sum of two numbers: ");
            Console.WriteLine("Type the first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine($"the result is :{result} ");
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("subtraction of two numbers: ");
            Console.WriteLine("Type the first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int b = int.Parse(Console.ReadLine());
            int result = a - b;
            Console.WriteLine($"the result is :{result} ");
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("division between two numbers: ");
            Console.WriteLine("Type the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a/(float)b;
            Console.WriteLine($"the result is :{result} ");
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplication between two numbers: ");
            Console.WriteLine("Type the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int b = int.Parse(Console.ReadLine());
            int result = a *b;
            Console.WriteLine($"the result is :{result} ");
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Power of a number: ");
            Console.WriteLine("Type the base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the exponent: ");
            int expo = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"the result is :{result} ");
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Root of a number: ");
            Console.WriteLine("Type the number: ");
            int a = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(a);
            Console.WriteLine($"the result is :{result} ");
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
        }
    }
}
