using System;

namespace ConsoleApplication
{
    class Chapter06Problem01
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ���� �� �������: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
