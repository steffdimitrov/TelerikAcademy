using System;

namespace ConsoleApplication
{
    class Chapter06Problem12
    {
        static void Main(string[] args)
        {
            Console.Write("�������� N: ");
            int N = int.Parse(Console.ReadLine());
            string decToBin = "";
            Console.Write("��������� {0} = ������� ", N);
            int ostatak = 0;
            while (N > 0)
            {
                ostatak = N % 2;
                decToBin = ostatak + decToBin;
                N = N / 2;
            }
            Console.WriteLine(decToBin);
        }
    }
}