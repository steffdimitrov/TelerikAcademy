using System;

namespace ConsoleApplication
{
    class Chapter06Problem11
    {
        static void Main(string[] args)
        {
            Console.Write("�������� N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! � � {1} ���� 0", N, (N / 5));//����� �� ������ �� ��������� � ���� �� ����� ���� ��������!
        }
    }
}