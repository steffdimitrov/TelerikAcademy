using System;

namespace BookHomeworks
{
    class Chapter05Problem10
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ����� �� 1 �� 9: ");
            int number= int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    number *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    number *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    number *= 1000;
                    break;
                default: number = -1; break;
            }
            string text = (number < 0 ? "���������� ����� �� � ����� 1 � 9" : (""+number));
            Console.WriteLine(text);
        }
    }
}