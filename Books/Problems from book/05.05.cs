using System;

namespace BookHomeworks
{
    class Chapter05Problem05
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ����� �� 1 - 9: ");
            int numberToSay= int.Parse(Console.ReadLine());
            string sayNumber = "";
            bool errorValue = false;
            switch (numberToSay)
            {
                case 1: sayNumber = "����"; break;
                case 2: sayNumber = "���"; break;
                case 3: sayNumber = "���"; break;
                case 4: sayNumber = "������"; break;
                case 5: sayNumber = "���"; break;
                case 6: sayNumber = "����"; break;
                case 7: sayNumber = "�����"; break;
                case 8: sayNumber = "����"; break;
                case 9: sayNumber = "�����"; break;
                default: errorValue = true; break;
            }
            if (errorValue)
            {
                Console.WriteLine("���������� ����� �� � � ��������� �� 1 - 9");
            }
            else
            {
                Console.WriteLine("��������� ������� " + sayNumber);
            }
        }
    }
}