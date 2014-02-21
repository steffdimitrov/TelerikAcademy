using System;

namespace ConsoleApplication
{
    class Chapter06Problem17
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ������� �����: ");
            int firstNumber= int.Parse(Console.ReadLine());
            Console.Write("�������� ������� �����: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int greatestCommonDivider = 0;
            int buffer = 1;
            if (secondNumber > firstNumber)
            {
                buffer= firstNumber;
                firstNumber = secondNumber;
                secondNumber = buffer;
            }
            Console.Write("���-�������� ���� ������ �� {0} � {1} � ", firstNumber, secondNumber);
            if (firstNumber % secondNumber == 0)
            {
                greatestCommonDivider = secondNumber;
            }
            else
            {
                while (buffer != 0)
                {
                    greatestCommonDivider = buffer;
                    buffer = firstNumber % secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = buffer;
                }
            }
            Console.WriteLine(greatestCommonDivider);
        }
    }
}