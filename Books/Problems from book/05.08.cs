using System;

namespace BookHomeworks
{
    class Chapter05Problem08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ����� �����:");
            Console.WriteLine("1. ���� �����");
            Console.WriteLine("2. �����");
            Console.WriteLine("3. �����");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    {
                        Console.Write("������ ����� � ���� �����. �������� ���� �����: ");
                        int firstChoice = int.Parse(Console.ReadLine());
                        firstChoice++;
                        Console.WriteLine(firstChoice);
                    }
                    break;
                case 2:
                    {
                        Console.Write("������ ����� � �����. �������� �����: ");
                        double secondChoice = double.Parse(Console.ReadLine());
                        secondChoice++;
                        Console.WriteLine(secondChoice);
                    }
                    break;
                case 3:
                    {
                        Console.Write("������ ����� � �����. �������� �����: ");
                        string thirdChoice = Console.ReadLine();
                        Console.WriteLine(thirdChoice + "*");
                    }
                    break;
                default: break;
            }
        }
    }
}