using System;

namespace ConsoleApplication1
{
    class Chapter03Problem06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ����������: ");
            string width = System.Console.ReadLine();
            double w = Convert.ToDouble(width);
            Console.WriteLine("�������� ����������: ");
            string height = System.Console.ReadLine();
            double h = Convert.ToDouble(height);
            double perimeter = 2 * w + 2 * h;            
            double area = w*h;
            Console.WriteLine("������ � "+area+" ��������� ���� ��");
            Console.WriteLine("���������� � " + perimeter + " ���� ��");
        }
    }
}
