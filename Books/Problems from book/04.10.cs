using System;

namespace BookHomeworks
{
    class Chapter04Problem10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ���� �� �������");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("�������� ����� �{0}", i);
                int bufer = int.Parse(Console.ReadLine());
                bufer = bufer + bufer;
                if (i == count)
                {
                    Console.WriteLine("������ �� ������� � {0}", bufer);
                }
            }
        }
    }
}
