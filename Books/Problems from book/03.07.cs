using System;

namespace ConsoleApplication1
{
    class Chapter03Problem07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ������ ����: ");
            string mass = System.Console.ReadLine();
            double massDouble = Convert.ToDouble(mass);
            double weightOnEarth = massDouble * 9.81;
            double weightOnMoon = massDouble * 9.81 * 0.18;
            Console.WriteLine("������ ����� �� ������ � "+weightOnEarth+" N");
            Console.WriteLine("������ ����� �� ������ � " + weightOnMoon+ " N");
        }
    }
}
