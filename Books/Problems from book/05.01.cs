using System;

namespace BookHomeworks
{
    class Chapter05Problem01
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ������� �����: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("�������� ������� �����: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int theBigOne;
            if (firstNumber > secondNumber)
            {
                theBigOne = firstNumber;
                firstNumber = secondNumber;
                secondNumber = theBigOne;
            }
            Console.WriteLine("��-�������� ����� � {0}", secondNumber);
        }
    }
}