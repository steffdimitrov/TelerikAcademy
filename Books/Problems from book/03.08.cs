using System;

namespace ConsoleApplication1
{
    class Chapter03Problem08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ������ �� �������: ");
            string x = System.Console.ReadLine();
            double xDouble = Convert.ToDouble(x);
            Console.WriteLine("�������� �������� �� �������: ");
            string y = System.Console.ReadLine();
            double yDouble = Convert.ToDouble(y);            
            Console.WriteLine((xDouble*xDouble+yDouble*yDouble)<25 ? "������� � � �����������" : "������� �� � � �����������");            
        }
    }
}
