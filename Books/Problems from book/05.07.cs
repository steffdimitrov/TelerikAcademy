using System;

namespace BookHomeworks
{
    class Chapter05Problem07
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ������� �����: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int max = firstNumber;
            Console.Write("�������� ������� �����: ");
            int secondNumber = int.Parse(Console.ReadLine());
            max = (max > secondNumber ? max : secondNumber);
            Console.Write("�������� ������� �����: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            max = (max > thirdNumber ? max : thirdNumber);
            Console.Write("�������� ���������� �����: ");
            int fourthNumber = int.Parse(Console.ReadLine());
            max = (max > fourthNumber ? max : fourthNumber);
            Console.Write("�������� ������ �����: ");
            int fifthNumber = int.Parse(Console.ReadLine());
            max = (max > fifthNumber ? max : fifthNumber);
            Console.WriteLine("\n���-�������� ����� � {0}", max);
        }
    }
}