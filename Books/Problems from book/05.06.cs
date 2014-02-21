using System;

namespace BookHomeworks
{
    class Chapter05Problem06
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ����������� �: ");
            double parameterA = int.Parse(Console.ReadLine());
            Console.Write("�������� ����������� b: ");
            double parameterB = int.Parse(Console.ReadLine());
            Console.Write("�������� ����������� c: ");
            double parameterC = int.Parse(Console.ReadLine());
            double determinant = parameterB * parameterB - 4 * parameterA * parameterC;
            if (determinant < 0)
            {
                Console.WriteLine("\n����������� ���� ������ �������.");
            }
            else
            {
                if (determinant == 0)
                {
                    double xFirst = (-parameterB) / (2 * parameterA);
                    double xSecond = xFirst;
                    Console.WriteLine("\n����������� ��� ���� ����� ����� {0}", xFirst);
                }
                else
                {
                    double xFirst = (-parameterB + Math.Sqrt(determinant)) / (2 * parameterA);
                    double xSecond = (-parameterB - Math.Sqrt(determinant)) / (2 * parameterA);
                    Console.WriteLine("\n����������� ��� ��� ������ {0} � {1}", xFirst, xSecond);
                }
            }
        }
    }
}