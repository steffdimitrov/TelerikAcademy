using System;

namespace BookHomeworks
{
    class Chapter04Problem02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ������� �� �����");
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("���������� �� ����������� � {0:F2}", (2 * Math.PI * r));
            Console.WriteLine("������ �� ����� � {0:F3}", (Math.PI * r * r));
        }
    }
}
