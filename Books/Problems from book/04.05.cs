using System;

namespace BookHomeworks
{
    class Chapter04Problem05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ������� �������");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("�������� ������� �������");
            int b = int.Parse(Console.ReadLine());
            int n = 0; //���� ����� ������ �� �� ��� � ��������� [a;b]
            n = n + (a % 5 == 0 ? 1 : 0);
            n = n + (b % 5 == 0 ? 1 : 0);
            n = n + (a == 0 ? -1 : 0);
            n = n + (b == 0 ? -1 : 0);
            if (a > b)
            {
                n = n + (a - b - 1) / 5;
            }
            else
            {
                n = n + (b - a - 1) / 5;
            }
            Console.WriteLine("� ��������� {0} - {1} ��� ����� {2} �����, ����� �� ����� �� ��� ��� �������!", a, b, n);
        }
    }
}
