using System;

namespace BookHomeworks
{
    class Chapter05Problem02
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ������� �����: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("�������� ������� �����: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("�������� ������� �����: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            string result;
            int negativeCounter = 0;
            if (firstNumber < 0)
            {
                negativeCounter++;
            }
            if (secondNumber < 0)
            {
                negativeCounter++;
            }
            if (thirdNumber < 0)
            {
                negativeCounter++;
            }
            switch (negativeCounter)
            {
                case 0:
                case 2:
                    result = "�������������� � ����������� (+)"; break;
                case 1:
                case 3:
                    result = "�������������� � ����������� (-)"; break;
                default:
                    result = "���� ��� �������� :("; break;
            }
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                result = "�������������� � 0";
            }
            Console.WriteLine(result);
        }
    }
}