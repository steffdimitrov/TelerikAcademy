using System;

namespace BookHomeworks
{
    class Chapter04Problem09
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int det;
            bool aIsNumber = false;
            while (!aIsNumber)
                {
                    Console.WriteLine("�������� ���������� �: ");
                    string userInput = Console.ReadLine();
                    aIsNumber = Int32.TryParse(userInput, out a);
                }
            bool bIsNumber = false;
            while (!bIsNumber)
                {
                    Console.WriteLine("�������� ���������� b: ");
                    string userInput = Console.ReadLine();
                    bIsNumber = Int32.TryParse(userInput, out b);
                }
            bool cIsNumber = false;    
            while (!cIsNumber)
                {
                    Console.WriteLine("�������� ���������� c: ");
                    string userInput = Console.ReadLine();
                    cIsNumber = Int32.TryParse(userInput, out c);
                }
            det = b * b - 4 * a * c;
            if (det < 0)
            {
                Console.WriteLine("�������������� � ��-����� �� 0. ����������� ���� ������ ������");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(Convert.ToDouble(det))) / (2 * a);
                double x2 = (-b - Math.Sqrt(Convert.ToDouble(det))) / (2 * a);
                Console.WriteLine("�������� �� ����������� ��:");
                Console.WriteLine("�1: {0}", x1);
                Console.WriteLine("�2: {0}", x1);
            }
        }
    }
}
