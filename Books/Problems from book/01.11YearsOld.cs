using System;

namespace ConsoleApplication1
{
    class Chapter01Problem11
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("�������� ������ �������:");
            string s = System.Console.ReadLine();
            int year = int.Parse(s);
            int oldnes = int.Parse(s) + 10;
            DateTime today = System.DateTime.Now;
            DateTime after10years = today.AddYears(10);
            System.Console.WriteLine("���� 10 ������ �� {0} �� ��� �� {1} ������",after10years,oldnes);
        }
    }
}

