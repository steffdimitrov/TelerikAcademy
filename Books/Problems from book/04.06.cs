using System;

namespace BookHomeworks
{
    class Chapter04Problem06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ���� �����");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("�������� ����� �����");
            int b = int.Parse(Console.ReadLine());
            int max = a - ((a - b) & ((a - b) >> 31));
            Console.WriteLine("��-�������� �� ����� ����� � {0}", max);
        }
    }
}
